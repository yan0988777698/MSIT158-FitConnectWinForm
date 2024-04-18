namespace ProjGym
{
    partial class FrmMember_CourseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember_CourseHistory));
            this.flowLayoutPanel_History = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_History = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_History
            // 
            this.flowLayoutPanel_History.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_History.AutoScroll = true;
            this.flowLayoutPanel_History.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_History.Location = new System.Drawing.Point(54, 77);
            this.flowLayoutPanel_History.Name = "flowLayoutPanel_History";
            this.flowLayoutPanel_History.Size = new System.Drawing.Size(530, 568);
            this.flowLayoutPanel_History.TabIndex = 0;
            // 
            // lbl_History
            // 
            this.lbl_History.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_History.BackColor = System.Drawing.Color.Transparent;
            this.lbl_History.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_History.Image = ((System.Drawing.Image)(resources.GetObject("lbl_History.Image")));
            this.lbl_History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_History.Location = new System.Drawing.Point(49, 33);
            this.lbl_History.Name = "lbl_History";
            this.lbl_History.Size = new System.Drawing.Size(266, 41);
            this.lbl_History.TabIndex = 2;
            this.lbl_History.Text = "歷史課程清單";
            this.lbl_History.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMember_CourseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1287, 683);
            this.Controls.Add(this.lbl_History);
            this.Controls.Add(this.flowLayoutPanel_History);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMember_CourseHistory";
            this.Text = "Member | 歷史訂單";
            this.Load += new System.EventHandler(this.FrmMember_CourseHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_History;
        private System.Windows.Forms.Label lbl_History;
    }
}