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
            this.SuspendLayout();
            // 
            // tb_EvaluateCoach
            // 
            this.tb_EvaluateCoach.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_EvaluateCoach.Location = new System.Drawing.Point(99, 32);
            this.tb_EvaluateCoach.Name = "tb_EvaluateCoach";
            this.tb_EvaluateCoach.Size = new System.Drawing.Size(75, 29);
            this.tb_EvaluateCoach.TabIndex = 0;
            this.tb_EvaluateCoach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_EvaluateCoach_KeyPress);
            this.tb_EvaluateCoach.Validating += new System.ComponentModel.CancelEventHandler(this.tb_EvaluateCoach_Validating);
            // 
            // lbl_EvaluateCoachError
            // 
            this.lbl_EvaluateCoachError.AutoSize = true;
            this.lbl_EvaluateCoachError.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_EvaluateCoachError.Location = new System.Drawing.Point(180, 36);
            this.lbl_EvaluateCoachError.Name = "lbl_EvaluateCoachError";
            this.lbl_EvaluateCoachError.Size = new System.Drawing.Size(24, 21);
            this.lbl_EvaluateCoachError.TabIndex = 1;
            this.lbl_EvaluateCoachError.Text = "--";
            // 
            // tb_EvaluateCourse
            // 
            this.tb_EvaluateCourse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_EvaluateCourse.Location = new System.Drawing.Point(99, 208);
            this.tb_EvaluateCourse.Name = "tb_EvaluateCourse";
            this.tb_EvaluateCourse.Size = new System.Drawing.Size(75, 29);
            this.tb_EvaluateCourse.TabIndex = 2;
            this.tb_EvaluateCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_EvaluateCourse_KeyPress);
            this.tb_EvaluateCourse.Validating += new System.ComponentModel.CancelEventHandler(this.tb_EvaluateCourse_Validating);
            // 
            // lbl_EvaluateCourseError
            // 
            this.lbl_EvaluateCourseError.AutoSize = true;
            this.lbl_EvaluateCourseError.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_EvaluateCourseError.Location = new System.Drawing.Point(180, 212);
            this.lbl_EvaluateCourseError.Name = "lbl_EvaluateCourseError";
            this.lbl_EvaluateCourseError.Size = new System.Drawing.Size(24, 21);
            this.lbl_EvaluateCourseError.TabIndex = 3;
            this.lbl_EvaluateCourseError.Text = "--";
            // 
            // tb_CommentCoach
            // 
            this.tb_CommentCoach.Location = new System.Drawing.Point(99, 67);
            this.tb_CommentCoach.MaxLength = 300;
            this.tb_CommentCoach.Multiline = true;
            this.tb_CommentCoach.Name = "tb_CommentCoach";
            this.tb_CommentCoach.Size = new System.Drawing.Size(396, 96);
            this.tb_CommentCoach.TabIndex = 4;
            this.tb_CommentCoach.TextChanged += new System.EventHandler(this.tb_CommentCoach_TextChanged);
            // 
            // tb_CommentCourse
            // 
            this.tb_CommentCourse.Location = new System.Drawing.Point(99, 243);
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
            this.lbl_CommentCoach.Location = new System.Drawing.Point(95, 166);
            this.lbl_CommentCoach.Name = "lbl_CommentCoach";
            this.lbl_CommentCoach.Size = new System.Drawing.Size(24, 21);
            this.lbl_CommentCoach.TabIndex = 6;
            this.lbl_CommentCoach.Text = "--";
            // 
            // lbl_CommentCourse
            // 
            this.lbl_CommentCourse.AutoSize = true;
            this.lbl_CommentCourse.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_CommentCourse.Location = new System.Drawing.Point(95, 346);
            this.lbl_CommentCourse.Name = "lbl_CommentCourse";
            this.lbl_CommentCourse.Size = new System.Drawing.Size(24, 21);
            this.lbl_CommentCourse.TabIndex = 6;
            this.lbl_CommentCourse.Text = "--";
            // 
            // FrmMember_CommentCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 383);
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
            this.Text = "FrmMember_CommentCourse";
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
    }
}