namespace ProjGym
{
    partial class FrmMember_FindGym
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember_FindGym));
            this.flowLayoutPanel_Gym = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.cb_Region = new System.Windows.Forms.ComboBox();
            this.cb_City = new System.Windows.Forms.ComboBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Gym
            // 
            this.flowLayoutPanel_Gym.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_Gym.AutoScroll = true;
            this.flowLayoutPanel_Gym.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel_Gym.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flowLayoutPanel_Gym.Location = new System.Drawing.Point(64, 122);
            this.flowLayoutPanel_Gym.Name = "flowLayoutPanel_Gym";
            this.flowLayoutPanel_Gym.Size = new System.Drawing.Size(1092, 567);
            this.flowLayoutPanel_Gym.TabIndex = 13;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSearch.ForeColor = System.Drawing.Color.Blue;
            this.lblSearch.Location = new System.Drawing.Point(71, 36);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 20);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "搜尋";
            // 
            // lblRegion
            // 
            this.lblRegion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRegion.AutoSize = true;
            this.lblRegion.BackColor = System.Drawing.Color.Transparent;
            this.lblRegion.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRegion.ForeColor = System.Drawing.Color.Blue;
            this.lblRegion.Location = new System.Drawing.Point(395, 36);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 20);
            this.lblRegion.TabIndex = 11;
            this.lblRegion.Text = "地區";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCity.ForeColor = System.Drawing.Color.Blue;
            this.lblCity.Location = new System.Drawing.Point(230, 36);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(41, 20);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "縣市";
            // 
            // cb_Region
            // 
            this.cb_Region.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Region.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_Region.FormattingEnabled = true;
            this.cb_Region.Location = new System.Drawing.Point(439, 33);
            this.cb_Region.Name = "cb_Region";
            this.cb_Region.Size = new System.Drawing.Size(104, 28);
            this.cb_Region.TabIndex = 9;
            this.cb_Region.SelectedIndexChanged += new System.EventHandler(this.cb_Region_SelectedIndexChanged);
            // 
            // cb_City
            // 
            this.cb_City.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_City.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_City.FormattingEnabled = true;
            this.cb_City.Location = new System.Drawing.Point(275, 33);
            this.cb_City.Name = "cb_City";
            this.cb_City.Size = new System.Drawing.Size(104, 28);
            this.cb_City.TabIndex = 8;
            this.cb_City.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Search.Location = new System.Drawing.Point(115, 33);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(107, 29);
            this.tb_Search.TabIndex = 7;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // FrmMember_FindGym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1213, 764);
            this.Controls.Add(this.flowLayoutPanel_Gym);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cb_Region);
            this.Controls.Add(this.cb_City);
            this.Controls.Add(this.tb_Search);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMember_FindGym";
            this.Text = "FrmMember_FindGym";
            this.Load += new System.EventHandler(this.FrmMember_FindGym_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Gym;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cb_Region;
        private System.Windows.Forms.ComboBox cb_City;
        private System.Windows.Forms.TextBox tb_Search;
    }
}