using DataLayer;

namespace InfoedukaWinForms
{
    public partial class MainForm : Form
    {
        // data manager repositorys
        //IAdminRepository _adminRepository = DataManager.GetAdminRepository();
        //IPredavacRepository _predavacRepository = DataManager.GetPredavacRepository();
        //IKolegijiRepository _kolegijiRepository = DataManager.GetKolegijiRepository();
        //IObavijestRepository _obavijestRepository = DataManager.GetObavijestRepository();

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
            }
            else
            {
                // show error message
                MessageBox.Show("Invalid user!");
            }
        }
    }
}