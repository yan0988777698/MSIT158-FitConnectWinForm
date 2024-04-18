namespace ProjGym.使用者控制項
{
    partial class UCMember_FindCoach
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMember_FindCoach));
            this.pictureBox_Photo = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Expertise = new System.Windows.Forms.Label();
            this.lbl_District = new System.Windows.Forms.Label();
            this.btn_More = new System.Windows.Forms.Button();
            this.lbl_Intro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Photo
            // 
            this.pictureBox_Photo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_Photo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Photo.Image")));
            this.pictureBox_Photo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Photo.Name = "pictureBox_Photo";
            this.pictureBox_Photo.Size = new System.Drawing.Size(122, 211);
            this.pictureBox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Photo.TabIndex = 0;
            this.pictureBox_Photo.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Name.Location = new System.Drawing.Point(122, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(334, 26);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "(姓名)";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Expertise
            // 
            this.lbl_Expertise.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Expertise.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Expertise.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lbl_Expertise.Location = new System.Drawing.Point(122, 26);
            this.lbl_Expertise.Name = "lbl_Expertise";
            this.lbl_Expertise.Size = new System.Drawing.Size(334, 26);
            this.lbl_Expertise.TabIndex = 2;
            this.lbl_Expertise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_District
            // 
            this.lbl_District.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_District.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_District.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_District.Location = new System.Drawing.Point(122, 52);
            this.lbl_District.Name = "lbl_District";
            this.lbl_District.Size = new System.Drawing.Size(334, 26);
            this.lbl_District.TabIndex = 3;
            // 
            // btn_More
            // 
            this.btn_More.BackColor = System.Drawing.Color.Snow;
            this.btn_More.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_More.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_More.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_More.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_More.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_More.Location = new System.Drawing.Point(388, 127);
            this.btn_More.Margin = new System.Windows.Forms.Padding(5);
            this.btn_More.Name = "btn_More";
            this.btn_More.Size = new System.Drawing.Size(68, 28);
            this.btn_More.TabIndex = 6;
            this.btn_More.Text = "更多...";
            this.btn_More.UseVisualStyleBackColor = false;
            // 
            // lbl_Intro
            // 
            this.lbl_Intro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Intro.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Intro.ForeColor = System.Drawing.Color.Black;
            this.lbl_Intro.Location = new System.Drawing.Point(122, 78);
            this.lbl_Intro.Name = "lbl_Intro";
            this.lbl_Intro.Size = new System.Drawing.Size(334, 133);
            this.lbl_Intro.TabIndex = 7;
            this.lbl_Intro.Text = "(自我介紹)";
            // 
            // UCMember_FindCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_More);
            this.Controls.Add(this.lbl_Intro);
            this.Controls.Add(this.lbl_District);
            this.Controls.Add(this.lbl_Expertise);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pictureBox_Photo);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCMember_FindCoach";
            this.Size = new System.Drawing.Size(456, 211);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Photo;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Expertise;
        private System.Windows.Forms.Label lbl_Intro;
        private System.Windows.Forms.Label lbl_District;
        private System.Windows.Forms.Button btn_More;
        
    }
}
