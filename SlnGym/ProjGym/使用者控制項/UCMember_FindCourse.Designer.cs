namespace ProjGym
{
    partial class UCMember_FindCourse
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
            this.lbl_CourseName = new System.Windows.Forms.Label();
            this.lbl_CourseIntro = new System.Windows.Forms.Label();
            this.pb_CoursePhoto = new System.Windows.Forms.PictureBox();
            this.btn_Reserve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CoursePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CourseName
            // 
            this.lbl_CourseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_CourseName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CourseName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_CourseName.Location = new System.Drawing.Point(203, 0);
            this.lbl_CourseName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_CourseName.Name = "lbl_CourseName";
            this.lbl_CourseName.Size = new System.Drawing.Size(336, 36);
            this.lbl_CourseName.TabIndex = 1;
            this.lbl_CourseName.Text = "課程名稱";
            // 
            // lbl_CourseIntro
            // 
            this.lbl_CourseIntro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_CourseIntro.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CourseIntro.Location = new System.Drawing.Point(203, 36);
            this.lbl_CourseIntro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_CourseIntro.Name = "lbl_CourseIntro";
            this.lbl_CourseIntro.Size = new System.Drawing.Size(336, 155);
            this.lbl_CourseIntro.TabIndex = 2;
            this.lbl_CourseIntro.Text = "課程介紹";
            // 
            // pb_CoursePhoto
            // 
            this.pb_CoursePhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_CoursePhoto.Location = new System.Drawing.Point(0, 0);
            this.pb_CoursePhoto.Margin = new System.Windows.Forms.Padding(5);
            this.pb_CoursePhoto.Name = "pb_CoursePhoto";
            this.pb_CoursePhoto.Size = new System.Drawing.Size(203, 241);
            this.pb_CoursePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CoursePhoto.TabIndex = 0;
            this.pb_CoursePhoto.TabStop = false;
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.AutoSize = true;
            this.btn_Reserve.BackColor = System.Drawing.Color.Snow;
            this.btn_Reserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Reserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reserve.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Reserve.Location = new System.Drawing.Point(239, 196);
            this.btn_Reserve.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Size = new System.Drawing.Size(101, 40);
            this.btn_Reserve.TabIndex = 6;
            this.btn_Reserve.Text = "預約課程";
            this.btn_Reserve.UseVisualStyleBackColor = false;
            // 
            // UCMember_CourseBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.lbl_CourseIntro);
            this.Controls.Add(this.lbl_CourseName);
            this.Controls.Add(this.pb_CoursePhoto);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCMember_CourseBox";
            this.Size = new System.Drawing.Size(539, 241);
            ((System.ComponentModel.ISupportInitialize)(this.pb_CoursePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_CoursePhoto;
        private System.Windows.Forms.Label lbl_CourseName;
        private System.Windows.Forms.Label lbl_CourseIntro;
        private System.Windows.Forms.Button btn_Reserve;
    }
}
