namespace Ass2SRP
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_logged = new System.Windows.Forms.Label();
            this.dgv_stCourse = new System.Windows.Forms.DataGridView();
            this.cr_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cr_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_enrolment = new System.Windows.Forms.Button();
            this.cB_courses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cB_semester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stCourse)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_logged);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Enrolment";
            // 
            // lbl_logged
            // 
            this.lbl_logged.AutoSize = true;
            this.lbl_logged.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logged.ForeColor = System.Drawing.Color.White;
            this.lbl_logged.Location = new System.Drawing.Point(24, 31);
            this.lbl_logged.Name = "lbl_logged";
            this.lbl_logged.Size = new System.Drawing.Size(79, 25);
            this.lbl_logged.TabIndex = 0;
            this.lbl_logged.Text = "Names";
            // 
            // dgv_stCourse
            // 
            this.dgv_stCourse.AllowUserToAddRows = false;
            this.dgv_stCourse.AllowUserToDeleteRows = false;
            this.dgv_stCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_stCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cr_name,
            this.cr_semester});
            this.dgv_stCourse.Location = new System.Drawing.Point(365, 133);
            this.dgv_stCourse.Name = "dgv_stCourse";
            this.dgv_stCourse.ReadOnly = true;
            this.dgv_stCourse.RowTemplate.Height = 28;
            this.dgv_stCourse.Size = new System.Drawing.Size(719, 527);
            this.dgv_stCourse.TabIndex = 2;
            // 
            // cr_name
            // 
            this.cr_name.DataPropertyName = "cr_name";
            this.cr_name.HeaderText = "Course Name";
            this.cr_name.Name = "cr_name";
            this.cr_name.ReadOnly = true;
            // 
            // cr_semester
            // 
            this.cr_semester.DataPropertyName = "cr_semester";
            this.cr_semester.HeaderText = "Semester";
            this.cr_semester.Name = "cr_semester";
            this.cr_semester.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btn_enrolment);
            this.groupBox1.Controls.Add(this.cB_courses);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cB_semester);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 527);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Enrolment";
            // 
            // btn_enrolment
            // 
            this.btn_enrolment.Location = new System.Drawing.Point(44, 336);
            this.btn_enrolment.Name = "btn_enrolment";
            this.btn_enrolment.Size = new System.Drawing.Size(199, 57);
            this.btn_enrolment.TabIndex = 2;
            this.btn_enrolment.Text = "Submit";
            this.btn_enrolment.UseVisualStyleBackColor = true;
            this.btn_enrolment.Click += new System.EventHandler(this.btn_enrolment_Click);
            // 
            // cB_courses
            // 
            this.cB_courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_courses.FormattingEnabled = true;
            this.cB_courses.Location = new System.Drawing.Point(34, 250);
            this.cB_courses.Name = "cB_courses";
            this.cB_courses.Size = new System.Drawing.Size(232, 40);
            this.cB_courses.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Courses:";
            // 
            // cB_semester
            // 
            this.cB_semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_semester.FormattingEnabled = true;
            this.cB_semester.Items.AddRange(new object[] {
            "Sem 1",
            "Sem 2",
            "Summer"});
            this.cB_semester.Location = new System.Drawing.Point(34, 145);
            this.cB_semester.Name = "cB_semester";
            this.cB_semester.Size = new System.Drawing.Size(232, 40);
            this.cB_semester.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Semester:";
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_stCourse);
            this.Controls.Add(this.panel1);
            this.Name = "Courses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Courses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stCourse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_logged;
        private System.Windows.Forms.DataGridView dgv_stCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cr_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cr_semester;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_enrolment;
        private System.Windows.Forms.ComboBox cB_courses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB_semester;
        private System.Windows.Forms.Label label2;
    }
}