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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnNotificationCancel = new Button();
            button1 = new Button();
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
            pnlAddNotification.Controls.Add(comboBox2);
            pnlAddNotification.Controls.Add(comboBox1);
            pnlAddNotification.Controls.Add(textBox2);
            pnlAddNotification.Controls.Add(textBox1);
            pnlAddNotification.Controls.Add(btnNotificationCancel);
            pnlAddNotification.Controls.Add(button1);
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(132, 409);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(332, 23);
            comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 334);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(332, 23);
            comboBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 139);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(332, 139);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 23);
            textBox1.TabIndex = 8;
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
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(441, 476);
            button1.Name = "button1";
            button1.Size = new Size(213, 29);
            button1.TabIndex = 6;
            button1.Text = "Potvrdi";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 391);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Kategorija";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 316);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Kolegij";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 121);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Opis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 39);
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
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
