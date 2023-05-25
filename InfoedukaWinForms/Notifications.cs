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
            Dogadaj = 2,
            Ispit = 3,
            Kolokvij = 4,
            Vjezba = 5,
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
                    ////create new label for course name position top left
                    //Label lblCourseName = new Label();
                    //lblCourseName.Text = kolegij.Naziv;
                    //lblCourseName.AutoSize = true;
                    //lblCourseName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
                    //lblCourseName.Location = new Point(10, 15);
                    //// create new button btnDeleteCourse
                    //Button btnDeleteCourse = new Button();
                    //btnDeleteCourse.Text = "Obriši Kolegij";
                    //btnDeleteCourse.AutoSize = true;
                    //btnDeleteCourse.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    //btnDeleteCourse.FlatAppearance.BorderSize = 1;
                    //btnDeleteCourse.FlatAppearance.BorderColor = Color.Red;
                    //btnDeleteCourse.FlatStyle = FlatStyle.Flat;
                    //btnDeleteCourse.ForeColor = Color.Red;
                    //btnDeleteCourse.Location = new Point(580, 10);
                    //btnDeleteCourse.Click += new EventHandler(btnDeleteCourse_Click);
                    //// create new button btnEditCourse
                    //Button btnEditCourse = new Button();
                    //btnEditCourse.Text = "Napravi Izmjenu";
                    //btnEditCourse.AutoSize = true;
                    //btnEditCourse.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    //btnEditCourse.FlatAppearance.BorderSize = 1;
                    //btnEditCourse.FlatAppearance.BorderColor = Color.Blue;
                    //btnEditCourse.FlatStyle = FlatStyle.Flat;
                    //btnEditCourse.ForeColor = Color.Blue;
                    //btnEditCourse.Location = new Point(700, 10);
                    //btnEditCourse.Click += new EventHandler(btnEditCourse_Click);
                    //// create new lable for course description (opsi) position middle left
                    //Label lblCourseDescription = new Label();
                    //lblCourseDescription.Text = kolegij.Opis;
                    //lblCourseDescription.AutoSize = true;
                    //lblCourseDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    //lblCourseDescription.Location = new Point(10, 100);
                    //// create new label for course lecturer position bottom left
                    //Label lblCourseLecturer = new Label();
                    //// find lecurer by id from course and set name and surname
                    //foreach (Predavac predavac in predavaci)
                    //{
                    //    if (predavac.Id == kolegij.PredavacId)
                    //    {
                    //        lblCourseLecturer.Text = predavac.Ime + " " + predavac.Prezime;
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        lblCourseLecturer.Text = " ";
                    //    }
                    //}
                    //lblCourseLecturer.AutoSize = true;
                    //lblCourseLecturer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    //lblCourseLecturer.Location = new Point(10, 170);
                    //lblCourseLecturer.ForeColor = Color.Blue;
                    //// create new lable for course ECTS position bottom right
                    //Label lblCourseECTS = new Label();
                    //lblCourseECTS.Text = "ECTS: " + kolegij.Ects.ToString();
                    //lblCourseECTS.AutoSize = true;
                    //lblCourseECTS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    //lblCourseECTS.Location = new Point(750, 170);

                    //// add labels to panel
                    //pnlNotification.Controls.Add(lblCourseName);
                    //if (isAdmin)
                    //{
                    //    pnlNotification.Controls.Add(btnDeleteCourse);
                    //    pnlNotification.Controls.Add(btnEditCourse);
                    //}
                    //pnlNotification.Controls.Add(lblCourseDescription);
                    //pnlNotification.Controls.Add(lblCourseLecturer);
                    //pnlNotification.Controls.Add(lblCourseECTS);


                    // add panel
                    pnlNotifications.Controls.Add(pnlNotification);

                    //// add empty panel to flLecturers
                    //Panel pnlEmpty = new Panel();
                    //pnlEmpty.Dock = DockStyle.Top;
                    //pnlEmpty.Height = 30;
                    //pnlEmpty.BackColor = Color.FromArgb(235, 235, 235);
                    //pnlNotifications.Controls.Add(pnlEmpty);
                }


            }
            catch (Exception)
            {
                // descrete notification
                MessageBox.Show("Greška prilikom učitavanja obavijesti!", "Pokušajte ponovno.");
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
            // hide pnlAddNotification
            pnlAddNotification.Visible = false;

            // content Notifications
            pnlNotifications.Visible = true;
            lbNotification.Visible = true;
            btnAddNotification.Visible = true;

            // clear panel
            pnlNotifications.Controls.Clear();

            // reload notifications
            LoadNotifications();
        }
    }
}
