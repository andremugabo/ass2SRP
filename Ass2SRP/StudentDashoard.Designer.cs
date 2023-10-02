namespace Ass2SRP
{
    partial class StudentDashoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_logged = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_courseDS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_particularStudentInfo = new System.Windows.Forms.DataGridView();
            this.st_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lklb_claims = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lklb_courses = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_particularStudentInfo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1022, 100);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.btn_courseDS);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 472);
            this.panel2.TabIndex = 0;
            // 
            // btn_courseDS
            // 
            this.btn_courseDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_courseDS.ForeColor = System.Drawing.Color.Blue;
            this.btn_courseDS.Location = new System.Drawing.Point(3, 112);
            this.btn_courseDS.Name = "btn_courseDS";
            this.btn_courseDS.Size = new System.Drawing.Size(269, 44);
            this.btn_courseDS.TabIndex = 0;
            this.btn_courseDS.Text = "Courses";
            this.btn_courseDS.UseVisualStyleBackColor = true;
            this.btn_courseDS.Click += new System.EventHandler(this.btn_courseDS_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(3, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Claims";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgv_particularStudentInfo);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(290, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 472);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Dashboard";
            // 
            // dgv_particularStudentInfo
            // 
            this.dgv_particularStudentInfo.AllowUserToAddRows = false;
            this.dgv_particularStudentInfo.AllowUserToDeleteRows = false;
            this.dgv_particularStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_particularStudentInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_particularStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_particularStudentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.st_names,
            this.st_email,
            this.st_reg,
            this.d_name,
            this.p_name});
            this.dgv_particularStudentInfo.Location = new System.Drawing.Point(6, 230);
            this.dgv_particularStudentInfo.Name = "dgv_particularStudentInfo";
            this.dgv_particularStudentInfo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_particularStudentInfo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_particularStudentInfo.RowTemplate.Height = 28;
            this.dgv_particularStudentInfo.Size = new System.Drawing.Size(732, 236);
            this.dgv_particularStudentInfo.TabIndex = 1;
            // 
            // st_names
            // 
            this.st_names.DataPropertyName = "st_names";
            this.st_names.HeaderText = "Names";
            this.st_names.Name = "st_names";
            this.st_names.ReadOnly = true;
            // 
            // st_email
            // 
            this.st_email.DataPropertyName = "st_email";
            this.st_email.HeaderText = "Email";
            this.st_email.Name = "st_email";
            this.st_email.ReadOnly = true;
            // 
            // st_reg
            // 
            this.st_reg.DataPropertyName = "st_reg";
            this.st_reg.HeaderText = "Regstration Number";
            this.st_reg.Name = "st_reg";
            this.st_reg.ReadOnly = true;
            // 
            // d_name
            // 
            this.d_name.DataPropertyName = "d_name";
            this.d_name.HeaderText = "Department";
            this.d_name.Name = "d_name";
            this.d_name.ReadOnly = true;
            // 
            // p_name
            // 
            this.p_name.DataPropertyName = "p_name";
            this.p_name.HeaderText = "Program";
            this.p_name.Name = "p_name";
            this.p_name.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Blue;
            this.groupBox3.Controls.Add(this.lklb_courses);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(319, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 135);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Courses";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Blue;
            this.groupBox2.Controls.Add(this.lklb_claims);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(29, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 135);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Claims";
            // 
            // lklb_claims
            // 
            this.lklb_claims.ActiveLinkColor = System.Drawing.Color.White;
            this.lklb_claims.AutoSize = true;
            this.lklb_claims.LinkColor = System.Drawing.Color.White;
            this.lklb_claims.Location = new System.Drawing.Point(124, 58);
            this.lklb_claims.Name = "lklb_claims";
            this.lklb_claims.Size = new System.Drawing.Size(93, 29);
            this.lklb_claims.TabIndex = 1;
            this.lklb_claims.TabStop = true;
            this.lklb_claims.Text = "Claims";
            this.lklb_claims.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lklb_courses
            // 
            this.lklb_courses.AutoSize = true;
            this.lklb_courses.BackColor = System.Drawing.Color.Blue;
            this.lklb_courses.LinkColor = System.Drawing.Color.White;
            this.lklb_courses.Location = new System.Drawing.Point(126, 65);
            this.lklb_courses.Name = "lklb_courses";
            this.lklb_courses.Size = new System.Drawing.Size(110, 29);
            this.lklb_courses.TabIndex = 1;
            this.lklb_courses.TabStop = true;
            this.lklb_courses.Text = "Courses";
            this.lklb_courses.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklb_courses_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(384, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Dashboard";
            // 
            // StudentDashoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentDashoard";
            this.Text = "StudentDashoard";
            this.Load += new System.EventHandler(this.StudentDashoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_particularStudentInfo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_courseDS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lklb_claims;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_logged;
        private System.Windows.Forms.DataGridView dgv_particularStudentInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_names;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.LinkLabel lklb_courses;
        private System.Windows.Forms.Label label1;
    }
}