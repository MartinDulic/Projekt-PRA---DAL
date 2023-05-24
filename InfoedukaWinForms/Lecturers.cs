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

            // get lecturers from database
            ISet<Predavac> predavaci = DataManager.GetPredavacRepository().GetPredavaciFromFile();

            // add lecturers to listbox
            predavaci.ToList().ForEach(p => lbLecturers.Items.Add(p));
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            // open pnlAddLecturer
            pnlAddLecturer.Visible = true;
            // hide main content
            lbLecturers.Visible = false;
            lbLecturer.Visible = false;
            btnAddLecturer.Visible = false;
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

            // get courses from database
            ISet<int> kolegijID  = new HashSet<int>();
            kolegijID.Add(1);

            // create lecturer
            Predavac predavac = new Predavac(firstName, lastName, email, pass, kolegijID);

            // add lecturer to database
            DataManager.GetPredavacRepository().AddPredavac(predavac);

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
            lbLecturers.Visible = true;
            lbLecturer.Visible = true;
            btnAddLecturer.Visible = true;
        }
    }
}
