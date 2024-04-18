namespace ProjGym
{
    partial class UCMember_UniformNumbers
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
            this.tb_Company = new System.Windows.Forms.TextBox();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.tb_UniformNumber = new System.Windows.Forms.TextBox();
            this.lbl_UniformNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Company
            // 
            this.tb_Company.Location = new System.Drawing.Point(81, 6);
            this.tb_Company.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tb_Company.Name = "tb_Company";
            this.tb_Company.Size = new System.Drawing.Size(186, 29);
            this.tb_Company.TabIndex = 3;
            // 
            // lbl_Company
            // 
            this.lbl_Company.Location = new System.Drawing.Point(1, 1);
            this.lbl_Company.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(81, 39);
            this.lbl_Company.TabIndex = 2;
            this.lbl_Company.Text = "公司名稱:";
            this.lbl_Company.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_UniformNumber
            // 
            this.tb_UniformNumber.Location = new System.Drawing.Point(81, 45);
            this.tb_UniformNumber.Margin = new System.Windows.Forms.Padding(5);
            this.tb_UniformNumber.Name = "tb_UniformNumber";
            this.tb_UniformNumber.Size = new System.Drawing.Size(186, 29);
            this.tb_UniformNumber.TabIndex = 5;
            // 
            // lbl_UniformNumber
            // 
            this.lbl_UniformNumber.Location = new System.Drawing.Point(1, 40);
            this.lbl_UniformNumber.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_UniformNumber.Name = "lbl_UniformNumber";
            this.lbl_UniformNumber.Size = new System.Drawing.Size(81, 39);
            this.lbl_UniformNumber.TabIndex = 4;
            this.lbl_UniformNumber.Text = "統一編號:";
            this.lbl_UniformNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCMember_UniformNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_UniformNumber);
            this.Controls.Add(this.lbl_UniformNumber);
            this.Controls.Add(this.tb_Company);
            this.Controls.Add(this.lbl_Company);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCMember_UniformNumbers";
            this.Size = new System.Drawing.Size(277, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Company;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.TextBox tb_UniformNumber;
        private System.Windows.Forms.Label lbl_UniformNumber;
    }
}
