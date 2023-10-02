namespace Ass2SRP
{
    partial class Login
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
            this.lklb_to_signup = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txtB_LEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_errorMessage = new System.Windows.Forms.Label();
            this.chB_showPassword = new System.Windows.Forms.CheckBox();
            this.txtB_LPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_staff = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lklb_to_signup
            // 
            this.lklb_to_signup.AutoSize = true;
            this.lklb_to_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklb_to_signup.Location = new System.Drawing.Point(296, 437);
            this.lklb_to_signup.Name = "lklb_to_signup";
            this.lklb_to_signup.Size = new System.Drawing.Size(209, 20);
            this.lklb_to_signup.TabIndex = 4;
            this.lklb_to_signup.TabStop = true;
            this.lklb_to_signup.Text = "Don\'t have account? Singup";
            this.lklb_to_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklb_to_login_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(290, 347);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(497, 53);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtB_LEmail
            // 
            this.txtB_LEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtB_LEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_LEmail.Location = new System.Drawing.Point(290, 130);
            this.txtB_LEmail.Name = "txtB_LEmail";
            this.txtB_LEmail.Size = new System.Drawing.Size(497, 44);
            this.txtB_LEmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lbl_errorMessage);
            this.groupBox1.Controls.Add(this.lbl_staff);
            this.groupBox1.Controls.Add(this.chB_showPassword);
            this.groupBox1.Controls.Add(this.lklb_to_signup);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.txtB_LPassword);
            this.groupBox1.Controls.Add(this.txtB_LEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(1, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 556);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Form";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_errorMessage
            // 
            this.lbl_errorMessage.AutoSize = true;
            this.lbl_errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorMessage.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorMessage.Location = new System.Drawing.Point(295, 492);
            this.lbl_errorMessage.Name = "lbl_errorMessage";
            this.lbl_errorMessage.Size = new System.Drawing.Size(0, 20);
            this.lbl_errorMessage.TabIndex = 6;
            this.lbl_errorMessage.Click += new System.EventHandler(this.lbl_errorMessage_Click);
            // 
            // chB_showPassword
            // 
            this.chB_showPassword.AutoSize = true;
            this.chB_showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chB_showPassword.Location = new System.Drawing.Point(290, 307);
            this.chB_showPassword.Name = "chB_showPassword";
            this.chB_showPassword.Size = new System.Drawing.Size(148, 24);
            this.chB_showPassword.TabIndex = 5;
            this.chB_showPassword.Text = "Show Password";
            this.chB_showPassword.UseVisualStyleBackColor = true;
            this.chB_showPassword.CheckedChanged += new System.EventHandler(this.chB_showPassword_CheckedChanged);
            // 
            // txtB_LPassword
            // 
            this.txtB_LPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtB_LPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_LPassword.Location = new System.Drawing.Point(290, 241);
            this.txtB_LPassword.Name = "txtB_LPassword";
            this.txtB_LPassword.Size = new System.Drawing.Size(497, 44);
            this.txtB_LPassword.TabIndex = 1;
            this.txtB_LPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Request Portal";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(-7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 69);
            this.panel1.TabIndex = 2;
            // 
            // lbl_staff
            // 
            this.lbl_staff.AutoSize = true;
            this.lbl_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_staff.Location = new System.Drawing.Point(639, 307);
            this.lbl_staff.Name = "lbl_staff";
            this.lbl_staff.Size = new System.Drawing.Size(138, 24);
            this.lbl_staff.TabIndex = 5;
            this.lbl_staff.Text = "Are you a staff";
            this.lbl_staff.UseVisualStyleBackColor = true;
            this.lbl_staff.CheckedChanged += new System.EventHandler(this.chB_showPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 658);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lklb_to_signup;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtB_LEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtB_LPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chB_showPassword;
        private System.Windows.Forms.Label lbl_errorMessage;
        private System.Windows.Forms.CheckBox lbl_staff;
    }
}