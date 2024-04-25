namespace ProjGym
{
    partial class FrmAdmin_CoachVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin_CoachVerification));
            this.lbID = new System.Windows.Forms.Label();
            this.btn_Agree = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.dataGridView_UnVarifiedCoaches = new System.Windows.Forms.DataGridView();
            this.tb_intro = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pb_Photo = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_Birth = new System.Windows.Forms.DateTimePicker();
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
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel_Exp = new System.Windows.Forms.FlowLayoutPanel();
            this.cb_Expertise = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UnVarifiedCoaches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbID.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbID.Location = new System.Drawing.Point(76, 43);
            this.lbID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(24, 19);
            this.lbID.TabIndex = 103;
            this.lbID.Text = "ID";
            // 
            // btn_Agree
            // 
            this.btn_Agree.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Agree.BackColor = System.Drawing.Color.Snow;
            this.btn_Agree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Agree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Agree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agree.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Agree.Location = new System.Drawing.Point(332, 659);
            this.btn_Agree.Name = "btn_Agree";
            this.btn_Agree.Size = new System.Drawing.Size(117, 48);
            this.btn_Agree.TabIndex = 102;
            this.btn_Agree.Text = "通過";
            this.btn_Agree.UseVisualStyleBackColor = false;
            this.btn_Agree.Click += new System.EventHandler(this.btn_Agree_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Return.BackColor = System.Drawing.Color.Snow;
            this.btn_Return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Return.Location = new System.Drawing.Point(134, 659);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(117, 48);
            this.btn_Return.TabIndex = 101;
            this.btn_Return.Text = "返回主畫面";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // dataGridView_UnVarifiedCoaches
            // 
            this.dataGridView_UnVarifiedCoaches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView_UnVarifiedCoaches.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_UnVarifiedCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UnVarifiedCoaches.Location = new System.Drawing.Point(667, 457);
            this.dataGridView_UnVarifiedCoaches.Name = "dataGridView_UnVarifiedCoaches";
            this.dataGridView_UnVarifiedCoaches.RowHeadersWidth = 46;
            this.dataGridView_UnVarifiedCoaches.RowTemplate.Height = 25;
            this.dataGridView_UnVarifiedCoaches.Size = new System.Drawing.Size(367, 247);
            this.dataGridView_UnVarifiedCoaches.TabIndex = 100;
            this.dataGridView_UnVarifiedCoaches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_UnVarifiedCoaches_CellClick);
            // 
            // tb_intro
            // 
            this.tb_intro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_intro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_intro.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_intro.Location = new System.Drawing.Point(133, 460);
            this.tb_intro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_intro.Name = "tb_intro";
            this.tb_intro.ReadOnly = true;
            this.tb_intro.Size = new System.Drawing.Size(498, 179);
            this.tb_intro.TabIndex = 99;
            this.tb_intro.Text = "";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(75, 460);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 24);
            this.label9.TabIndex = 98;
            this.label9.Text = "簡介:";
            // 
            // pb_Photo
            // 
            this.pb_Photo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Photo.Location = new System.Drawing.Point(692, 65);
            this.pb_Photo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pb_Photo.Name = "pb_Photo";
            this.pb_Photo.Size = new System.Drawing.Size(281, 294);
            this.pb_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Photo.TabIndex = 97;
            this.pb_Photo.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(75, 396);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 94;
            this.label8.Text = "專長:";
            // 
            // tb_Address
            // 
            this.tb_Address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Address.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Address.Location = new System.Drawing.Point(133, 209);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.ReadOnly = true;
            this.tb_Address.Size = new System.Drawing.Size(498, 29);
            this.tb_Address.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(75, 211);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 92;
            this.label7.Text = "地址:";
            // 
            // dateTimePicker_Birth
            // 
            this.dateTimePicker_Birth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker_Birth.Enabled = false;
            this.dateTimePicker_Birth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Birth.Location = new System.Drawing.Point(429, 147);
            this.dateTimePicker_Birth.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker_Birth.Name = "dateTimePicker_Birth";
            this.dateTimePicker_Birth.Size = new System.Drawing.Size(171, 29);
            this.dateTimePicker_Birth.TabIndex = 91;
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Password.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Password.Location = new System.Drawing.Point(133, 333);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.ReadOnly = true;
            this.tb_Password.Size = new System.Drawing.Size(275, 29);
            this.tb_Password.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(75, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 89;
            this.label6.Text = "密碼:";
            // 
            // tb_Mail
            // 
            this.tb_Mail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Mail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Mail.Location = new System.Drawing.Point(133, 271);
            this.tb_Mail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.ReadOnly = true;
            this.tb_Mail.Size = new System.Drawing.Size(275, 29);
            this.tb_Mail.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(75, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 87;
            this.label5.Text = "電郵:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(370, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 86;
            this.label4.Text = "生日:";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Phone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Phone.Location = new System.Drawing.Point(133, 147);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.ReadOnly = true;
            this.tb_Phone.Size = new System.Drawing.Size(204, 29);
            this.tb_Phone.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(75, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 84;
            this.label3.Text = "電話:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(370, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 83;
            this.label1.Text = "性別:";
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Name.Location = new System.Drawing.Point(133, 90);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.ReadOnly = true;
            this.tb_Name.Size = new System.Drawing.Size(148, 29);
            this.tb_Name.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(75, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 81;
            this.label2.Text = "姓名:";
            // 
            // cb_Gender
            // 
            this.cb_Gender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Gender.Enabled = false;
            this.cb_Gender.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Location = new System.Drawing.Point(429, 90);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(97, 29);
            this.cb_Gender.TabIndex = 104;
            // 
            // flowLayoutPanel_Exp
            // 
            this.flowLayoutPanel_Exp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_Exp.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel_Exp.Location = new System.Drawing.Point(135, 390);
            this.flowLayoutPanel_Exp.Name = "flowLayoutPanel_Exp";
            this.flowLayoutPanel_Exp.Size = new System.Drawing.Size(677, 61);
            this.flowLayoutPanel_Exp.TabIndex = 107;
            // 
            // cb_Expertise
            // 
            this.cb_Expertise.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Expertise.BackColor = System.Drawing.Color.Snow;
            this.cb_Expertise.Enabled = false;
            this.cb_Expertise.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Expertise.FormattingEnabled = true;
            this.cb_Expertise.Location = new System.Drawing.Point(819, 406);
            this.cb_Expertise.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Expertise.Name = "cb_Expertise";
            this.cb_Expertise.Size = new System.Drawing.Size(98, 29);
            this.cb_Expertise.TabIndex = 106;
            this.cb_Expertise.Visible = false;
            this.cb_Expertise.SelectedIndexChanged += new System.EventHandler(this.cb_Expertise_SelectedIndexChanged);
            // 
            // FrmAdmin_CoachVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 750);
            this.Controls.Add(this.cb_Expertise);
            this.Controls.Add(this.flowLayoutPanel_Exp);
            this.Controls.Add(this.cb_Gender);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btn_Agree);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.dataGridView_UnVarifiedCoaches);
            this.Controls.Add(this.tb_intro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pb_Photo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker_Birth);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdmin_CoachVerification";
            this.Text = "Admin | 教練審核";
            this.Load += new System.EventHandler(this.FrmAdmin_CoachVerification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UnVarifiedCoaches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btn_Agree;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.DataGridView dataGridView_UnVarifiedCoaches;
        private System.Windows.Forms.RichTextBox tb_intro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pb_Photo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birth;
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
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Exp;
        private System.Windows.Forms.ComboBox cb_Expertise;
    }
}