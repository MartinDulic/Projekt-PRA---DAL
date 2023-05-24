namespace InfoedukaWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label6 = new Label();
            btnLogIn = new Button();
            label5 = new Label();
            label4 = new Label();
            btnExitWindow = new Button();
            pnlLogInForm = new Panel();
            tbPass = new TextBox();
            tbEmail = new TextBox();
            btnLogOut = new Button();
            btnCourse = new Button();
            btnNotification = new Button();
            btnLecturer = new Button();
            lblLogo1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnExitMenu = new Button();
            pnlMenu = new Panel();
            pnlMain = new Panel();
            pnlLogInForm.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.Image = Properties.Resources.logoBot;
            label1.Location = new Point(-8, 709);
            label1.MaximumSize = new Size(855, 44);
            label1.MinimumSize = new Size(855, 44);
            label1.Name = "label1";
            label1.Size = new Size(855, 44);
            label1.TabIndex = 2;
            label1.Text = "\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(235, 235, 235);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(133, 440);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 6;
            label6.Text = "Veleučilište Algebra";
            // 
            // btnLogIn
            // 
            btnLogIn.BackgroundImage = Properties.Resources.logIn;
            btnLogIn.FlatAppearance.BorderColor = Color.White;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.ForeColor = SystemColors.ControlLightLight;
            btnLogIn.Location = new Point(37, 320);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(290, 40);
            btnLogIn.TabIndex = 6;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 215);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 5;
            label5.Text = "Sifra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 153);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // btnExitWindow
            // 
            btnExitWindow.BackColor = Color.DarkRed;
            btnExitWindow.FlatStyle = FlatStyle.Flat;
            btnExitWindow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExitWindow.ForeColor = Color.White;
            btnExitWindow.Location = new Point(322, 10);
            btnExitWindow.Margin = new Padding(0);
            btnExitWindow.Name = "btnExitWindow";
            btnExitWindow.Size = new Size(32, 32);
            btnExitWindow.TabIndex = 8;
            btnExitWindow.Text = "X";
            btnExitWindow.UseVisualStyleBackColor = false;
            btnExitWindow.Click += btnExit_Click;
            // 
            // pnlLogInForm
            // 
            pnlLogInForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLogInForm.BackColor = SystemColors.ControlLightLight;
            pnlLogInForm.BackgroundImage = Properties.Resources.logInForm;
            pnlLogInForm.Controls.Add(tbPass);
            pnlLogInForm.Controls.Add(tbEmail);
            pnlLogInForm.Controls.Add(btnExitWindow);
            pnlLogInForm.Controls.Add(label4);
            pnlLogInForm.Controls.Add(label5);
            pnlLogInForm.Controls.Add(btnLogIn);
            pnlLogInForm.Controls.Add(label6);
            pnlLogInForm.Location = new Point(320, 178);
            pnlLogInForm.Name = "pnlLogInForm";
            pnlLogInForm.Size = new Size(364, 461);
            pnlLogInForm.TabIndex = 3;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(37, 238);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(290, 23);
            tbPass.TabIndex = 10;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(37, 176);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(290, 23);
            tbEmail.TabIndex = 9;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImage = Properties.Resources.logOut;
            btnLogOut.BackgroundImageLayout = ImageLayout.Center;
            btnLogOut.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatAppearance.CheckedBackColor = Color.FromArgb(64, 64, 64);
            btnLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(859, 11);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(2);
            btnLogOut.Size = new Size(122, 42);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Odjava";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnCourse
            // 
            btnCourse.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnCourse.FlatAppearance.BorderSize = 0;
            btnCourse.FlatAppearance.CheckedBackColor = Color.FromArgb(64, 64, 64);
            btnCourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            btnCourse.FlatStyle = FlatStyle.Flat;
            btnCourse.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCourse.ForeColor = Color.White;
            btnCourse.Location = new Point(693, 13);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(97, 36);
            btnCourse.TabIndex = 3;
            btnCourse.Text = "Kolegiji";
            btnCourse.UseVisualStyleBackColor = true;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnNotification
            // 
            btnNotification.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnNotification.FlatAppearance.BorderSize = 0;
            btnNotification.FlatAppearance.CheckedBackColor = Color.FromArgb(64, 64, 64);
            btnNotification.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            btnNotification.FlatStyle = FlatStyle.Flat;
            btnNotification.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNotification.ForeColor = Color.White;
            btnNotification.Location = new Point(540, 15);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(103, 35);
            btnNotification.TabIndex = 4;
            btnNotification.Text = "Obavijesti";
            btnNotification.UseVisualStyleBackColor = true;
            btnNotification.Click += btnNotification_Click;
            // 
            // btnLecturer
            // 
            btnLecturer.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnLecturer.FlatAppearance.BorderSize = 0;
            btnLecturer.FlatAppearance.CheckedBackColor = Color.FromArgb(64, 64, 64);
            btnLecturer.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 64, 0);
            btnLecturer.FlatStyle = FlatStyle.Flat;
            btnLecturer.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLecturer.ForeColor = Color.White;
            btnLecturer.Location = new Point(388, 15);
            btnLecturer.Name = "btnLecturer";
            btnLecturer.Size = new Size(88, 35);
            btnLecturer.TabIndex = 5;
            btnLecturer.Text = "Predavači";
            btnLecturer.UseVisualStyleBackColor = true;
            btnLecturer.Click += btnLecturer_Click;
            // 
            // lblLogo1
            // 
            lblLogo1.Image = Properties.Resources.logo32;
            lblLogo1.Location = new Point(8, 0);
            lblLogo1.Name = "lblLogo1";
            lblLogo1.Size = new Size(94, 64);
            lblLogo1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(79, 13);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "ALGEBRA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(79, 28);
            label3.Name = "label3";
            label3.Size = new Size(39, 22);
            label3.TabIndex = 6;
            label3.Text = "VISOKO\r\nUČILIŠTE";
            // 
            // btnExitMenu
            // 
            btnExitMenu.BackColor = Color.DarkRed;
            btnExitMenu.FlatStyle = FlatStyle.Flat;
            btnExitMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExitMenu.ForeColor = Color.White;
            btnExitMenu.Location = new Point(984, 0);
            btnExitMenu.Margin = new Padding(0);
            btnExitMenu.Name = "btnExitMenu";
            btnExitMenu.Size = new Size(32, 32);
            btnExitMenu.TabIndex = 7;
            btnExitMenu.Text = "X";
            btnExitMenu.UseVisualStyleBackColor = false;
            btnExitMenu.Click += btnExit_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlMenu.BackColor = Color.FromArgb(21, 21, 21);
            pnlMenu.BackgroundImageLayout = ImageLayout.Center;
            pnlMenu.Controls.Add(btnExitMenu);
            pnlMenu.Controls.Add(label3);
            pnlMenu.Controls.Add(label2);
            pnlMenu.Controls.Add(lblLogo1);
            pnlMenu.Controls.Add(btnLecturer);
            pnlMenu.Controls.Add(btnNotification);
            pnlMenu.Controls.Add(btnCourse);
            pnlMenu.Controls.Add(btnLogOut);
            pnlMenu.Location = new Point(-8, 0);
            pnlMenu.Margin = new Padding(0);
            pnlMenu.MaximumSize = new Size(1023, 64);
            pnlMenu.MinimumSize = new Size(1023, 64);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1023, 64);
            pnlMenu.TabIndex = 1;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(235, 235, 235);
            pnlMain.Location = new Point(0, 67);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1004, 639);
            pnlMain.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            ClientSize = new Size(1008, 752);
            ControlBox = false;
            Controls.Add(pnlLogInForm);
            Controls.Add(label1);
            Controls.Add(pnlMenu);
            Controls.Add(pnlMain);
            MaximumSize = new Size(1024, 768);
            MinimumSize = new Size(1024, 768);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            KeyPress += MainForm_KeyPress;
            pnlLogInForm.ResumeLayout(false);
            pnlLogInForm.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label6;
        private Button btnLogIn;
        private Label label5;
        private Label label4;
        private Button btnExitWindow;
        private Panel pnlLogInForm;
        private Button btnLogOut;
        private Button btnCourse;
        private Button btnNotification;
        private Button btnLecturer;
        private Label lblLogo1;
        private Label label2;
        private Label label3;
        private Button btnExitMenu;
        private Panel pnlMenu;
        private TextBox tbPass;
        private TextBox tbEmail;
        private Panel pnlMain;
    }
}