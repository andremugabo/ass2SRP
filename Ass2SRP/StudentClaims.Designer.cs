namespace Ass2SRP
{
    partial class StudentClaims
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_logged_info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_claim = new System.Windows.Forms.Button();
            this.txt_claim = new System.Windows.Forms.TextBox();
            this.dgv_claims = new System.Windows.Forms.DataGridView();
            this.cl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_claims)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lbl_logged_info);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 100);
            this.panel1.TabIndex = 0;
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(457, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Claims";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_claim);
            this.groupBox1.Controls.Add(this.txt_claim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(6, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 533);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Claim";
            // 
            // btn_claim
            // 
            this.btn_claim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_claim.BackColor = System.Drawing.Color.Blue;
            this.btn_claim.ForeColor = System.Drawing.Color.White;
            this.btn_claim.Location = new System.Drawing.Point(64, 459);
            this.btn_claim.Name = "btn_claim";
            this.btn_claim.Size = new System.Drawing.Size(292, 57);
            this.btn_claim.TabIndex = 1;
            this.btn_claim.Text = "Submit";
            this.btn_claim.UseVisualStyleBackColor = false;
            this.btn_claim.Click += new System.EventHandler(this.btn_claim_Click);
            // 
            // txt_claim
            // 
            this.txt_claim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_claim.Location = new System.Drawing.Point(18, 52);
            this.txt_claim.Multiline = true;
            this.txt_claim.Name = "txt_claim";
            this.txt_claim.Size = new System.Drawing.Size(382, 374);
            this.txt_claim.TabIndex = 0;
            // 
            // dgv_claims
            // 
            this.dgv_claims.AllowUserToAddRows = false;
            this.dgv_claims.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgv_claims.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_claims.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_claims.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_claims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_claims.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_name,
            this.cl_data,
            this.cl_status});
            this.dgv_claims.Location = new System.Drawing.Point(434, 127);
            this.dgv_claims.Name = "dgv_claims";
            this.dgv_claims.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgv_claims.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_claims.RowTemplate.Height = 28;
            this.dgv_claims.Size = new System.Drawing.Size(662, 533);
            this.dgv_claims.TabIndex = 2;
            // 
            // cl_name
            // 
            this.cl_name.DataPropertyName = "cl_name";
            this.cl_name.HeaderText = "Claim";
            this.cl_name.Name = "cl_name";
            this.cl_name.ReadOnly = true;
            // 
            // cl_data
            // 
            this.cl_data.DataPropertyName = "cl_date";
            this.cl_data.HeaderText = "Claim Date";
            this.cl_data.Name = "cl_data";
            this.cl_data.ReadOnly = true;
            // 
            // cl_status
            // 
            this.cl_status.DataPropertyName = "cl_status";
            this.cl_status.HeaderText = "Claim Status";
            this.cl_status.Name = "cl_status";
            this.cl_status.ReadOnly = true;
            // 
            // StudentClaims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 672);
            this.Controls.Add(this.dgv_claims);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "StudentClaims";
            this.Text = "StudentClaims";
            this.Load += new System.EventHandler(this.StudentClaims_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_claims)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_logged_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_claim;
        private System.Windows.Forms.TextBox txt_claim;
        private System.Windows.Forms.DataGridView dgv_claims;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_status;
    }
}