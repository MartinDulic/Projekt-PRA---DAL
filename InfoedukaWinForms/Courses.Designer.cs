namespace InfoedukaWinForms
{
    partial class Courses
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
            pnlAddCourse = new Panel();
            cbLecturer = new ComboBox();
            label5 = new Label();
            tbECTS = new TextBox();
            label4 = new Label();
            tbCourseDescr = new TextBox();
            label1 = new Label();
            tbCourseName = new TextBox();
            btnCourseCancel = new Button();
            btnCourseCreate = new Button();
            label3 = new Label();
            label2 = new Label();
            lbCourses = new ListBox();
            btnAddCourse = new Button();
            lbCourse = new Label();
            pnlAddCourse.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAddCourse
            // 
            pnlAddCourse.Controls.Add(cbLecturer);
            pnlAddCourse.Controls.Add(label5);
            pnlAddCourse.Controls.Add(tbECTS);
            pnlAddCourse.Controls.Add(label4);
            pnlAddCourse.Controls.Add(tbCourseDescr);
            pnlAddCourse.Controls.Add(label1);
            pnlAddCourse.Controls.Add(tbCourseName);
            pnlAddCourse.Controls.Add(btnCourseCancel);
            pnlAddCourse.Controls.Add(btnCourseCreate);
            pnlAddCourse.Controls.Add(label3);
            pnlAddCourse.Controls.Add(label2);
            pnlAddCourse.Location = new Point(151, 65);
            pnlAddCourse.Name = "pnlAddCourse";
            pnlAddCourse.Size = new Size(657, 508);
            pnlAddCourse.TabIndex = 7;
            // 
            // cbLecturer
            // 
            cbLecturer.FormattingEnabled = true;
            cbLecturer.Location = new Point(154, 361);
            cbLecturer.Name = "cbLecturer";
            cbLecturer.Size = new Size(332, 23);
            cbLecturer.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 333);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 13;
            label5.Text = "Predavač";
            // 
            // tbECTS
            // 
            tbECTS.Location = new Point(154, 249);
            tbECTS.Name = "tbECTS";
            tbECTS.Size = new Size(332, 23);
            tbECTS.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 227);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 11;
            label4.Text = "ECTS";
            // 
            // tbCourseDescr
            // 
            tbCourseDescr.Location = new Point(154, 149);
            tbCourseDescr.Name = "tbCourseDescr";
            tbCourseDescr.Size = new Size(332, 23);
            tbCourseDescr.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 127);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 9;
            label1.Text = "Opis";
            // 
            // tbCourseName
            // 
            tbCourseName.Location = new Point(154, 60);
            tbCourseName.Name = "tbCourseName";
            tbCourseName.Size = new Size(332, 23);
            tbCourseName.TabIndex = 8;
            // 
            // btnCourseCancel
            // 
            btnCourseCancel.BackColor = Color.White;
            btnCourseCancel.FlatAppearance.BorderColor = Color.SlateGray;
            btnCourseCancel.FlatStyle = FlatStyle.Flat;
            btnCourseCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCourseCancel.ForeColor = Color.Blue;
            btnCourseCancel.Location = new Point(3, 476);
            btnCourseCancel.Name = "btnCourseCancel";
            btnCourseCancel.Size = new Size(213, 29);
            btnCourseCancel.TabIndex = 7;
            btnCourseCancel.Text = "Odustani";
            btnCourseCancel.UseVisualStyleBackColor = false;
            btnCourseCancel.Click += btnCourseCancel_Click;
            // 
            // btnCourseCreate
            // 
            btnCourseCreate.BackColor = Color.Blue;
            btnCourseCreate.FlatAppearance.BorderColor = Color.Blue;
            btnCourseCreate.FlatStyle = FlatStyle.Flat;
            btnCourseCreate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCourseCreate.ForeColor = Color.White;
            btnCourseCreate.Location = new Point(441, 476);
            btnCourseCreate.Name = "btnCourseCreate";
            btnCourseCreate.Size = new Size(213, 29);
            btnCourseCreate.TabIndex = 6;
            btnCourseCreate.Text = "Potvrdi";
            btnCourseCreate.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 38);
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
            label2.Size = new Size(116, 21);
            label2.TabIndex = 1;
            label2.Text = "Unos Kolegija";
            // 
            // lbCourses
            // 
            lbCourses.FormattingEnabled = true;
            lbCourses.ItemHeight = 15;
            lbCourses.Location = new Point(63, 104);
            lbCourses.Name = "lbCourses";
            lbCourses.Size = new Size(883, 469);
            lbCourses.TabIndex = 6;
            // 
            // btnAddCourse
            // 
            btnAddCourse.FlatAppearance.BorderColor = Color.Blue;
            btnAddCourse.FlatStyle = FlatStyle.Flat;
            btnAddCourse.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCourse.ForeColor = Color.Blue;
            btnAddCourse.Location = new Point(829, 65);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(117, 29);
            btnAddCourse.TabIndex = 5;
            btnAddCourse.Text = "+ Dodaj Kolegij";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // lbCourse
            // 
            lbCourse.AutoSize = true;
            lbCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCourse.Location = new Point(58, 65);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new Size(69, 21);
            lbCourse.TabIndex = 4;
            lbCourse.Text = "Kolegiji";
            // 
            // Courses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            Controls.Add(pnlAddCourse);
            Controls.Add(lbCourses);
            Controls.Add(btnAddCourse);
            Controls.Add(lbCourse);
            MaximumSize = new Size(1004, 639);
            MinimumSize = new Size(1004, 639);
            Name = "Courses";
            Size = new Size(1004, 639);
            Load += Courses_Load;
            pnlAddCourse.ResumeLayout(false);
            pnlAddCourse.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlAddCourse;
        private TextBox tbCourseName;
        private Button btnCourseCancel;
        private Button btnCourseCreate;
        private Label label3;
        private Label label2;
        private ListBox lbCourses;
        private Button btnAddCourse;
        private Label lbCourse;
        private ComboBox cbLecturer;
        private Label label5;
        private TextBox tbECTS;
        private Label label4;
        private TextBox tbCourseDescr;
        private Label label1;
    }
}
