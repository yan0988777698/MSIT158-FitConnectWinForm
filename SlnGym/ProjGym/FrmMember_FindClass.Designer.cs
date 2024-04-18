namespace ProjGym
{
    partial class FrmMember_FindClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember_FindClass));
            this.flowLayoutPanel_ClassCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_ClassCategories = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Aerobic = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Course = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_ClassCategory
            // 
            this.flowLayoutPanel_ClassCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_ClassCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_ClassCategory.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel_ClassCategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flowLayoutPanel_ClassCategory.Location = new System.Drawing.Point(190, 126);
            this.flowLayoutPanel_ClassCategory.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel_ClassCategory.Name = "flowLayoutPanel_ClassCategory";
            this.flowLayoutPanel_ClassCategory.Size = new System.Drawing.Size(995, 59);
            this.flowLayoutPanel_ClassCategory.TabIndex = 0;
            // 
            // lbl_ClassCategories
            // 
            this.lbl_ClassCategories.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ClassCategories.AutoSize = true;
            this.lbl_ClassCategories.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ClassCategories.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ClassCategories.Location = new System.Drawing.Point(35, 132);
            this.lbl_ClassCategories.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ClassCategories.Name = "lbl_ClassCategories";
            this.lbl_ClassCategories.Size = new System.Drawing.Size(116, 31);
            this.lbl_ClassCategories.TabIndex = 1;
            this.lbl_ClassCategories.Text = "課程類型:";
            // 
            // flowLayoutPanel_Aerobic
            // 
            this.flowLayoutPanel_Aerobic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_Aerobic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_Aerobic.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel_Aerobic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flowLayoutPanel_Aerobic.Location = new System.Drawing.Point(191, 34);
            this.flowLayoutPanel_Aerobic.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel_Aerobic.Name = "flowLayoutPanel_Aerobic";
            this.flowLayoutPanel_Aerobic.Size = new System.Drawing.Size(471, 59);
            this.flowLayoutPanel_Aerobic.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "有氧/無氧:";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Search.BackColor = System.Drawing.Color.Snow;
            this.btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(190, 213);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Padding = new System.Windows.Forms.Padding(2);
            this.btn_Search.Size = new System.Drawing.Size(102, 43);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "查詢";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // flowLayoutPanel_Course
            // 
            this.flowLayoutPanel_Course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_Course.AutoScroll = true;
            this.flowLayoutPanel_Course.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_Course.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel_Course.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Course.Location = new System.Drawing.Point(42, 281);
            this.flowLayoutPanel_Course.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel_Course.Name = "flowLayoutPanel_Course";
            this.flowLayoutPanel_Course.Size = new System.Drawing.Size(1143, 451);
            this.flowLayoutPanel_Course.TabIndex = 4;
            // 
            // FrmMember_ClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 757);
            this.Controls.Add(this.flowLayoutPanel_Course);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel_Aerobic);
            this.Controls.Add(this.lbl_ClassCategories);
            this.Controls.Add(this.flowLayoutPanel_ClassCategory);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMember_ClassList";
            this.Text = "Member | 課程查詢";
            this.Load += new System.EventHandler(this.FrmClassList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ClassCategory;
        private System.Windows.Forms.Label lbl_ClassCategories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Aerobic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Course;
    }
}