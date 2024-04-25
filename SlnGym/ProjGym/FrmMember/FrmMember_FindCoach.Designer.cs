namespace ProjGym
{
    partial class FrmMember_FindCoach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember_FindCoach));
            this.lbl_NumberOfCoaches = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Coaches = new System.Windows.Forms.FlowLayoutPanel();
            this.tb_CoachName = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cb_Region = new System.Windows.Forms.ComboBox();
            this.cb_Classes = new System.Windows.Forms.ComboBox();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_NumberOfCoaches
            // 
            this.lbl_NumberOfCoaches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_NumberOfCoaches.AutoSize = true;
            this.lbl_NumberOfCoaches.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NumberOfCoaches.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_NumberOfCoaches.Location = new System.Drawing.Point(115, 113);
            this.lbl_NumberOfCoaches.Name = "lbl_NumberOfCoaches";
            this.lbl_NumberOfCoaches.Size = new System.Drawing.Size(121, 24);
            this.lbl_NumberOfCoaches.TabIndex = 1;
            this.lbl_NumberOfCoaches.Text = "共有--位教練";
            // 
            // flowLayoutPanel_Coaches
            // 
            this.flowLayoutPanel_Coaches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_Coaches.AutoScroll = true;
            this.flowLayoutPanel_Coaches.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel_Coaches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Coaches.Location = new System.Drawing.Point(119, 140);
            this.flowLayoutPanel_Coaches.Name = "flowLayoutPanel_Coaches";
            this.flowLayoutPanel_Coaches.Size = new System.Drawing.Size(1026, 516);
            this.flowLayoutPanel_Coaches.TabIndex = 2;
            // 
            // tb_CoachName
            // 
            this.tb_CoachName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_CoachName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_CoachName.Location = new System.Drawing.Point(119, 68);
            this.tb_CoachName.Name = "tb_CoachName";
            this.tb_CoachName.Size = new System.Drawing.Size(191, 29);
            this.tb_CoachName.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Search.Location = new System.Drawing.Point(310, 66);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(32, 32);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cb_Region
            // 
            this.cb_Region.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Region.FormattingEnabled = true;
            this.cb_Region.Location = new System.Drawing.Point(460, 68);
            this.cb_Region.Name = "cb_Region";
            this.cb_Region.Size = new System.Drawing.Size(144, 28);
            this.cb_Region.TabIndex = 5;
            this.cb_Region.SelectedIndexChanged += new System.EventHandler(this.cb_Region_SelectedIndexChanged);
            // 
            // cb_Classes
            // 
            this.cb_Classes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Classes.FormattingEnabled = true;
            this.cb_Classes.Location = new System.Drawing.Point(745, 68);
            this.cb_Classes.Name = "cb_Classes";
            this.cb_Classes.Size = new System.Drawing.Size(170, 28);
            this.cb_Classes.TabIndex = 5;
            this.cb_Classes.SelectedIndexChanged += new System.EventHandler(this.cb_Classes_SelectedIndexChanged);
            // 
            // cb_Gender
            // 
            this.cb_Gender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Location = new System.Drawing.Point(1059, 68);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(86, 28);
            this.cb_Gender.TabIndex = 5;
            this.cb_Gender.SelectedIndexChanged += new System.EventHandler(this.cb_Gender_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(405, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "地區:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(690, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "需求:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(1004, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "性別:";
            // 
            // FrmMember_FindCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1421, 693);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Gender);
            this.Controls.Add(this.cb_Classes);
            this.Controls.Add(this.cb_Region);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_CoachName);
            this.Controls.Add(this.flowLayoutPanel_Coaches);
            this.Controls.Add(this.lbl_NumberOfCoaches);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMember_FindCoach";
            this.Text = "Member | 教練資訊";
            this.Load += new System.EventHandler(this.FrmMember_FindCoach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_NumberOfCoaches;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Coaches;
        private System.Windows.Forms.TextBox tb_CoachName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cb_Region;
        private System.Windows.Forms.ComboBox cb_Classes;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}