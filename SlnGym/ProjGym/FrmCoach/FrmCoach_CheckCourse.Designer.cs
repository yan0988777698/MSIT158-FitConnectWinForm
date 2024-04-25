namespace ProjGym
{
    partial class FrmCoach_CheckCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoach_CheckCourse));
            this.flowLayoutPanel_OpenedCourse = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_OpenedCourse
            // 
            this.flowLayoutPanel_OpenedCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_OpenedCourse.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel_OpenedCourse.Location = new System.Drawing.Point(68, 70);
            this.flowLayoutPanel_OpenedCourse.Name = "flowLayoutPanel_OpenedCourse";
            this.flowLayoutPanel_OpenedCourse.Size = new System.Drawing.Size(1152, 602);
            this.flowLayoutPanel_OpenedCourse.TabIndex = 0;
            // 
            // FrmCoach_CheckCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 710);
            this.Controls.Add(this.flowLayoutPanel_OpenedCourse);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCoach_CheckCourse";
            this.Text = "FrmCoach_CheckCourse";
            this.Load += new System.EventHandler(this.FrmCoach_CheckCourse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_OpenedCourse;
    }
}