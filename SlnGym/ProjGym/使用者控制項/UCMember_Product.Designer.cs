namespace ProjGym
{
    partial class uc_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Product));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_SalesVolume = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.lb_ProductName = new System.Windows.Forms.Label();
            this.pb_Photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(121, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "直接購買";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "加入購物車";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_SalesVolume
            // 
            this.lb_SalesVolume.AutoSize = true;
            this.lb_SalesVolume.Location = new System.Drawing.Point(87, 258);
            this.lb_SalesVolume.Name = "lb_SalesVolume";
            this.lb_SalesVolume.Size = new System.Drawing.Size(71, 12);
            this.lb_SalesVolume.TabIndex = 4;
            this.lb_SalesVolume.Text = "總銷量 > 100";
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Location = new System.Drawing.Point(108, 228);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(29, 12);
            this.lb_Price.TabIndex = 5;
            this.lb_Price.Text = "$899";
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Location = new System.Drawing.Point(39, 198);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(167, 12);
            this.lb_ProductName.TabIndex = 6;
            this.lb_ProductName.Text = "濃縮乳清蛋白1KG(多口味可選)";
            // 
            // pb_Photo
            // 
            this.pb_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Photo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Photo.Image")));
            this.pb_Photo.Location = new System.Drawing.Point(37, 3);
            this.pb_Photo.Name = "pb_Photo";
            this.pb_Photo.Size = new System.Drawing.Size(171, 174);
            this.pb_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Photo.TabIndex = 3;
            this.pb_Photo.TabStop = false;
            // 
            // uc_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_SalesVolume);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.lb_ProductName);
            this.Controls.Add(this.pb_Photo);
            this.Name = "uc_Product";
            this.Size = new System.Drawing.Size(243, 326);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_SalesVolume;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label lb_ProductName;
        private System.Windows.Forms.PictureBox pb_Photo;
    }
}
