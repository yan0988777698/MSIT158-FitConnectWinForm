﻿namespace ProjGym
{
    partial class FrmCoach_NewRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoach_NewRegister));
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.cb_Expertise = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Intro = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_Birth = new System.Windows.Forms.DateTimePicker();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.pb_Photo = new System.Windows.Forms.PictureBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pb_ErrorName = new System.Windows.Forms.PictureBox();
            this.pb_ErrorGender = new System.Windows.Forms.PictureBox();
            this.pb_ErrorPhone = new System.Windows.Forms.PictureBox();
            this.pb_ErrorBirth = new System.Windows.Forms.PictureBox();
            this.pb_ErrorAddress = new System.Windows.Forms.PictureBox();
            this.pb_ErrorMail = new System.Windows.Forms.PictureBox();
            this.pb_ErrorPassword = new System.Windows.Forms.PictureBox();
            this.pb_ErrorExpertise = new System.Windows.Forms.PictureBox();
            this.pb_ErrorIntro = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel_Exp = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorExpertise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Snow;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.Location = new System.Drawing.Point(851, 552);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(111, 44);
            this.btn_Cancel.TabIndex = 100;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Snow;
            this.btn_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Register.Location = new System.Drawing.Point(987, 552);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(111, 44);
            this.btn_Register.TabIndex = 101;
            this.btn_Register.Text = "註冊";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // cb_Expertise
            // 
            this.cb_Expertise.BackColor = System.Drawing.Color.Snow;
            this.cb_Expertise.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Expertise.FormattingEnabled = true;
            this.cb_Expertise.Location = new System.Drawing.Point(238, 373);
            this.cb_Expertise.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Expertise.Name = "cb_Expertise";
            this.cb_Expertise.Size = new System.Drawing.Size(194, 29);
            this.cb_Expertise.TabIndex = 99;
            this.cb_Expertise.SelectedIndexChanged += new System.EventHandler(this.cb_Expertise_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(167, 374);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 98;
            this.label8.Text = "專長:";
            // 
            // tb_Intro
            // 
            this.tb_Intro.BackColor = System.Drawing.Color.Snow;
            this.tb_Intro.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Intro.Location = new System.Drawing.Point(238, 441);
            this.tb_Intro.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Intro.Name = "tb_Intro";
            this.tb_Intro.Size = new System.Drawing.Size(587, 155);
            this.tb_Intro.TabIndex = 97;
            this.tb_Intro.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(167, 441);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 24);
            this.label9.TabIndex = 96;
            this.label9.Text = "簡介:";
            // 
            // tb_Address
            // 
            this.tb_Address.BackColor = System.Drawing.Color.Snow;
            this.tb_Address.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Address.Location = new System.Drawing.Point(238, 178);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(432, 29);
            this.tb_Address.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(167, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 94;
            this.label7.Text = "地址:";
            // 
            // dateTimePicker_Birth
            // 
            this.dateTimePicker_Birth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Birth.Location = new System.Drawing.Point(566, 110);
            this.dateTimePicker_Birth.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_Birth.Name = "dateTimePicker_Birth";
            this.dateTimePicker_Birth.Size = new System.Drawing.Size(194, 29);
            this.dateTimePicker_Birth.TabIndex = 93;
            // 
            // cb_Gender
            // 
            this.cb_Gender.BackColor = System.Drawing.Color.Snow;
            this.cb_Gender.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Location = new System.Drawing.Point(566, 43);
            this.cb_Gender.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(104, 29);
            this.cb_Gender.TabIndex = 92;
            // 
            // pb_Photo
            // 
            this.pb_Photo.BackColor = System.Drawing.Color.Snow;
            this.pb_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Photo.Location = new System.Drawing.Point(819, 42);
            this.pb_Photo.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Photo.Name = "pb_Photo";
            this.pb_Photo.Size = new System.Drawing.Size(279, 291);
            this.pb_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Photo.TabIndex = 91;
            this.pb_Photo.TabStop = false;
            this.pb_Photo.Click += new System.EventHandler(this.pb_Photo_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.Snow;
            this.tb_Password.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Password.Location = new System.Drawing.Point(238, 305);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(265, 29);
            this.tb_Password.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(167, 307);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 89;
            this.label6.Text = "密碼:";
            // 
            // tb_Mail
            // 
            this.tb_Mail.BackColor = System.Drawing.Color.Snow;
            this.tb_Mail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Mail.Location = new System.Drawing.Point(238, 239);
            this.tb_Mail.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(265, 29);
            this.tb_Mail.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(167, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 87;
            this.label5.Text = "電郵:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(495, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 86;
            this.label4.Text = "生日:";
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.Color.Snow;
            this.tb_Phone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Phone.Location = new System.Drawing.Point(238, 110);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(194, 29);
            this.tb_Phone.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(167, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 84;
            this.label3.Text = "電話:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(495, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 83;
            this.label1.Text = "性別:";
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.Snow;
            this.tb_Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Name.Location = new System.Drawing.Point(238, 42);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(160, 29);
            this.tb_Name.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(167, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 81;
            this.label2.Text = "姓名:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pb_ErrorName
            // 
            this.pb_ErrorName.BackColor = System.Drawing.Color.Transparent;
            this.pb_ErrorName.Image = ((System.Drawing.Image)(resources.GetObject("pb_ErrorName.Image")));
            this.pb_ErrorName.Location = new System.Drawing.Point(134, 46);
            this.pb_ErrorName.Name = "pb_ErrorName";
            this.pb_ErrorName.Size = new System.Drawing.Size(26, 26);
            this.pb_ErrorName.TabIndex = 102;
            this.pb_ErrorName.TabStop = false;
            this.pb_ErrorName.Visible = false;
            // 
            // pb_ErrorGender
            // 
            this.pb_ErrorGender.BackColor = System.Drawing.Color.Transparent;
            this.pb_ErrorGender.Image = ((System.Drawing.Image)(resources.GetObject("pb_ErrorGender.Image")));
            this.pb_ErrorGender.Location = new System.Drawing.Point(462, 46);
            this.pb_ErrorGender.Name = "pb_ErrorGender";
            this.pb_ErrorGender.Size = new System.Drawing.Size(26, 26);
            this.pb_ErrorGender.TabIndex = 103;
            this.pb_ErrorGender.TabStop = false;
            this.pb_ErrorGender.Visible = false;
            // 
            // pb_ErrorPhone
            // 
            this.pb_ErrorPhone.BackColor = System.Drawing.Color.Transparent;
            this.pb_ErrorPhone.Image = ((System.Drawing.Image)(resources.GetObject("pb_ErrorPhone.Image")));
            this.pb_ErrorPhone.Location = new System.Drawing.Point(134, 114);
            this.pb_ErrorPhone.Name = "pb_ErrorPhone";
            this.pb_ErrorPhone.Size = new System.Drawing.Size(26, 26);
            this.pb_ErrorPhone.TabIndex = 104;
            this.pb_ErrorPhone.TabStop = false;
            this.pb_ErrorPhone.Visible = false;
            // 
            // pb_ErrorBirth
            // 
            this.pb_ErrorBirth.BackColor = System.Drawing.Color.Transparent;
            this.pb_ErrorBirth.Image = ((System.Drawing.Image)(resources.GetObject("pb_ErrorBirth.Image")));
            this.pb_ErrorBirth.Location = new System.Drawing.Point(462, 114);
            this.pb_ErrorBirth.Name = "pb_ErrorBirth";
            this.pb_ErrorBirth.Size = new System.Drawing.Size(26, 26);
            this.pb_ErrorBirth.TabIndex = 104;
            this.pb_ErrorBirth.TabStop = false;
            this.pb_ErrorBirth.Visible = false;
            // 
            // pb_ErrorAddress
            // 
            this.pb_ErrorAddress.BackColor = System.Drawing.Color.Transparent;
            this.pb_ErrorAddress.Image = ((System.Drawing.Image)(resources.GetObject("pb_ErrorAddress.Image")));
            this.pb_ErrorAddress.Location = new System.Drawing.Point(134, 182);
            this.pb_ErrorAddress.Name = "pb_ErrorAddress";
            this.pb_ErrorAddress.Size = new System.Drawing.Size(26, 26);
            this.pb_ErrorAddress.TabIndex = 104;
            this.pb_ErrorAddress.TabStop = false;
            this.pb_ErrorAddress.Visible = false;
            // 
            // pb_ErrorMail
            // 
            this.pb_ErrorMail.BackColor = System.Drawing.Color.Transparent;
            this.pb_ErrorMail.Image = ((System.Drawing.Image)(resources.GetObject("pb_ErrorMail.Image")));
            this.pb_ErrorMail.Location = new System.Drawing.Point(134, 243);
            this.pb_ErrorMail.Name = "pb_ErrorMail";
            this.pb_ErrorMail.Size = new System.Drawing.Size(26, 26);
            this.pb_ErrorMail.TabIndex = 104;
            this.pb_ErrorMail.TabStop = false;
            this.pb_ErrorMail.Visible = false;
            // 
            // pb_ErrorPassword
            // 
            this.pb_ErrorPassword.BackColor = System.Drawing.Color.Transparent;
            this.pb_ErrorPassword.Image = ((System.Drawing.Image)(resources.GetObject("pb_ErrorPassword.Image")));
            this.pb_ErrorPassword.Location = new System.Drawing.Point(134, 309);
            this.pb_ErrorPassword.Name = "pb_ErrorPassword";
            this.pb_ErrorPassword.Size = new System.Drawing.Size(26, 26);
            this.pb_ErrorPassword.TabIndex = 104;
            this.pb_ErrorPassword.TabStop = false;
            this.pb_ErrorPassword.Visible = false;
            // 
            // pb_ErrorExpertise
            // 
            this.pb_ErrorExpertise.BackColor = System.Drawing.Color.Transparent;
            this.pb_ErrorExpertise.Image = ((System.Drawing.Image)(resources.GetObject("pb_ErrorExpertise.Image")));
            this.pb_ErrorExpertise.Location = new System.Drawing.Point(134, 376);
            this.pb_ErrorExpertise.Name = "pb_ErrorExpertise";
            this.pb_ErrorExpertise.Size = new System.Drawing.Size(26, 26);
            this.pb_ErrorExpertise.TabIndex = 104;
            this.pb_ErrorExpertise.TabStop = false;
            this.pb_ErrorExpertise.Visible = false;
            // 
            // pb_ErrorIntro
            // 
            this.pb_ErrorIntro.BackColor = System.Drawing.Color.Transparent;
            this.pb_ErrorIntro.Image = ((System.Drawing.Image)(resources.GetObject("pb_ErrorIntro.Image")));
            this.pb_ErrorIntro.Location = new System.Drawing.Point(134, 441);
            this.pb_ErrorIntro.Name = "pb_ErrorIntro";
            this.pb_ErrorIntro.Size = new System.Drawing.Size(26, 26);
            this.pb_ErrorIntro.TabIndex = 104;
            this.pb_ErrorIntro.TabStop = false;
            this.pb_ErrorIntro.Visible = false;
            // 
            // flowLayoutPanel_Exp
            // 
            this.flowLayoutPanel_Exp.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel_Exp.Location = new System.Drawing.Point(470, 369);
            this.flowLayoutPanel_Exp.Name = "flowLayoutPanel_Exp";
            this.flowLayoutPanel_Exp.Size = new System.Drawing.Size(628, 61);
            this.flowLayoutPanel_Exp.TabIndex = 105;
            // 
            // FrmCoach_NewRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 636);
            this.Controls.Add(this.flowLayoutPanel_Exp);
            this.Controls.Add(this.pb_ErrorIntro);
            this.Controls.Add(this.pb_ErrorExpertise);
            this.Controls.Add(this.pb_ErrorPassword);
            this.Controls.Add(this.pb_ErrorMail);
            this.Controls.Add(this.pb_ErrorAddress);
            this.Controls.Add(this.pb_ErrorBirth);
            this.Controls.Add(this.pb_ErrorPhone);
            this.Controls.Add(this.pb_ErrorGender);
            this.Controls.Add(this.pb_ErrorName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.cb_Expertise);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_Intro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker_Birth);
            this.Controls.Add(this.cb_Gender);
            this.Controls.Add(this.pb_Photo);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCoach_NewRegister";
            this.Text = "Coach | 註冊成為教練";
            this.Load += new System.EventHandler(this.FrmCoach_NewRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorExpertise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ErrorIntro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.ComboBox cb_Expertise;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tb_Intro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birth;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.PictureBox pb_Photo;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pb_ErrorName;
        private System.Windows.Forms.PictureBox pb_ErrorGender;
        private System.Windows.Forms.PictureBox pb_ErrorPhone;
        private System.Windows.Forms.PictureBox pb_ErrorBirth;
        private System.Windows.Forms.PictureBox pb_ErrorAddress;
        private System.Windows.Forms.PictureBox pb_ErrorMail;
        private System.Windows.Forms.PictureBox pb_ErrorPassword;
        private System.Windows.Forms.PictureBox pb_ErrorExpertise;
        private System.Windows.Forms.PictureBox pb_ErrorIntro;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Exp;
    }
}