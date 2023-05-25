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

            // get notifications from database
            ISet<Obavijest> obavijesti = DataManager.GetObavijestRepository().GetObavijestiFromFile();

            // add notifications to listbox
            obavijesti.ToList().ForEach(o => lbNotifications.Items.Add(o));

        }

        private void btnAddNotification_Click(object sender, EventArgs e)
        {
            // open pnlAddNotification
            pnlAddNotification.Visible = true;
            // hide main content
            lbNotifications.Visible = false;
            lbNotification.Visible = false;
            btnAddNotification.Visible = false;
        }

        private void btnNotificationCancel_Click(object sender, EventArgs e)
        {
            // hide pnlAddNotification
            pnlAddNotification.Visible = false;

            // content Notifications
            lbNotifications.Visible = true;
            lbNotification.Visible = true;
            btnAddNotification.Visible = true;
        }
    }
}
