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
    public partial class Lecturers : UserControl
    {
        public Lecturers()
        {
            InitializeComponent();
        }

        private void Lecturers_Load(object sender, EventArgs e)
        {
            // load lecturers
            LoadLecturers();
        }

        private void LoadLecturers()
        {
            // hide pnlAddLecturer
            pnlAddLecturer.Visible = false;

            try
            {
                // get lecturers from database
                ISet<Predavac> predavaci = DataManager.GetPredavacRepository().GetPredavaciFromFile();

                // add each leacturer in a separate dynamically created panel
                foreach (Predavac p in predavaci)
                {
                    // create new panel
                    Panel pnlLecturer = new Panel();
                    pnlLecturer.Dock = DockStyle.Top;
                    pnlLecturer.Height = 50;
                    pnlLecturer.BackColor = Color.White;
                    pnlLecturer.BorderStyle = BorderStyle.FixedSingle;
                    pnlLecturer.Name = "pnl" + p.Ime + p.Prezime;
                    // create new label for lecturer name
                    Label lblLecturerName = new Label();
                    lblLecturerName.Text = p.Ime + " " + p.Prezime;
                    lblLecturerName.AutoSize = true;
                    lblLecturerName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    lblLecturerName.Location = new Point(10, 15);
                    // create new button btnDeleteLecturer
                    Button btnDeleteLecturer = new Button();
                    btnDeleteLecturer.Text = "Obriši Predavača";
                    btnDeleteLecturer.AutoSize = true;
                    btnDeleteLecturer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    btnDeleteLecturer.Location = new Point(400, 10);
                    btnDeleteLecturer.Click += new EventHandler(btnDeleteLecturer_Click);
                    // create new button btnEditLecturer
                    Button btnEditLecturer = new Button();
                    btnEditLecturer.Text = "Napravi Izmjenu";
                    btnEditLecturer.AutoSize = true;
                    btnEditLecturer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    btnEditLecturer.Location = new Point(550, 10);
                    btnEditLecturer.Click += new EventHandler(btnEditLecturer_Click);
                    // create new label for lecturer email
                    Label lblLecturerEmail = new Label();
                    lblLecturerEmail.Text = p.Email;
                    lblLecturerEmail.AutoSize = true;
                    lblLecturerEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    lblLecturerEmail.Location = new Point(10, 35);
                    // add labels to panel
                    pnlLecturer.Controls.Add(lblLecturerName);
                    pnlLecturer.Controls.Add(btnDeleteLecturer);
                    pnlLecturer.Controls.Add(btnEditLecturer);
                    pnlLecturer.Controls.Add(lblLecturerEmail);

                    // add panel to flLecturers
                    flLecturers.Controls.Add(pnlLecturer);
                }


            }
            catch (Exception)
            {
                // make descrete notice
                MessageBox.Show("Pogreška pri učitavanju predavača! Pokušajte ponovno.");
            }
        }

        private void btnEditLecturer_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDeleteLecturer_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            // open pnlAddLecturer
            pnlAddLecturer.Visible = true;
            // hide main content
            flLecturers.Visible = false;
            lbLecturer.Visible = false;
            btnAddLecturer.Visible = false;

            try
            {
                // add courses to combobox
                ISet<Kolegij> kolegiji = DataManager.GetKolegijiRepository().GetKolegijiFromFile();
                kolegiji.ToList().ForEach(k => cbCoursesSelect.Items.Add(k));
                // show only name of course
                cbCoursesSelect.DisplayMember = "Naziv";
            }
            catch (Exception)
            {
                // make descrente notice
                MessageBox.Show("Pogreška pri učitavanju kolegija! Pokušajte ponovno.");
            }


        }

        private void btnLecturerCancel_Click(object sender, EventArgs e)
        {
            ReturnToMainPanel();
        }

        private void btnLecturerCreate_Click(object sender, EventArgs e)
        {
            // get lecturer data
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string email = tbEmailCreate.Text;
            string pass = tbPassCreate.Text;
            int crsID = ((Kolegij)cbCoursesSelect.SelectedItem).Id;

            // create int ISet with crsID
            ISet<int> kolegijID = new HashSet<int>
            {
                crsID
            };

            // create lecturer
            Predavac predavac = new Predavac(firstName, lastName, email, pass, kolegijID);

            try
            {
                // add lecturer to database
                DataManager.GetPredavacRepository().AddPredavac(predavac);
                // update kolegij with crsID with the Id of predavac
                DataManager.GetKolegijiRepository().UpdateKolegijZaPredavacId(crsID, predavac.Id);
            }
            catch (Exception)
            {
                // make descrente notice
                MessageBox.Show("Predavač nije dodan! Pokušajte ponovno.");
            }


            ReturnToMainPanel();

            // reload lecturers
            LoadLecturers();

            // prompt success
            MessageBox.Show("Predavač uspješno dodan!");

        }

        private void ReturnToMainPanel()
        {
            // hide pnlAddLecturer
            pnlAddLecturer.Visible = false;

            // show main content
            flLecturers.Visible = true;
            lbLecturer.Visible = true;
            btnAddLecturer.Visible = true;

            // clear input fields
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmailCreate.Text = "";
            tbPassCreate.Text = "";
            cbCoursesSelect.Items.Clear();

            // clear flLecturers
            flLecturers.Controls.Clear();

            // reload lecturers
            LoadLecturers();

        }
    }
}
