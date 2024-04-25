namespace ProjGym.使用者控制項
{
    partial class UCAdmin_Gym
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
            this.btn_Info = new System.Windows.Forms.Button();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_BusinessHours = new System.Windows.Forms.Label();
            this.lbl_GymName = new System.Windows.Forms.Label();
            this.pb_GymPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GymPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Info
            // 
            this.btn_Info.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Info.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Info.ForeColor = System.Drawing.Color.Blue;
            this.btn_Info.Location = new System.Drawing.Point(392, 120);
            this.btn_Info.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(90, 34);
            this.btn_Info.TabIndex = 9;
            this.btn_Info.Text = "詳細資訊";
            this.btn_Info.UseVisualStyleBackColor = false;
            this.btn_Info.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lbl_Address
            // 
            this.lbl_Address.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Address.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Address.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Address.Location = new System.Drawing.Point(212, 78);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(270, 76);
            this.lbl_Address.TabIndex = 8;
            this.lbl_Address.Text = "---";
            // 
            // lbl_BusinessHours
            // 
            this.lbl_BusinessHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_BusinessHours.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_BusinessHours.ForeColor = System.Drawing.Color.Blue;
            this.lbl_BusinessHours.Location = new System.Drawing.Point(212, 40);
            this.lbl_BusinessHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BusinessHours.Name = "lbl_BusinessHours";
            this.lbl_BusinessHours.Size = new System.Drawing.Size(270, 38);
            this.lbl_BusinessHours.TabIndex = 7;
            this.lbl_BusinessHours.Text = "---";
            // 
            // lbl_GymName
            // 
            this.lbl_GymName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_GymName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_GymName.ForeColor = System.Drawing.Color.Blue;
            this.lbl_GymName.Location = new System.Drawing.Point(212, 0);
            this.lbl_GymName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GymName.Name = "lbl_GymName";
            this.lbl_GymName.Size = new System.Drawing.Size(270, 40);
            this.lbl_GymName.TabIndex = 6;
            this.lbl_GymName.Text = "---";
            // 
            // pb_GymPhoto
            // 
            this.pb_GymPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_GymPhoto.Location = new System.Drawing.Point(0, 0);
            this.pb_GymPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pb_GymPhoto.Name = "pb_GymPhoto";
            this.pb_GymPhoto.Size = new System.Drawing.Size(212, 154);
            this.pb_GymPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_GymPhoto.TabIndex = 5;
            this.pb_GymPhoto.TabStop = false;
            // 
            // UCAdmin_Gym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_BusinessHours);
            this.Controls.Add(this.lbl_GymName);
            this.Controls.Add(this.pb_GymPhoto);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCAdmin_Gym";
            this.Size = new System.Drawing.Size(482, 154);
            ((System.ComponentModel.ISupportInitialize)(this.pb_GymPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_BusinessHours;
        private System.Windows.Forms.Label lbl_GymName;
        private System.Windows.Forms.PictureBox pb_GymPhoto;
    }
}
