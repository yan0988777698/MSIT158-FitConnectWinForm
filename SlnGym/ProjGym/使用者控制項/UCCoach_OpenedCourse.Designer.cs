namespace ProjGym.使用者控制項
{
    partial class UCCoach_OpenedCourse
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
            this.lbl_TitleCourseName = new System.Windows.Forms.Label();
            this.lbl_TitleMaxStudents = new System.Windows.Forms.Label();
            this.lbl_TitleField = new System.Windows.Forms.Label();
            this.lbl_TitleDate = new System.Windows.Forms.Label();
            this.lbl_TitleTime = new System.Windows.Forms.Label();
            this.lbl_CourseName = new System.Windows.Forms.Label();
            this.lbl_MaxStudents = new System.Windows.Forms.Label();
            this.lbl_Field = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_TitleCourseName
            // 
            this.lbl_TitleCourseName.AutoSize = true;
            this.lbl_TitleCourseName.Location = new System.Drawing.Point(58, 42);
            this.lbl_TitleCourseName.Name = "lbl_TitleCourseName";
            this.lbl_TitleCourseName.Size = new System.Drawing.Size(77, 20);
            this.lbl_TitleCourseName.TabIndex = 0;
            this.lbl_TitleCourseName.Text = "課程名稱:";
            // 
            // lbl_TitleMaxStudents
            // 
            this.lbl_TitleMaxStudents.AutoSize = true;
            this.lbl_TitleMaxStudents.Location = new System.Drawing.Point(58, 110);
            this.lbl_TitleMaxStudents.Name = "lbl_TitleMaxStudents";
            this.lbl_TitleMaxStudents.Size = new System.Drawing.Size(77, 20);
            this.lbl_TitleMaxStudents.TabIndex = 1;
            this.lbl_TitleMaxStudents.Text = "上課人數:";
            // 
            // lbl_TitleField
            // 
            this.lbl_TitleField.AutoSize = true;
            this.lbl_TitleField.Location = new System.Drawing.Point(344, 29);
            this.lbl_TitleField.Name = "lbl_TitleField";
            this.lbl_TitleField.Size = new System.Drawing.Size(45, 20);
            this.lbl_TitleField.TabIndex = 0;
            this.lbl_TitleField.Text = "場地:";
            // 
            // lbl_TitleDate
            // 
            this.lbl_TitleDate.AutoSize = true;
            this.lbl_TitleDate.Location = new System.Drawing.Point(344, 85);
            this.lbl_TitleDate.Name = "lbl_TitleDate";
            this.lbl_TitleDate.Size = new System.Drawing.Size(45, 20);
            this.lbl_TitleDate.TabIndex = 1;
            this.lbl_TitleDate.Text = "日期:";
            // 
            // lbl_TitleTime
            // 
            this.lbl_TitleTime.AutoSize = true;
            this.lbl_TitleTime.Location = new System.Drawing.Point(344, 142);
            this.lbl_TitleTime.Name = "lbl_TitleTime";
            this.lbl_TitleTime.Size = new System.Drawing.Size(45, 20);
            this.lbl_TitleTime.TabIndex = 1;
            this.lbl_TitleTime.Text = "時間:";
            // 
            // lbl_CourseName
            // 
            this.lbl_CourseName.AutoSize = true;
            this.lbl_CourseName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CourseName.Location = new System.Drawing.Point(164, 39);
            this.lbl_CourseName.Name = "lbl_CourseName";
            this.lbl_CourseName.Size = new System.Drawing.Size(39, 26);
            this.lbl_CourseName.TabIndex = 0;
            this.lbl_CourseName.Text = "---";
            // 
            // lbl_MaxStudents
            // 
            this.lbl_MaxStudents.AutoSize = true;
            this.lbl_MaxStudents.Location = new System.Drawing.Point(164, 110);
            this.lbl_MaxStudents.Name = "lbl_MaxStudents";
            this.lbl_MaxStudents.Size = new System.Drawing.Size(30, 20);
            this.lbl_MaxStudents.TabIndex = 0;
            this.lbl_MaxStudents.Text = "---";
            // 
            // lbl_Field
            // 
            this.lbl_Field.AutoSize = true;
            this.lbl_Field.Location = new System.Drawing.Point(436, 29);
            this.lbl_Field.Name = "lbl_Field";
            this.lbl_Field.Size = new System.Drawing.Size(30, 20);
            this.lbl_Field.TabIndex = 0;
            this.lbl_Field.Text = "---";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(436, 85);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(30, 20);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "---";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(436, 142);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(30, 20);
            this.lbl_Time.TabIndex = 0;
            this.lbl_Time.Text = "---";
            // 
            // UCCoach_OpenedCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.lbl_TitleTime);
            this.Controls.Add(this.lbl_TitleDate);
            this.Controls.Add(this.lbl_TitleField);
            this.Controls.Add(this.lbl_TitleMaxStudents);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_MaxStudents);
            this.Controls.Add(this.lbl_Field);
            this.Controls.Add(this.lbl_CourseName);
            this.Controls.Add(this.lbl_TitleCourseName);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCCoach_OpenedCourse";
            this.Size = new System.Drawing.Size(698, 207);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TitleCourseName;
        private System.Windows.Forms.Label lbl_TitleMaxStudents;
        private System.Windows.Forms.Label lbl_TitleField;
        private System.Windows.Forms.Label lbl_TitleDate;
        private System.Windows.Forms.Label lbl_TitleTime;
        private System.Windows.Forms.Label lbl_CourseName;
        private System.Windows.Forms.Label lbl_MaxStudents;
        private System.Windows.Forms.Label lbl_Field;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Time;
    }
}
