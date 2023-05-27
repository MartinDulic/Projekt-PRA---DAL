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
    public partial class Courses : UserControl
    {
        private bool isAdmin;
        private int userId = -1;

        public Courses(bool isAdmin, int userId)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.userId = userId;
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            // load courses
            LoadCourses();

            // check if user is admin
            if (isAdmin)
            {
                // show btnAddCourse
                btnAddCourse.Visible = true;
            }
            else
            {
                // hide btnAddCourse
                btnAddCourse.Visible = false;
            }
        }

        private void LoadCourses()
        {
            // hide pnlAddCourse
            pnlAddCourse.Visible = false;

            // clear all controls from pnlCourses
            pnlCourses.Controls.Clear();

            try
            {
                ISet<Kolegij> kolegiji = new HashSet<Kolegij>();
                ISet<Predavac> predavaci = new HashSet<Predavac>();
                if (isAdmin)
                {
                    // get all courses from database
                    kolegiji = DataManager.GetKolegijiRepository().GetKolegijiFromFile();
                    // get all lecturers from database
                    predavaci = DataManager.GetPredavacRepository().GetPredavaciFromFile();
                }
                else
                {
                    // get courses from database by user id
                    kolegiji = DataManager.GetKolegijiRepository().GetKolegijiByPredavacId(userId);
                    // get lecturer from database by user id
                    Predavac p = DataManager.GetPredavacRepository().GetPredavacById(userId);
                    predavaci.Add(p);
                }

                // add each course in a separate dynamically created panel
                foreach (Kolegij kolegij in kolegiji)
                {
                    // create new panel
                    Panel pnlCourse = new Panel();
                    pnlCourse.Dock = DockStyle.Top;
                    pnlCourse.Height = 200;
                    pnlCourse.BackColor = Color.White;
                    pnlCourse.Name = "pnl" + kolegij.Naziv.Trim();
                    pnlCourse.Tag = kolegij.Id;
                    //create new label for course name position top left
                    Label lblCourseName = new Label();
                    lblCourseName.Text = kolegij.Naziv;
                    lblCourseName.AutoSize = true;
                    lblCourseName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
                    lblCourseName.Location = new Point(10, 15);
                    // create new button btnDeleteCourse
                    Button btnDeleteCourse = new Button();
                    btnDeleteCourse.Text = "Obriši Kolegij";
                    btnDeleteCourse.AutoSize = true;
                    btnDeleteCourse.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    btnDeleteCourse.FlatAppearance.BorderSize = 1;
                    btnDeleteCourse.FlatAppearance.BorderColor = Color.Red;
                    btnDeleteCourse.FlatStyle = FlatStyle.Flat;
                    btnDeleteCourse.ForeColor = Color.Red;
                    btnDeleteCourse.Location = new Point(580, 10);
                    btnDeleteCourse.Click += new EventHandler(btnDeleteCourse_Click);
                    // create new button btnEditCourse
                    Button btnEditCourse = new Button();
                    btnEditCourse.Text = "Napravi Izmjenu";
                    btnEditCourse.AutoSize = true;
                    btnEditCourse.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    btnEditCourse.FlatAppearance.BorderSize = 1;
                    btnEditCourse.FlatAppearance.BorderColor = Color.Blue;
                    btnEditCourse.FlatStyle = FlatStyle.Flat;
                    btnEditCourse.ForeColor = Color.Blue;
                    btnEditCourse.Location = new Point(700, 10);
                    btnEditCourse.Click += new EventHandler(btnEditCourse_Click);
                    // create new lable for course description (opsi) position middle left
                    Label lblCourseDescription = new Label();
                    lblCourseDescription.Text = kolegij.Opis;
                    lblCourseDescription.AutoSize = true;
                    lblCourseDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    lblCourseDescription.Location = new Point(10, 100);
                    // create new label for course lecturer position bottom left
                    Label lblCourseLecturer = new Label();
                    // find lecurer by id from course and set name and surname
                    foreach (Predavac predavac in predavaci)
                    {
                        if (predavac.Id == kolegij.PredavacId)
                        {
                            lblCourseLecturer.Text = predavac.Ime + " " + predavac.Prezime;
                            break;
                        }
                        else
                        {
                            lblCourseLecturer.Text = " ";
                        }
                    }
                    lblCourseLecturer.AutoSize = true;
                    lblCourseLecturer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    lblCourseLecturer.Location = new Point(10, 170);
                    lblCourseLecturer.ForeColor = Color.Blue;
                    // create new lable for course ECTS position bottom right
                    Label lblCourseECTS = new Label();
                    lblCourseECTS.Text = "ECTS: " + kolegij.Ects.ToString();
                    lblCourseECTS.AutoSize = true;
                    lblCourseECTS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    lblCourseECTS.Location = new Point(750, 170);

                    // add labels to panel
                    pnlCourse.Controls.Add(lblCourseName);
                    if (isAdmin)
                    {
                        pnlCourse.Controls.Add(btnDeleteCourse);
                        pnlCourse.Controls.Add(btnEditCourse); 
                    }
                    pnlCourse.Controls.Add(lblCourseDescription);
                    pnlCourse.Controls.Add(lblCourseLecturer);
                    pnlCourse.Controls.Add(lblCourseECTS);


                    // add panel to flLecturers
                    pnlCourses.Controls.Add(pnlCourse);

                    // add empty panel to flLecturers
                    Panel pnlEmpty = new Panel();
                    pnlEmpty.Dock = DockStyle.Top;
                    pnlEmpty.Height = 30;
                    pnlEmpty.BackColor = Color.FromArgb(235, 235, 235);
                    pnlCourses.Controls.Add(pnlEmpty);

                }
            }
            catch (Exception)
            {
                // make descrete notice
                MessageBox.Show("Pogreška pri učitavanju kolegija! Pokušajte ponovno.");
            }


        }

        private void btnEditCourse_Click(object? sender, EventArgs e)
        {
            PrepareAddOrUpdateForm();

            // change label text
            lblAddOrUpdateCrs.Text = "Edit Kolegija";

            try
            {
                // get selected kolegij
                int id = Convert.ToInt32(((Button)sender).Parent.Tag);
                Kolegij kolegij = DataManager.GetKolegijiRepository().GetKolegijById(id);
                // fill in form with data
                tbCourseName.Text = kolegij.Naziv;
                tbCourseDescr.Text = kolegij.Opis;
                tbECTS.Text = kolegij.Ects.ToString();

                // set button tag to kolegij id
                btnCourseCreate.Tag = kolegij.Id;
            }
            catch (Exception)
            {
                // make descrete notice
                MessageBox.Show("Pogreška pri učitavanju kolegija! Pokušajte ponovno.");
            }
        }

        private void btnDeleteCourse_Click(object? sender, EventArgs e)
        {
            // prompt user to confirm delete
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite obrisati kolegij?", "Potvrda brisanja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            try
            {
                // get selected kolegij
                int id = (int)((Button)sender).Parent.Tag;
                Kolegij kolegij = DataManager.GetKolegijiRepository().GetKolegijById(id);
                // delete kolegij
                DataManager.GetKolegijiRepository().DeleteKolegij(kolegij);
                // refresh form
                LoadCourses();
            }
            catch (Exception)
            {
                // make descrete notice
                MessageBox.Show("Pogreška pri brisanju kolegija! Pokušajte ponovno.");
            }

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            PrepareAddOrUpdateForm();

            // set form title
            lblAddOrUpdateCrs.Text = "Unos Kolegija";
        }

        private void PrepareAddOrUpdateForm()
        {
            // open pnlAddCourse
            pnlAddCourse.Visible = true;
            // hide main content
            pnlCourses.Visible = false;
            lbCourse.Visible = false;
            btnAddCourse.Visible = false;

            try
            {
                // add lecturers to cbLecturer
                ISet<Predavac> predavaci = DataManager.GetPredavacRepository().GetPredavaciFromFile();
                foreach (Predavac predavac in predavaci)
                {
                    cbLecturer.Items.Add(predavac);
                    // display surname
                    cbLecturer.DisplayMember = "Prezime";
                }
            }
            catch (Exception)
            {
                // make descrete notice
                MessageBox.Show("Pogreška pri učitavanju predavača! Pokušajte ponovno.");
            }
        }

        private void btnCourseCancel_Click(object sender, EventArgs e)
        {
            ReturnToMainPanel();
        }

        private void ReturnToMainPanel()
        {
            // hide pnlAddCourse
            pnlAddCourse.Visible = false;

            // show main content
            pnlCourses.Visible = true;
            lbCourse.Visible = true;
            btnAddCourse.Visible = true;

            // clear all fields
            tbCourseName.Text = "";
            tbCourseDescr.Text = "";
            tbECTS.Text = "";
            cbLecturer.Items.Clear();

            //clear panel
            pnlCourses.Controls.Clear();

            // reload courses
            LoadCourses();
        }

        private void btnCourseCreate_Click(object sender, EventArgs e)
        {
            // if sender is edit button
            if (lblAddOrUpdateCrs.Text == "Edit Kolegija")
            {
                // get selected lecturer tag id in parent panel
                int id = Convert.ToInt32(((Button)sender).Tag);
                UpdateCourseById(id);
            }
            else
            {
                // add new course
                AddCourse();
            }

        }

        private void AddCourse()
        {
            // get course data
            string name, description;
            int ects, predavacId;
            GetCourseDataFromForm(out name, out description, out ects, out predavacId);

            // create new course
            Kolegij kolegij = new Kolegij(name, ects, predavacId, description);

            try
            {
                // add course to file
                DataManager.GetKolegijiRepository().AddKolegij(kolegij);
                // update predavac with kolegij id
                DataManager.GetPredavacRepository().UpdatePredavacZaKolegijId(predavacId, kolegij.Id);

            }
            catch (Exception)
            {
                // make descrete notice
                MessageBox.Show("Pogreška pri dodavanju kolegija! Pokušajte ponovno.");
            }

            // return to main panel
            ReturnToMainPanel();

            // reload courses
            LoadCourses();
        }

        private void GetCourseDataFromForm(out string name, out string description, out int ects, out int predavacId)
        {
            name = tbCourseName.Text;
            description = tbCourseDescr.Text;
            ects = Convert.ToInt32(tbECTS.Text);
            Predavac predavac = (Predavac)cbLecturer.SelectedItem;
            predavacId = predavac.Id;
        }

        private void UpdateCourseById(int id)
        {
            // get course data
            string name, description;
            int ects, predavacId;
            GetCourseDataFromForm(out name, out description, out ects, out predavacId);

            // get course by id and update it
            Kolegij kolegij = DataManager.GetKolegijiRepository().GetKolegijById(id);
            // update course
            kolegij.Naziv = name;
            kolegij.Opis = description;
            kolegij.Ects = ects;
            kolegij.PredavacId = predavacId;
            // update course in file
            DataManager.GetKolegijiRepository().UpdateKolegij(kolegij);

            // update predavac with kolegij id
            DataManager.GetPredavacRepository().UpdatePredavacZaKolegijId(predavacId, kolegij.Id);

            // return to main panel
            ReturnToMainPanel();

            // reload courses
            LoadCourses();
        }
    }
}
