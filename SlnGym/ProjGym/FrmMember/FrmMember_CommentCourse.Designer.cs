namespace ProjGym
{
    partial class FrmMember_CommentCourse
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
            this.tb_EvaluateCoach = new System.Windows.Forms.TextBox();
            this.lbl_EvaluateCoachError = new System.Windows.Forms.Label();
            this.tb_EvaluateCourse = new System.Windows.Forms.TextBox();
            this.lbl_EvaluateCourseError = new System.Windows.Forms.Label();
            this.tb_CommentCoach = new System.Windows.Forms.TextBox();
            this.tb_CommentCourse = new System.Windows.Forms.TextBox();
            this.lbl_CommentCoach = new System.Windows.Forms.Label();
            this.lbl_CommentCourse = new System.Windows.Forms.Label();
            this.lbl_CoachRateTitle = new System.Windows.Forms.Label();
            this.lbl_CoachCommentTitle = new System.Windows.Forms.Label();
            this.lbl_CourseCommentTitle = new System.Windows.Forms.Label();
            this.lbl_CourseRateTitle = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_tag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_EvaluateCoach
            // 
            this.tb_EvaluateCoach.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_EvaluateCoach.Location = new System.Drawing.Point(201, 29);
            this.tb_EvaluateCoach.Name = "tb_EvaluateCoach";
            this.tb_EvaluateCoach.Size = new System.Drawing.Size(75, 34);
            this.tb_EvaluateCoach.TabIndex = 0;
            this.tb_EvaluateCoach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_EvaluateCoach_KeyPress);
            this.tb_EvaluateCoach.Validating += new System.ComponentModel.CancelEventHandler(this.tb_EvaluateCoach_Validating);
            // 
            // lbl_EvaluateCoachError
            // 
            this.lbl_EvaluateCoachError.AutoSize = true;
            this.lbl_EvaluateCoachError.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_EvaluateCoachError.Location = new System.Drawing.Point(282, 33);
            this.lbl_EvaluateCoachError.Name = "lbl_EvaluateCoachError";
            this.lbl_EvaluateCoachError.Size = new System.Drawing.Size(30, 25);
            this.lbl_EvaluateCoachError.TabIndex = 1;
            this.lbl_EvaluateCoachError.Text = "--";
            // 
            // tb_EvaluateCourse
            // 
            this.tb_EvaluateCourse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_EvaluateCourse.Location = new System.Drawing.Point(201, 203);
            this.tb_EvaluateCourse.Name = "tb_EvaluateCourse";
            this.tb_EvaluateCourse.Size = new System.Drawing.Size(75, 34);
            this.tb_EvaluateCourse.TabIndex = 2;
            this.tb_EvaluateCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_EvaluateCourse_KeyPress);
            this.tb_EvaluateCourse.Validating += new System.ComponentModel.CancelEventHandler(this.tb_EvaluateCourse_Validating);
            // 
            // lbl_EvaluateCourseError
            // 
            this.lbl_EvaluateCourseError.AutoSize = true;
            this.lbl_EvaluateCourseError.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_EvaluateCourseError.Location = new System.Drawing.Point(282, 207);
            this.lbl_EvaluateCourseError.Name = "lbl_EvaluateCourseError";
            this.lbl_EvaluateCourseError.Size = new System.Drawing.Size(30, 25);
            this.lbl_EvaluateCourseError.TabIndex = 3;
            this.lbl_EvaluateCourseError.Text = "--";
            // 
            // tb_CommentCoach
            // 
            this.tb_CommentCoach.Location = new System.Drawing.Point(201, 64);
            this.tb_CommentCoach.MaxLength = 300;
            this.tb_CommentCoach.Multiline = true;
            this.tb_CommentCoach.Name = "tb_CommentCoach";
            this.tb_CommentCoach.Size = new System.Drawing.Size(396, 96);
            this.tb_CommentCoach.TabIndex = 4;
            this.tb_CommentCoach.TextChanged += new System.EventHandler(this.tb_CommentCoach_TextChanged);
            // 
            // tb_CommentCourse
            // 
            this.tb_CommentCourse.Location = new System.Drawing.Point(201, 240);
            this.tb_CommentCourse.MaxLength = 300;
            this.tb_CommentCourse.Multiline = true;
            this.tb_CommentCourse.Name = "tb_CommentCourse";
            this.tb_CommentCourse.Size = new System.Drawing.Size(396, 100);
            this.tb_CommentCourse.TabIndex = 5;
            this.tb_CommentCourse.TextChanged += new System.EventHandler(this.tb_CommentCourse_TextChanged);
            // 
            // lbl_CommentCoach
            // 
            this.lbl_CommentCoach.AutoSize = true;
            this.lbl_CommentCoach.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CommentCoach.Location = new System.Drawing.Point(197, 163);
            this.lbl_CommentCoach.Name = "lbl_CommentCoach";
            this.lbl_CommentCoach.Size = new System.Drawing.Size(30, 25);
            this.lbl_CommentCoach.TabIndex = 6;
            this.lbl_CommentCoach.Text = "--";
            // 
            // lbl_CommentCourse
            // 
            this.lbl_CommentCourse.AutoSize = true;
            this.lbl_CommentCourse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CommentCourse.Location = new System.Drawing.Point(197, 343);
            this.lbl_CommentCourse.Name = "lbl_CommentCourse";
            this.lbl_CommentCourse.Size = new System.Drawing.Size(30, 25);
            this.lbl_CommentCourse.TabIndex = 6;
            this.lbl_CommentCourse.Text = "--";
            // 
            // lbl_CoachRateTitle
            // 
            this.lbl_CoachRateTitle.AutoSize = true;
            this.lbl_CoachRateTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CoachRateTitle.Location = new System.Drawing.Point(83, 32);
            this.lbl_CoachRateTitle.Name = "lbl_CoachRateTitle";
            this.lbl_CoachRateTitle.Size = new System.Drawing.Size(112, 25);
            this.lbl_CoachRateTitle.TabIndex = 7;
            this.lbl_CoachRateTitle.Text = "對教練評分";
            // 
            // lbl_CoachCommentTitle
            // 
            this.lbl_CoachCommentTitle.AutoSize = true;
            this.lbl_CoachCommentTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CoachCommentTitle.Location = new System.Drawing.Point(83, 64);
            this.lbl_CoachCommentTitle.Name = "lbl_CoachCommentTitle";
            this.lbl_CoachCommentTitle.Size = new System.Drawing.Size(132, 25);
            this.lbl_CoachCommentTitle.TabIndex = 7;
            this.lbl_CoachCommentTitle.Text = "給教練的評語";
            // 
            // lbl_CourseCommentTitle
            // 
            this.lbl_CourseCommentTitle.AutoSize = true;
            this.lbl_CourseCommentTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CourseCommentTitle.Location = new System.Drawing.Point(83, 240);
            this.lbl_CourseCommentTitle.Name = "lbl_CourseCommentTitle";
            this.lbl_CourseCommentTitle.Size = new System.Drawing.Size(132, 25);
            this.lbl_CourseCommentTitle.TabIndex = 8;
            this.lbl_CourseCommentTitle.Text = "給課程的評語";
            // 
            // lbl_CourseRateTitle
            // 
            this.lbl_CourseRateTitle.AutoSize = true;
            this.lbl_CourseRateTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CourseRateTitle.Location = new System.Drawing.Point(83, 207);
            this.lbl_CourseRateTitle.Name = "lbl_CourseRateTitle";
            this.lbl_CourseRateTitle.Size = new System.Drawing.Size(112, 25);
            this.lbl_CourseRateTitle.TabIndex = 9;
            this.lbl_CourseRateTitle.Text = "對課程評分";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.Location = new System.Drawing.Point(353, 382);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(81, 36);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Submit.Location = new System.Drawing.Point(504, 382);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(93, 36);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "送出評論";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_tag
            // 
            this.lbl_tag.AutoSize = true;
            this.lbl_tag.Location = new System.Drawing.Point(335, 9);
            this.lbl_tag.Name = "lbl_tag";
            this.lbl_tag.Size = new System.Drawing.Size(132, 25);
            this.lbl_tag.TabIndex = 11;
            this.lbl_tag.Text = "標記一些資料";
            // 
            // FrmMember_CommentCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 430);
            this.Controls.Add(this.lbl_tag);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_CourseCommentTitle);
            this.Controls.Add(this.lbl_CourseRateTitle);
            this.Controls.Add(this.lbl_CoachCommentTitle);
            this.Controls.Add(this.lbl_CoachRateTitle);
            this.Controls.Add(this.lbl_CommentCourse);
            this.Controls.Add(this.lbl_CommentCoach);
            this.Controls.Add(this.tb_CommentCourse);
            this.Controls.Add(this.tb_CommentCoach);
            this.Controls.Add(this.lbl_EvaluateCourseError);
            this.Controls.Add(this.tb_EvaluateCourse);
            this.Controls.Add(this.lbl_EvaluateCoachError);
            this.Controls.Add(this.tb_EvaluateCoach);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMember_CommentCourse";
            this.Text = "Member | 課程評分系統";
            this.Load += new System.EventHandler(this.FrmMember_CommentCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_EvaluateCoach;
        private System.Windows.Forms.Label lbl_EvaluateCoachError;
        private System.Windows.Forms.TextBox tb_EvaluateCourse;
        private System.Windows.Forms.Label lbl_EvaluateCourseError;
        private System.Windows.Forms.TextBox tb_CommentCoach;
        private System.Windows.Forms.TextBox tb_CommentCourse;
        private System.Windows.Forms.Label lbl_CommentCoach;
        private System.Windows.Forms.Label lbl_CommentCourse;
        private System.Windows.Forms.Label lbl_CoachRateTitle;
        private System.Windows.Forms.Label lbl_CoachCommentTitle;
        private System.Windows.Forms.Label lbl_CourseCommentTitle;
        private System.Windows.Forms.Label lbl_CourseRateTitle;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_tag;
    }
}