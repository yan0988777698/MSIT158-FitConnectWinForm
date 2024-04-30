namespace ProjGym
{
    partial class FrmMain_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_ErrorLogin = new System.Windows.Forms.Label();
            this.btn_MemberRegister = new System.Windows.Forms.Button();
            this.btn_CoachRegister = new System.Windows.Forms.Button();
            this.lbl_ForgetPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(303, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "會員/教練登入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(307, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "帳號";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_UserName.Location = new System.Drawing.Point(409, 199);
            this.tb_UserName.Margin = new System.Windows.Forms.Padding(5);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(356, 34);
            this.tb_UserName.TabIndex = 2;
            this.tb_UserName.Text = "0912345678";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Password.Location = new System.Drawing.Point(409, 290);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(356, 34);
            this.tb_Password.TabIndex = 4;
            this.tb_Password.Text = "admin12345";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(307, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "密碼";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Snow;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Login.Location = new System.Drawing.Point(655, 455);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(110, 42);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "登入";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Snow;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.Location = new System.Drawing.Point(516, 455);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(110, 42);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_ErrorLogin
            // 
            this.lbl_ErrorLogin.AutoSize = true;
            this.lbl_ErrorLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ErrorLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorLogin.Location = new System.Drawing.Point(311, 354);
            this.lbl_ErrorLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ErrorLogin.Name = "lbl_ErrorLogin";
            this.lbl_ErrorLogin.Size = new System.Drawing.Size(149, 25);
            this.lbl_ErrorLogin.TabIndex = 6;
            this.lbl_ErrorLogin.Text = "lbl_ErrorLogin";
            // 
            // btn_MemberRegister
            // 
            this.btn_MemberRegister.BackColor = System.Drawing.Color.Snow;
            this.btn_MemberRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_MemberRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_MemberRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MemberRegister.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_MemberRegister.Image = ((System.Drawing.Image)(resources.GetObject("btn_MemberRegister.Image")));
            this.btn_MemberRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MemberRegister.Location = new System.Drawing.Point(121, 488);
            this.btn_MemberRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btn_MemberRegister.Name = "btn_MemberRegister";
            this.btn_MemberRegister.Size = new System.Drawing.Size(129, 42);
            this.btn_MemberRegister.TabIndex = 5;
            this.btn_MemberRegister.Text = "註冊為會員";
            this.btn_MemberRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MemberRegister.UseVisualStyleBackColor = false;
            this.btn_MemberRegister.Click += new System.EventHandler(this.btn_MemberRegister_Click);
            // 
            // btn_CoachRegister
            // 
            this.btn_CoachRegister.BackColor = System.Drawing.Color.Snow;
            this.btn_CoachRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_CoachRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_CoachRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CoachRegister.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_CoachRegister.Image = ((System.Drawing.Image)(resources.GetObject("btn_CoachRegister.Image")));
            this.btn_CoachRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CoachRegister.Location = new System.Drawing.Point(121, 424);
            this.btn_CoachRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CoachRegister.Name = "btn_CoachRegister";
            this.btn_CoachRegister.Size = new System.Drawing.Size(129, 45);
            this.btn_CoachRegister.TabIndex = 5;
            this.btn_CoachRegister.Text = "註冊為教練";
            this.btn_CoachRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CoachRegister.UseVisualStyleBackColor = false;
            this.btn_CoachRegister.Click += new System.EventHandler(this.btn_CoachRegister_Click);
            // 
            // lbl_ForgetPassword
            // 
            this.lbl_ForgetPassword.ActiveLinkColor = System.Drawing.Color.Red;
            this.lbl_ForgetPassword.AutoSize = true;
            this.lbl_ForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ForgetPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ForgetPassword.Location = new System.Drawing.Point(603, 329);
            this.lbl_ForgetPassword.Name = "lbl_ForgetPassword";
            this.lbl_ForgetPassword.Size = new System.Drawing.Size(167, 25);
            this.lbl_ForgetPassword.TabIndex = 8;
            this.lbl_ForgetPassword.TabStop = true;
            this.lbl_ForgetPassword.Text = "忘記密碼? 請點此";
            this.lbl_ForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_ForgetPassword_LinkClicked);
            // 
            // FrmMain_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1028, 572);
            this.Controls.Add(this.lbl_ForgetPassword);
            this.Controls.Add(this.lbl_ErrorLogin);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_CoachRegister);
            this.Controls.Add(this.btn_MemberRegister);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMain_Login";
            this.Text = "登入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomerLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_ErrorLogin;
        private System.Windows.Forms.Button btn_MemberRegister;
        private System.Windows.Forms.Button btn_CoachRegister;
        private System.Windows.Forms.LinkLabel lbl_ForgetPassword;
    }
}