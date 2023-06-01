namespace InfoedukaWinForms
{
    partial class Lecturers
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
            pnlAddLecturer = new Panel();
            label6 = new Label();
            cbCoursesSelect = new ComboBox();
            tbPassCreate = new TextBox();
            label4 = new Label();
            tbEmailCreate = new TextBox();
            label5 = new Label();
            tbLastName = new TextBox();
            label1 = new Label();
            tbFirstName = new TextBox();
            btnLecturerCancel = new Button();
            btnLecturerCreate = new Button();
            label3 = new Label();
            lblAddOrUpdate = new Label();
            btnAddLecturer = new Button();
            lbLecturer = new Label();
            pnlLecturers = new Panel();
            pnlAddLecturer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAddLecturer
            // 
            pnlAddLecturer.Controls.Add(label6);
            pnlAddLecturer.Controls.Add(cbCoursesSelect);
            pnlAddLecturer.Controls.Add(tbPassCreate);
            pnlAddLecturer.Controls.Add(label4);
            pnlAddLecturer.Controls.Add(tbEmailCreate);
            pnlAddLecturer.Controls.Add(label5);
            pnlAddLecturer.Controls.Add(tbLastName);
            pnlAddLecturer.Controls.Add(label1);
            pnlAddLecturer.Controls.Add(tbFirstName);
            pnlAddLecturer.Controls.Add(btnLecturerCancel);
            pnlAddLecturer.Controls.Add(btnLecturerCreate);
            pnlAddLecturer.Controls.Add(label3);
            pnlAddLecturer.Controls.Add(lblAddOrUpdate);
            pnlAddLecturer.Location = new Point(151, 65);
            pnlAddLecturer.MaximumSize = new Size(657, 508);
            pnlAddLecturer.MinimumSize = new Size(657, 508);
            pnlAddLecturer.Name = "pnlAddLecturer";
            pnlAddLecturer.Size = new Size(657, 508);
            pnlAddLecturer.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 364);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 16;
            label6.Text = "Kolegij";
            // 
            // cbCoursesSelect
            // 
            cbCoursesSelect.FormattingEnabled = true;
            cbCoursesSelect.Location = new Point(143, 393);
            cbCoursesSelect.Name = "cbCoursesSelect";
            cbCoursesSelect.Size = new Size(332, 23);
            cbCoursesSelect.TabIndex = 15;
            // 
            // tbPassCreate
            // 
            tbPassCreate.Location = new Point(143, 305);
            tbPassCreate.Name = "tbPassCreate";
            tbPassCreate.Size = new Size(332, 23);
            tbPassCreate.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 283);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 13;
            label4.Text = "Šifra";
            // 
            // tbEmailCreate
            // 
            tbEmailCreate.Location = new Point(143, 225);
            tbEmailCreate.Name = "tbEmailCreate";
            tbEmailCreate.Size = new Size(332, 23);
            tbEmailCreate.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 203);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(143, 146);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(332, 23);
            tbLastName.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 124);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 9;
            label1.Text = "Prezime";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(143, 72);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(332, 23);
            tbFirstName.TabIndex = 8;
            // 
            // btnLecturerCancel
            // 
            btnLecturerCancel.BackColor = Color.White;
            btnLecturerCancel.FlatAppearance.BorderColor = Color.SlateGray;
            btnLecturerCancel.FlatStyle = FlatStyle.Flat;
            btnLecturerCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLecturerCancel.ForeColor = Color.Blue;
            btnLecturerCancel.Location = new Point(3, 476);
            btnLecturerCancel.Name = "btnLecturerCancel";
            btnLecturerCancel.Size = new Size(213, 29);
            btnLecturerCancel.TabIndex = 7;
            btnLecturerCancel.Text = "Odustani";
            btnLecturerCancel.UseVisualStyleBackColor = false;
            btnLecturerCancel.Click += btnLecturerCancel_Click;
            // 
            // btnLecturerCreate
            // 
            btnLecturerCreate.BackColor = Color.Blue;
            btnLecturerCreate.FlatAppearance.BorderColor = Color.Blue;
            btnLecturerCreate.FlatStyle = FlatStyle.Flat;
            btnLecturerCreate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLecturerCreate.ForeColor = Color.White;
            btnLecturerCreate.Location = new Point(441, 476);
            btnLecturerCreate.Name = "btnLecturerCreate";
            btnLecturerCreate.Size = new Size(213, 29);
            btnLecturerCreate.TabIndex = 6;
            btnLecturerCreate.Text = "Potvrdi";
            btnLecturerCreate.UseVisualStyleBackColor = false;
            btnLecturerCreate.Click += btnLecturerCreate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 50);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "Ime";
            // 
            // lblAddOrUpdate
            // 
            lblAddOrUpdate.AutoSize = true;
            lblAddOrUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddOrUpdate.Location = new Point(3, 8);
            lblAddOrUpdate.Name = "lblAddOrUpdate";
            lblAddOrUpdate.Size = new Size(132, 21);
            lblAddOrUpdate.TabIndex = 1;
            lblAddOrUpdate.Text = "Unos Predavača";
            // 
            // btnAddLecturer
            // 
            btnAddLecturer.FlatAppearance.BorderColor = Color.Blue;
            btnAddLecturer.FlatStyle = FlatStyle.Flat;
            btnAddLecturer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddLecturer.ForeColor = Color.Blue;
            btnAddLecturer.Location = new Point(737, 65);
            btnAddLecturer.MaximumSize = new Size(209, 29);
            btnAddLecturer.MinimumSize = new Size(209, 29);
            btnAddLecturer.Name = "btnAddLecturer";
            btnAddLecturer.Size = new Size(209, 29);
            btnAddLecturer.TabIndex = 5;
            btnAddLecturer.Text = "+ Dodaj Predavača";
            btnAddLecturer.UseVisualStyleBackColor = true;
            btnAddLecturer.Click += btnAddLecturer_Click;
            // 
            // lbLecturer
            // 
            lbLecturer.AutoSize = true;
            lbLecturer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbLecturer.Location = new Point(58, 65);
            lbLecturer.Name = "lbLecturer";
            lbLecturer.Size = new Size(140, 21);
            lbLecturer.TabIndex = 4;
            lbLecturer.Text = "Prikaz Predavača";
            // 
            // pnlLecturers
            // 
            pnlLecturers.AutoScroll = true;
            pnlLecturers.Location = new Point(114, 99);
            pnlLecturers.Name = "pnlLecturers";
            pnlLecturers.Size = new Size(832, 478);
            pnlLecturers.TabIndex = 8;
            // 
            // Lecturers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            Controls.Add(pnlAddLecturer);
            Controls.Add(btnAddLecturer);
            Controls.Add(lbLecturer);
            Controls.Add(pnlLecturers);
            MaximumSize = new Size(1004, 600);
            MinimumSize = new Size(1004, 600);
            Name = "Lecturers";
            Size = new Size(1004, 600);
            Load += Lecturers_Load;
            pnlAddLecturer.ResumeLayout(false);
            pnlAddLecturer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlAddLecturer;
        private TextBox tbFirstName;
        private Button btnLecturerCancel;
        private Button btnLecturerCreate;
        private Label label3;
        private Label lblAddOrUpdate;
        private Button btnAddLecturer;
        private Label lbLecturer;
        private TextBox tbPassCreate;
        private Label label4;
        private TextBox tbEmailCreate;
        private Label label5;
        private TextBox tbLastName;
        private Label label1;
        private Label label6;
        private ComboBox cbCoursesSelect;
        private Panel pnlLecturers;
    }
}
