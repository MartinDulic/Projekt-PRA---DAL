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

            // clear flLecturers
            pnlLecturers.Controls.Clear();

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
                    pnlLecturer.Name = "pnl" + p.Ime + p.Prezime;
                    pnlLecturer.Tag = p.Id;
                    // create new label for lecturer name
                    Label lblLecturerName = new Label();
                    lblLecturerName.Text = p.Ime + " " + p.Prezime;
                    lblLecturerName.AutoSize = true;
                    lblLecturerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
                    lblLecturerName.Location = new Point(10, 15);
                    // create new button btnDeleteLecturer
                    Button btnDeleteLecturer = new Button();
                    btnDeleteLecturer.Text = "Obriši Predavača";
                    btnDeleteLecturer.AutoSize = true;
                    btnDeleteLecturer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    btnDeleteLecturer.FlatAppearance.BorderSize = 1;
                    btnDeleteLecturer.FlatAppearance.BorderColor = Color.Red;
                    btnDeleteLecturer.FlatStyle = FlatStyle.Flat;
                    btnDeleteLecturer.ForeColor = Color.Red;
                    btnDeleteLecturer.Location = new Point(400, 10);
                    btnDeleteLecturer.Click += new EventHandler(btnDeleteLecturer_Click);
                    // create new button btnEditLecturer
                    Button btnEditLecturer = new Button();
                    btnEditLecturer.Text = "Napravi Izmjenu";
                    btnEditLecturer.AutoSize = true;
                    btnEditLecturer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    btnEditLecturer.FlatAppearance.BorderSize = 1;
                    btnEditLecturer.FlatAppearance.BorderColor = Color.Blue;
                    btnEditLecturer.FlatStyle = FlatStyle.Flat;
                    btnEditLecturer.ForeColor = Color.Blue;
                    btnEditLecturer.Location = new Point(550, 10);
                    btnEditLecturer.Click += new EventHandler(btnEditLecturer_Click);
                    // create new label for lecturer email
                    Label lblLecturerEmail = new Label();
                    lblLecturerEmail.Text = p.Email;
                    lblLecturerEmail.AutoSize = true;
                    lblLecturerEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
                    lblLecturerEmail.Location = new Point(750, 10);
                    // add labels to panel
                    pnlLecturer.Controls.Add(lblLecturerName);
                    pnlLecturer.Controls.Add(btnDeleteLecturer);
                    pnlLecturer.Controls.Add(btnEditLecturer);
                    pnlLecturer.Controls.Add(lblLecturerEmail);

                    // add panel to flLecturers
                    pnlLecturers.Controls.Add(pnlLecturer);

                    // add empty panel to flLecturers
                    Panel pnlEmpty = new Panel();
                    pnlEmpty.Dock = DockStyle.Top;
                    pnlEmpty.Height = 30;
                    pnlEmpty.BackColor = Color.FromArgb(235, 235, 235);
                    pnlLecturers.Controls.Add(pnlEmpty);
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
            PrepareAddOrUpdateForm();

            //change lblAddOrUpdate
            lblAddOrUpdate.Text = "Edit predavača";

            // fill in form with data
            try
            {
                // get selected lecturer
                int id = Convert.ToInt32(((Button)sender).Parent.Tag);
                Predavac selectedPredavac = DataManager.GetPredavacRepository().GetPredavacById(id);
                // fill in form with data
                tbFirstName.Text = selectedPredavac.Ime;
                tbLastName.Text = selectedPredavac.Prezime;
                tbEmailCreate.Text = selectedPredavac.Email;
                tbPassCreate.Text = selectedPredavac.Lozinka;

                // set tag of btnLecturerCreate to id of selected lecturer
                btnLecturerCreate.Tag = selectedPredavac.Id;
            }
            catch (Exception)
            {
                // make descrete notice
                MessageBox.Show("Pogreška pri učitavanju predavača! Pokušajte ponovno.");
            }

        }

        private void btnDeleteLecturer_Click(object? sender, EventArgs e)
        {
            // prompt user to confirm deletion
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite obrisati predavača?", "Potvrda brisanja", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // delete lecturer from database and refresh form
            try
            {
                // get selected lecturer
                int id = Convert.ToInt32(((Button)sender).Parent.Tag);
                Predavac selectedPredavac = DataManager.GetPredavacRepository().GetPredavacById(id);
                // delete lecturer from database
                DataManager.GetPredavacRepository().DeletePredavac(selectedPredavac);
                // refresh form
                LoadLecturers();
            }
            catch (Exception)
            {
                // make descrete notice
                MessageBox.Show("Pogreška pri brisanju predavača! Pokušajte ponovno.");
            }
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            PrepareAddOrUpdateForm();

            //change lblAddOrUpdate
            lblAddOrUpdate.Text = "Unos Predavača";

        }

        private void PrepareAddOrUpdateForm()
        {
            // open pnlAddLecturer
            pnlAddLecturer.Visible = true;
            // hide main content
            pnlLecturers.Visible = false;
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
            // if sender is edit button
            if (lblAddOrUpdate.Text == "Edit predavača")
            {
                // get selected lecturer tag id in parent panel
                int id = Convert.ToInt32(((Button)sender).Tag);
                UpdateLecturerById(id);
            }
            else
            {
                // add new lecturer 
                AddLecturer();
            }

        }

        private void UpdateLecturerById(int id)
        {
            // get lecturer data
            string firstName, lastName, email, pass;
            int crsID;
            GetLecturerDataFromForm(out firstName, out lastName, out email, out pass, out crsID);

            // get lecturer from database and update it
            Predavac predavac = DataManager.GetPredavacRepository().GetPredavacById(id);
            predavac.Ime = firstName;
            predavac.Prezime = lastName;
            predavac.Email = email;
            predavac.Lozinka = pass;

            // update lecturer in database
            DataManager.GetPredavacRepository().UpdatePredavac(predavac);

            // update kolegij with crsID with the Id of predavac
            DataManager.GetKolegijiRepository().UpdateKolegijZaPredavacId(crsID, predavac.Id);


            ReturnToMainPanel();

            // reload lecturers
            LoadLecturers();

        }

        private void AddLecturer()
        {
            // get lecturer data
            string firstName, lastName, email, pass;
            int crsID;
            GetLecturerDataFromForm(out firstName, out lastName, out email, out pass, out crsID);

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
        }

        private void GetLecturerDataFromForm(out string firstName, out string lastName, out string email, out string pass, out int crsID)
        {
            firstName = tbFirstName.Text;
            lastName = tbLastName.Text;
            email = tbEmailCreate.Text;
            pass = tbPassCreate.Text;
            crsID = ((Kolegij)cbCoursesSelect.SelectedItem).Id;
        }

        private void ReturnToMainPanel()
        {
            // hide pnlAddLecturer
            pnlAddLecturer.Visible = false;

            // show main content
            pnlLecturers.Visible = true;
            lbLecturer.Visible = true;
            btnAddLecturer.Visible = true;

            // clear input fields
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmailCreate.Text = "";
            tbPassCreate.Text = "";
            cbCoursesSelect.Items.Clear();

            // clear flLecturers
            pnlLecturers.Controls.Clear();

            // reload lecturers
            LoadLecturers();

        }
    }
}
