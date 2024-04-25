namespace ProjGym.FrmMember
{
    partial class FrmMember_GymInfo
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
            this.components = new System.ComponentModel.Container();
            this.pb_Field = new System.Windows.Forms.PictureBox();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.flowLayoutPanel_pb_Field = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Field)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Field
            // 
            this.pb_Field.Location = new System.Drawing.Point(12, 72);
            this.pb_Field.Name = "pb_Field";
            this.pb_Field.Size = new System.Drawing.Size(536, 314);
            this.pb_Field.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Field.TabIndex = 5;
            this.pb_Field.TabStop = false;
            // 
            // lblDescribe
            // 
            this.lblDescribe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Font = new System.Drawing.Font("新細明體", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDescribe.ForeColor = System.Drawing.Color.Blue;
            this.lblDescribe.Location = new System.Drawing.Point(610, 136);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(22, 14);
            this.lblDescribe.TabIndex = 10;
            this.lblDescribe.Text = "---";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("新細明體", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTime.ForeColor = System.Drawing.Color.Blue;
            this.lblTime.Location = new System.Drawing.Point(610, 104);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(22, 14);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "---";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("新細明體", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAddress.ForeColor = System.Drawing.Color.Blue;
            this.lblAddress.Location = new System.Drawing.Point(610, 71);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(22, 14);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "---";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("新細明體", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(12, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(30, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "---";
            // 
            // flowLayoutPanel_pb_Field
            // 
            this.flowLayoutPanel_pb_Field.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_pb_Field.AutoScroll = true;
            this.flowLayoutPanel_pb_Field.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_pb_Field.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flowLayoutPanel_pb_Field.Location = new System.Drawing.Point(12, 392);
            this.flowLayoutPanel_pb_Field.Name = "flowLayoutPanel_pb_Field";
            this.flowLayoutPanel_pb_Field.Size = new System.Drawing.Size(536, 145);
            this.flowLayoutPanel_pb_Field.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMember_GymInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 549);
            this.Controls.Add(this.pb_Field);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.flowLayoutPanel_pb_Field);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMember_GymInfo";
            this.Text = "FrmMember_GymInfo";
            this.Load += new System.EventHandler(this.FrmMember_GymInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Field)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Field;
        private System.Windows.Forms.Label lblDescribe;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_pb_Field;
        private System.Windows.Forms.Timer timer1;
    }
}