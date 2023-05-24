namespace InfoedukaWinForms
{
    partial class Notifications
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbNotification = new Label();
            btnAddNotification = new Button();
            lbNotifications = new ListBox();
            pnlAddNotification = new Panel();
            cbCategory = new ComboBox();
            cbCourse = new ComboBox();
            tbDescription = new TextBox();
            tbHeading = new TextBox();
            btnNotificationCancel = new Button();
            btnNotificationCreate = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlAddNotification.SuspendLayout();
            SuspendLayout();
            // 
            // lbNotification
            // 
            lbNotification.AutoSize = true;
            lbNotification.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNotification.Location = new Point(59, 65);
            lbNotification.Name = "lbNotification";
            lbNotification.Size = new Size(87, 21);
            lbNotification.TabIndex = 0;
            lbNotification.Text = "Obavijesti";
            // 
            // btnAddNotification
            // 
            btnAddNotification.FlatAppearance.BorderColor = Color.Blue;
            btnAddNotification.FlatStyle = FlatStyle.Flat;
            btnAddNotification.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNotification.ForeColor = Color.Blue;
            btnAddNotification.Location = new Point(815, 65);
            btnAddNotification.Name = "btnAddNotification";
            btnAddNotification.Size = new Size(132, 29);
            btnAddNotification.TabIndex = 1;
            btnAddNotification.Text = "+ Dodaj Obavijest";
            btnAddNotification.UseVisualStyleBackColor = true;
            btnAddNotification.Click += btnAddNotification_Click;
            // 
            // lbNotifications
            // 
            lbNotifications.FormattingEnabled = true;
            lbNotifications.ItemHeight = 15;
            lbNotifications.Location = new Point(64, 104);
            lbNotifications.Name = "lbNotifications";
            lbNotifications.Size = new Size(883, 469);
            lbNotifications.TabIndex = 2;
            // 
            // pnlAddNotification
            // 
            pnlAddNotification.Controls.Add(cbCategory);
            pnlAddNotification.Controls.Add(cbCourse);
            pnlAddNotification.Controls.Add(tbDescription);
            pnlAddNotification.Controls.Add(tbHeading);
            pnlAddNotification.Controls.Add(btnNotificationCancel);
            pnlAddNotification.Controls.Add(btnNotificationCreate);
            pnlAddNotification.Controls.Add(label6);
            pnlAddNotification.Controls.Add(label5);
            pnlAddNotification.Controls.Add(label4);
            pnlAddNotification.Controls.Add(label3);
            pnlAddNotification.Controls.Add(label2);
            pnlAddNotification.Location = new Point(152, 65);
            pnlAddNotification.Name = "pnlAddNotification";
            pnlAddNotification.Size = new Size(657, 508);
            pnlAddNotification.TabIndex = 3;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(153, 409);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(332, 23);
            cbCategory.TabIndex = 11;
            // 
            // cbCourse
            // 
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(153, 334);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(332, 23);
            cbCourse.TabIndex = 10;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(153, 139);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(332, 139);
            tbDescription.TabIndex = 9;
            // 
            // tbHeading
            // 
            tbHeading.Location = new Point(153, 61);
            tbHeading.Name = "tbHeading";
            tbHeading.Size = new Size(332, 23);
            tbHeading.TabIndex = 8;
            // 
            // btnNotificationCancel
            // 
            btnNotificationCancel.BackColor = Color.White;
            btnNotificationCancel.FlatAppearance.BorderColor = Color.SlateGray;
            btnNotificationCancel.FlatStyle = FlatStyle.Flat;
            btnNotificationCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNotificationCancel.ForeColor = Color.Blue;
            btnNotificationCancel.Location = new Point(3, 476);
            btnNotificationCancel.Name = "btnNotificationCancel";
            btnNotificationCancel.Size = new Size(213, 29);
            btnNotificationCancel.TabIndex = 7;
            btnNotificationCancel.Text = "Odustani";
            btnNotificationCancel.UseVisualStyleBackColor = false;
            btnNotificationCancel.Click += btnNotificationCancel_Click;
            // 
            // btnNotificationCreate
            // 
            btnNotificationCreate.BackColor = Color.Blue;
            btnNotificationCreate.FlatAppearance.BorderColor = Color.Blue;
            btnNotificationCreate.FlatStyle = FlatStyle.Flat;
            btnNotificationCreate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNotificationCreate.ForeColor = Color.White;
            btnNotificationCreate.Location = new Point(441, 476);
            btnNotificationCreate.Name = "btnNotificationCreate";
            btnNotificationCreate.Size = new Size(213, 29);
            btnNotificationCreate.TabIndex = 6;
            btnNotificationCreate.Text = "Potvrdi";
            btnNotificationCreate.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 391);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Kategorija";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 316);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Kolegij";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 121);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Opis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 39);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Naziv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 1;
            label2.Text = "Unos Obavijesti";
            // 
            // Notifications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            Controls.Add(pnlAddNotification);
            Controls.Add(lbNotifications);
            Controls.Add(btnAddNotification);
            Controls.Add(lbNotification);
            MaximumSize = new Size(1004, 639);
            MinimumSize = new Size(1004, 639);
            Name = "Notifications";
            Size = new Size(1004, 639);
            Load += Notifications_Load;
            pnlAddNotification.ResumeLayout(false);
            pnlAddNotification.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNotification;
        private Button btnAddNotification;
        private ListBox lbNotifications;
        private Panel pnlAddNotification;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnNotificationCancel;
        private Button btnNotificationCreate;
        private ComboBox cbCategory;
        private ComboBox cbCourse;
        private TextBox tbDescription;
        private TextBox tbHeading;
    }
}
