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

            // get courses from database
            ISet<Kolegij> kolegiji = DataManager.GetKolegijiRepository().GetKolegijiFromFile();

            // add courses to listbox
            kolegiji.ToList().ForEach(k => lbCourses.Items.Add(k));
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            // open pnlAddCourse
            pnlAddCourse.Visible = true;
            // hide main content
            lbCourses.Visible = false;
            lbCourse.Visible = false;
            btnAddCourse.Visible = false;
        }

        private void btnCourseCancel_Click(object sender, EventArgs e)
        {
            // hide pnlAddCourse
            pnlAddCourse.Visible = false;

            // show main content
            lbCourses.Visible = true;
            lbCourse.Visible = true;
            btnAddCourse.Visible = true;
        }
    }
}
