using DataLayer;

namespace InfoedukaWinForms
{
    public partial class MainForm : Form
    {
        private bool isAdmin = false;
        private int userId = -1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // when ESC is pressed, close the application
            if (e.KeyChar == (char)27)
            {
                // close the application
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the application
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            StartUpSetings();
        }

        private void StartUpSetings()
        {
            // hide panel pnlMenu
            pnlMenu.Visible = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // check if user is valid
            if (DataManager.IsValidUser(tbEmail.Text, tbPass.Text))
            {
                // show panel pnlMenu
                pnlMenu.Visible = true;
                // hide panel pnlLogIn
                pnlLogInForm.Visible = false;

                // hide btnLecturer
                btnLecturer.Visible = false;

                // set isAdmin
                if (tbEmail.Text == "admin" && tbPass.Text == "admin")
                {
                    isAdmin = true;
                    // show btnLecturer
                    btnLecturer.Visible = true;
                }
                else
                {
                    isAdmin = false;
                    btnLecturer.Visible = false;
                    // get user id
                    Predavac user = DataManager.GetPredavacRepository().GetPredavacByEmailAndPassword(tbEmail.Text, tbPass.Text);
                    userId = user.Id;
                }

            }
            else
            {
                // show error message
                MessageBox.Show("Invalid user!");
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // show panel pnlLogIn
            pnlLogInForm.Visible = true;
            // hide panel pnlMenu
            pnlMenu.Visible = false;
            // clear all user controls
            pnlMain.Controls.Clear();

        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            // open user control Lecturers
            Lecturers lecturers = new Lecturers();
            lecturers.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(lecturers);
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            // open user control Notifications
            Notifications notifications = new Notifications(isAdmin);
            notifications.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(notifications);

        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            // open user control Courses
            Courses courses = new Courses(isAdmin, userId);
            courses.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(courses);
        }
    }
}