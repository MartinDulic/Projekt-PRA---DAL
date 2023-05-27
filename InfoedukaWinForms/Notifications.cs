using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoedukaWinForms
{
    public partial class Notifications : UserControl
    {
        private bool isAdmin;
        private int userId;

        // enum for notification category
        private enum Category
        {
            Obavijest = 1,
            Događaj = 2,
            Ispit = 3,
            Kolokvij = 4,
            Vježba = 5,
            Predavanje = 6,
            Seminar = 7
        }

        public Notifications(bool isAdmin, int userId)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.userId = userId;
        }

        private void btnExitWindow_Click(object sender, EventArgs e)
        {
            // close the application
            Application.Exit();
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            // load notifications
            LoadNotifications();
        }

        private void LoadNotifications()
        {
            // hide pnlAddNotification
            pnlAddNotification.Visible = false;

            // clear all controls from pnlNotifications
            pnlNotifications.Controls.Clear();

            try
            {
                ISet<Kolegij> kolegiji = new HashSet<Kolegij>();
                ISet<Predavac> predavaci = new HashSet<Predavac>();
                ISet<Obavijest> obavijesti = new HashSet<Obavijest>();

                if (isAdmin)
                {
                    // get all courses from database
                    kolegiji = DataManager.GetKolegijiRepository().GetKolegijiFromFile();
                    // get all lecturers from database
                    predavaci = DataManager.GetPredavacRepository().GetPredavaciFromFile();
                    // get all notifications
                    obavijesti = DataManager.GetObavijestRepository().GetObavijestiFromFile();
                }
                else
                {
                    // get courses from database by user id
                    kolegiji = DataManager.GetKolegijiRepository().GetKolegijiByPredavacId(userId);
                    // get lecturer from database by user id
                    Predavac p = DataManager.GetPredavacRepository().GetPredavacById(userId);
                    predavaci.Add(p);
                    // get notifications from database by user id
                    obavijesti = DataManager.GetObavijestRepository().GetObavijestiByKreatorId(userId);
                }

                // add each notification in a separate dynamically created panel
                foreach (Obavijest o in obavijesti)
                {
                    // create new panel
                    Panel pnlNotification = new Panel();
                    pnlNotification.Dock = DockStyle.Top;
                    pnlNotification.Height = 200;
                    pnlNotification.BackColor = Color.White;
                    pnlNotification.Name = "pnl" + o.Naziv.Trim();
                    pnlNotification.Tag = o.Id;

                    // create new label for notification name
                    Label lblNotificationName = new Label();
                    lblNotificationName.Text = o.Naziv;
                    lblNotificationName.AutoSize = true;
                    lblNotificationName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
                    lblNotificationName.Location = new Point(10, 15);

                    // create new button btnDeleteCourse
                    Button btnDeleteNotification = new Button();
                    btnDeleteNotification.Text = "Obriši Obavijest";
                    btnDeleteNotification.AutoSize = true;
                    btnDeleteNotification.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    btnDeleteNotification.FlatAppearance.BorderSize = 1;
                    btnDeleteNotification.FlatAppearance.BorderColor = Color.Red;
                    btnDeleteNotification.FlatStyle = FlatStyle.Flat;
                    btnDeleteNotification.ForeColor = Color.Red;
                    btnDeleteNotification.Location = new Point(580, 10);
                    btnDeleteNotification.Click += new EventHandler(btnDeleteNotification_Click);
                    // create new button btnEditCourse
                    Button btnEditNotification = new Button();
                    btnEditNotification.Text = "Napravi Izmjenu";
                    btnEditNotification.AutoSize = true;
                    btnEditNotification.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    btnEditNotification.FlatAppearance.BorderSize = 1;
                    btnEditNotification.FlatAppearance.BorderColor = Color.Blue;
                    btnEditNotification.FlatStyle = FlatStyle.Flat;
                    btnEditNotification.ForeColor = Color.Blue;
                    btnEditNotification.Location = new Point(730, 10);
                    btnEditNotification.Click += new EventHandler(btnEditNotification_Click);

                    // create new lable for notification description (ops) position middle left
                    Label lblNotificationDescription = new Label();
                    lblNotificationDescription.Text = o.Opis;
                    lblNotificationDescription.AutoSize = true;
                    lblNotificationDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    lblNotificationDescription.Location = new Point(10, 50);
                    lblNotificationDescription.ForeColor = Color.Black;

                    // create new label for course lecturer position bottom left
                    Label lblNotificationLecturer = new Label();
                    // find lecurer by id from course and set name and surname
                    foreach (Predavac predavac in predavaci)
                    {
                        if (predavac.Id == o.KreatorId)
                        {
                            lblNotificationLecturer.Text = predavac.Ime + " " + predavac.Prezime;
                            break;
                        }
                        else
                        {
                            lblNotificationLecturer.Text = "admin";
                        }
                    }
                    lblNotificationLecturer.AutoSize = true;
                    lblNotificationLecturer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    lblNotificationLecturer.Location = new Point(10, 150);
                    lblNotificationLecturer.ForeColor = Color.Blue;

                    // create new lable for notification category at bottom left
                    Label lblNotificationCategory = new Label();
                    lblNotificationCategory.Text = o.Kategorija;
                    lblNotificationCategory.AutoSize = true;
                    lblNotificationCategory.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
                    lblNotificationCategory.Location = new Point(10, 170);

                    // create new label for date create and date expired at bottom right in format dd.MM.yyyy - dd.MM.yyyy
                    Label lblNotificationDate = new Label();
                    lblNotificationDate.Text = o.DatumObjave.ToString("dd.MM.yyyy") + " - " + o.DatumIsteka.ToString("dd.MM.yyyy");
                    lblNotificationDate.AutoSize = true;
                    lblNotificationDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
                    lblNotificationDate.Location = new Point(700, 170);

                    // add labels to panel
                    pnlNotification.Controls.Add(lblNotificationName);
                    pnlNotification.Controls.Add(btnDeleteNotification);
                    pnlNotification.Controls.Add(btnEditNotification);
                    pnlNotification.Controls.Add(lblNotificationDescription);
                    pnlNotification.Controls.Add(lblNotificationLecturer);
                    pnlNotification.Controls.Add(lblNotificationCategory);
                    pnlNotification.Controls.Add(lblNotificationDate);

                    // add panel
                    pnlNotifications.Controls.Add(pnlNotification);

                    // add empty panel to flLecturers
                    Panel pnlEmpty = new Panel();
                    pnlEmpty.Dock = DockStyle.Top;
                    pnlEmpty.Height = 30;
                    pnlEmpty.BackColor = Color.FromArgb(235, 235, 235);
                    pnlNotifications.Controls.Add(pnlEmpty);
                }


            }
            catch (Exception)
            {
                // descrete notification
                MessageBox.Show("Greška prilikom učitavanja obavijesti!", "Pokušajte ponovno.");
            }

        }

        private void btnEditNotification_Click(object? sender, EventArgs e)
        {
            PrepareAddOrUpdateForm();

            // change label text
            lblAddOrUpdateNtf.Text = "Edit Obavijesti";

            try
            {
                // get selected notification
                int id = Convert.ToInt32(((Button)sender).Parent.Tag);
                Obavijest obavijest = DataManager.GetObavijestRepository().GetObavijestById(id);
                // fill in form with data
                tbHeading.Text = obavijest.Naziv;
                tbDescription.Text = obavijest.Opis;
                cbCategory.SelectedItem = obavijest.Kategorija;
                // fill in cbCourse by obavijest.¸KolegijId
                // get all courses from database
                ISet<Kolegij> kolegiji = DataManager.GetKolegijiRepository().GetKolegijiFromFile();
                foreach (Kolegij kolegij in kolegiji)
                {
                    if (kolegij.Id == obavijest.KolegijId)
                    {
                        cbCourse.SelectedItem = kolegij.Naziv;
                        break;
                    }
                }
                // set button tag to notification id
                btnNotificationCreate.Tag = obavijest.Id;

            }
            catch (Exception)
            {
                // descrete notification
                MessageBox.Show("Greška prilikom izmjene obavijesti!", "Pokušajte ponovno.");
            }
        }

        private void btnDeleteNotification_Click(object? sender, EventArgs e)
        {
            // prompt user to confirm delete
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite obrisati obavijest?", "Potvrda brisanja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            try
            {
                // get notification id from button tag
                int id = (int)((Button)sender).Parent.Tag;
                Obavijest obavijest = DataManager.GetObavijestRepository().GetObavijestById(id);
                // delete notification
                DataManager.GetObavijestRepository().DeleteObavijest(obavijest);
                // refresh form
                LoadNotifications();
            }
            catch (Exception)
            {
                // make descrete notice
                MessageBox.Show("Pogreška pri brisanju obavijesti! Pokušajte ponovno.");
            }
        }

        private void btnAddNotification_Click(object sender, EventArgs e)
        {
            PrepareAddOrUpdateForm();

            // set form title
            lblAddOrUpdateNtf.Text = "Unos Obavijesti";

        }

        private void PrepareAddOrUpdateForm()
        {
            // open pnlAddNotification
            pnlAddNotification.Visible = true;
            // hide main content
            pnlNotifications.Visible = false;
            lbNotification.Visible = false;
            btnAddNotification.Visible = false;

            // fill up cbCategory with categories
            FillUpCbCategory();

            try
            {
                // add courses to cbCourse
                ISet<Kolegij> kolegiji = new HashSet<Kolegij>();

                if (isAdmin)
                {
                    // get all courses
                    kolegiji = DataManager.GetKolegijiRepository().GetKolegijiFromFile();
                }
                else
                {
                    // get courses from database by user id
                    kolegiji = DataManager.GetKolegijiRepository().GetKolegijiByPredavacId(userId);
                }

                foreach (Kolegij k in kolegiji)
                {
                    cbCourse.Items.Add(k);
                    cbCourse.DisplayMember = "Naziv";
                }

            }

            catch (Exception)
            {
                // make descrete notification
                MessageBox.Show("Greška prilikom učitavanja kolegija!", "Pokušajte ponovno.");
            }

        }

        private void FillUpCbCategory()
        {
            // get categories from enum
            Array values = Enum.GetValues(typeof(Category));
            foreach (Category category in values)
            {
                cbCategory.Items.Add(category);
            }
            // set default value
            cbCategory.SelectedIndex = 0;
        }

        private void btnNotificationCancel_Click(object sender, EventArgs e)
        {
            ReturnToMainPanel();
        }

        private void ReturnToMainPanel()
        {
            // hide pnlAddNotification
            pnlAddNotification.Visible = false;
            // show main content
            pnlNotifications.Visible = true;
            lbNotification.Visible = true;
            btnAddNotification.Visible = true;
        }

        private void btnNotificationCreate_Click(object sender, EventArgs e)
        {
            // if sender is edit button
            if (lblAddOrUpdateNtf.Text == "Edit Obavijesti")
            {
                // get selected notification tag id in parent panel
                int id = Convert.ToInt32(((Button)sender).Tag);
                UpdateNotificationById(id);
            }
            else
            {
                // add new notification
                AddNotification();
            }
        }

        private void AddNotification()
        {
            // get notification data from form
            int kolegijId;
            string naziv, opis, kategorija;
            DateTime datumObjave, datumIsteka;
            GetNotificationDataFromForm(out kolegijId, out naziv, out opis, out kategorija, out datumObjave, out datumIsteka);

            // create new notification
            Obavijest obavijest = new Obavijest(kolegijId, userId, naziv, opis, kategorija, datumObjave, datumIsteka);

            try
            {
                // add notification to file
                DataManager.GetObavijestRepository().AddObavijest(obavijest);
            }
            catch (Exception)
            {
                // descrete notice
                MessageBox.Show("Greška prilikom dodavanja obavijesti!", "Pokušajte ponovno.");
            }

            // return to main panel
            ReturnToMainPanel();

            // reload notifications
            LoadNotifications();
        }

        private void GetNotificationDataFromForm(out int kolegijId, out string naziv, out string opis, out string kategorija, out DateTime datumObjave, out DateTime datumIsteka)
        {
            Kolegij kolegij = (Kolegij)cbCourse.SelectedItem;
            kolegijId = kolegij.Id;
            int kreatorId = userId;
            naziv = tbHeading.Text;
            opis = tbDescription.Text;
            kategorija = cbCategory.SelectedItem.ToString();
            // DatumObjve today
            datumObjave = DateTime.Today;
            // DatumIsteka after 2 months
            datumIsteka = DateTime.Today.AddMonths(2);
        }

        private void UpdateNotificationById(int id)
        {
            // get notification data from form
            int kolegijId;
            string naziv, opis, kategorija;
            DateTime datumObjave, datumIsteka;
            GetNotificationDataFromForm(out kolegijId, out naziv, out opis, out kategorija, out datumObjave, out datumIsteka);

            // get notification by id
            Obavijest obavijest = DataManager.GetObavijestRepository().GetObavijestById(id);
            // update notification
            obavijest.KolegijId = kolegijId;
            obavijest.Naziv = naziv;
            obavijest.Opis = opis;
            obavijest.Kategorija = kategorija;
            obavijest.DatumObjave = datumObjave;
            obavijest.DatumIsteka = datumIsteka;

            // update notification in file
            DataManager.GetObavijestRepository().UpdateObavijest(obavijest);

            ReturnToMainPanel();

            // reload notifications
            LoadNotifications();
        }
    }
}
