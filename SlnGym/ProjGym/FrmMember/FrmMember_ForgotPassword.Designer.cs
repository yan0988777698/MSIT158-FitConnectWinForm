namespace ProjGym.FrmMember
{
    partial class FrmMember_ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember_ForgotPassword));
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_ResetPassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPhone.ForeColor = System.Drawing.Color.Sienna;
            this.lblPhone.Location = new System.Drawing.Point(208, 246);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 19);
            this.lblPhone.TabIndex = 132;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmail.ForeColor = System.Drawing.Color.Green;
            this.lblEmail.Location = new System.Drawing.Point(211, 176);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 19);
            this.lblEmail.TabIndex = 131;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Azure;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Cancel.Location = new System.Drawing.Point(194, 300);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(110, 42);
            this.btn_Cancel.TabIndex = 129;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_ResetPassword
            // 
            this.btn_ResetPassword.BackColor = System.Drawing.Color.Azure;
            this.btn_ResetPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_ResetPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_ResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetPassword.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ResetPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_ResetPassword.Location = new System.Drawing.Point(380, 300);
            this.btn_ResetPassword.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ResetPassword.Name = "btn_ResetPassword";
            this.btn_ResetPassword.Size = new System.Drawing.Size(110, 42);
            this.btn_ResetPassword.TabIndex = 130;
            this.btn_ResetPassword.Text = "確認";
            this.btn_ResetPassword.UseVisualStyleBackColor = false;
            this.btn_ResetPassword.Click += new System.EventHandler(this.btn_ResetPassword_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(52, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(561, 24);
            this.label3.TabIndex = 128;
            this.label3.Text = "請輸入已註冊的電子信箱以及手機號碼以獲取重新設定密碼的連結";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Phone.Location = new System.Drawing.Point(208, 210);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(356, 29);
            this.tb_Phone.TabIndex = 127;
            this.tb_Phone.TextChanged += new System.EventHandler(this.tb_Phone_TextChanged);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_phone.Location = new System.Drawing.Point(76, 208);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(96, 26);
            this.lbl_phone.TabIndex = 126;
            this.lbl_phone.Text = "手機號碼";
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Email.Location = new System.Drawing.Point(208, 142);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(356, 29);
            this.tb_Email.TabIndex = 125;
            this.tb_Email.TextChanged += new System.EventHandler(this.tb_Email_TextChanged);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Email.Location = new System.Drawing.Point(76, 142);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(96, 26);
            this.lbl_Email.TabIndex = 124;
            this.lbl_Email.Text = "電子信箱";
            // 
            // FrmMember_ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 375);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ResetPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lbl_Email);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmMember_ForgotPassword";
            this.Text = "Member | 忘記密碼";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_ResetPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lbl_Email;
    }
}