namespace Ass2SRP
{
    partial class ProgramSt
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
            this.lbl_error = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB_id = new System.Windows.Forms.TextBox();
            this.btn_editProgram = new System.Windows.Forms.Button();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_StudentInfo = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_logged_info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBox_department = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentInfo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(58, 426);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_error.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Programs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // txtB_id
            // 
            this.txtB_id.Location = new System.Drawing.Point(48, 183);
            this.txtB_id.Name = "txtB_id";
            this.txtB_id.Size = new System.Drawing.Size(245, 35);
            this.txtB_id.TabIndex = 1;
            // 
            // btn_editProgram
            // 
            this.btn_editProgram.Location = new System.Drawing.Point(62, 333);
            this.btn_editProgram.Name = "btn_editProgram";
            this.btn_editProgram.Size = new System.Drawing.Size(211, 49);
            this.btn_editProgram.TabIndex = 0;
            this.btn_editProgram.Text = "Edit";
            this.btn_editProgram.UseVisualStyleBackColor = true;
            this.btn_editProgram.Click += new System.EventHandler(this.btn_editProgram_Click);
            // 
            // p_name
            // 
            this.p_name.DataPropertyName = "p_name";
            this.p_name.HeaderText = "Program";
            this.p_name.Name = "p_name";
            this.p_name.ReadOnly = true;
            // 
            // d_name
            // 
            this.d_name.DataPropertyName = "d_name";
            this.d_name.HeaderText = "Department";
            this.d_name.Name = "d_name";
            this.d_name.ReadOnly = true;
            // 
            // st_reg
            // 
            this.st_reg.DataPropertyName = "st_reg";
            this.st_reg.HeaderText = "Regstration Number";
            this.st_reg.Name = "st_reg";
            this.st_reg.ReadOnly = true;
            // 
            // st_email
            // 
            this.st_email.DataPropertyName = "st_email";
            this.st_email.HeaderText = "Email";
            this.st_email.Name = "st_email";
            this.st_email.ReadOnly = true;
            // 
            // st_names
            // 
            this.st_names.DataPropertyName = "st_names";
            this.st_names.HeaderText = "Names";
            this.st_names.Name = "st_names";
            this.st_names.ReadOnly = true;
            // 
            // dgv_StudentInfo
            // 
            this.dgv_StudentInfo.AllowUserToAddRows = false;
            this.dgv_StudentInfo.AllowUserToDeleteRows = false;
            this.dgv_StudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_StudentInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.st_names,
            this.st_email,
            this.st_reg,
            this.d_name,
            this.p_name});
            this.dgv_StudentInfo.Location = new System.Drawing.Point(8, 38);
            this.dgv_StudentInfo.Name = "dgv_StudentInfo";
            this.dgv_StudentInfo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_StudentInfo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_StudentInfo.RowTemplate.Height = 28;
            this.dgv_StudentInfo.Size = new System.Drawing.Size(690, 340);
            this.dgv_StudentInfo.TabIndex = 2;
            this.dgv_StudentInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StudentInfo_CellClick);
            this.dgv_StudentInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StudentInfo_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(520, 26);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(205, 51);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 35);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(367, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 91);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Student";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_StudentInfo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(367, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 396);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Students in Program";
            // 
            // lbl_logged_info
            // 
            this.lbl_logged_info.AutoSize = true;
            this.lbl_logged_info.ForeColor = System.Drawing.Color.White;
            this.lbl_logged_info.Location = new System.Drawing.Point(44, 39);
            this.lbl_logged_info.Name = "lbl_logged_info";
            this.lbl_logged_info.Size = new System.Drawing.Size(59, 20);
            this.lbl_logged_info.TabIndex = 0;
            this.lbl_logged_info.Text = "Names";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(512, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lbl_logged_info);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 100);
            this.panel1.TabIndex = 4;
            // 
            // cBox_department
            // 
            this.cBox_department.FormattingEnabled = true;
            this.cBox_department.Location = new System.Drawing.Point(48, 259);
            this.cBox_department.Name = "cBox_department";
            this.cBox_department.Size = new System.Drawing.Size(245, 37);
            this.cBox_department.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lbl_error);
            this.groupBox1.Controls.Add(this.cBox_department);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtB_id);
            this.groupBox1.Controls.Add(this.btn_editProgram);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(15, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 509);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Program";
            // 
            // ProgramSt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 662);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProgramSt";
            this.Text = "ProgramSt";
            this.Load += new System.EventHandler(this.ProgramSt_Load);
            this.Click += new System.EventHandler(this.ProgramSt_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentInfo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_id;
        private System.Windows.Forms.Button btn_editProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn st_names;
        private System.Windows.Forms.DataGridView dgv_StudentInfo;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_logged_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cBox_department;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}