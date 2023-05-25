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

        public Courses(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
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

            try
            {
                // get courses from database
                ISet<Kolegij> kolegiji = DataManager.GetKolegijiRepository().GetKolegijiFromFile();
                // get lecturers from database
                ISet<Predavac> predavaci = DataManager.GetPredavacRepository().GetPredavaciFromFile();

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
                    pnlCourse.Controls.Add(btnDeleteCourse);
                    pnlCourse.Controls.Add(btnEditCourse);
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
            throw new NotImplementedException();
        }

        private void btnDeleteCourse_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            PrepareAddOrUpdateForm();

            // set form title
            lblAddOrUpdate.Text = "Unos kolegija";
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
            if (lblAddOrUpdate.Text == "Edit Kolegija")
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
            string name = tbCourseName.Text;
            string description = tbCourseDescr.Text;
            int ects = Convert.ToInt32(tbECTS.Text);
            Predavac predavac = (Predavac)cbLecturer.SelectedItem;
            int predavacId = predavac.Id;

            // create new course
            Kolegij kolegij = new Kolegij(name, ects, predavacId, description);

            try
            {
                // add course to file
                DataManager.GetKolegijiRepository().AddKolegij(kolegij);
                // update predavac with kolegij id
                DataManager.GetPredavacRepository().UpdatePredavacZaKolegijId(predavacId, kolegij.Id);

                // make descrete notice
                MessageBox.Show("Kolegij uspješno dodan!");              


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

        private void UpdateCourseById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
