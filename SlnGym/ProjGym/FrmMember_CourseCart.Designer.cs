namespace ProjGym
{
    partial class FrmMember_CourseCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember_CourseCart));
            this.flowLayoutPanel_ReservedCourseList = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Cart = new System.Windows.Forms.Label();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_GoPay = new System.Windows.Forms.Button();
            this.panel_PayPage = new System.Windows.Forms.Panel();
            this.pb_Cover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cover)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_ReservedCourseList
            // 
            this.flowLayoutPanel_ReservedCourseList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_ReservedCourseList.AutoScroll = true;
            this.flowLayoutPanel_ReservedCourseList.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_ReservedCourseList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_ReservedCourseList.Location = new System.Drawing.Point(114, 68);
            this.flowLayoutPanel_ReservedCourseList.Name = "flowLayoutPanel_ReservedCourseList";
            this.flowLayoutPanel_ReservedCourseList.Size = new System.Drawing.Size(582, 526);
            this.flowLayoutPanel_ReservedCourseList.TabIndex = 0;
            // 
            // lbl_Cart
            // 
            this.lbl_Cart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Cart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cart.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Cart.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Cart.Image")));
            this.lbl_Cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Cart.Location = new System.Drawing.Point(109, 24);
            this.lbl_Cart.Name = "lbl_Cart";
            this.lbl_Cart.Size = new System.Drawing.Size(266, 41);
            this.lbl_Cart.TabIndex = 1;
            this.lbl_Cart.Text = "課程購物車";
            this.lbl_Cart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_TotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lbl_TotalPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_TotalPrice.Location = new System.Drawing.Point(494, 597);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(202, 41);
            this.lbl_TotalPrice.TabIndex = 2;
            this.lbl_TotalPrice.Text = "總計:";
            this.lbl_TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_GoBack.BackColor = System.Drawing.Color.Transparent;
            this.btn_GoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GoBack.FlatAppearance.BorderSize = 0;
            this.btn_GoBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_GoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoBack.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_GoBack.Location = new System.Drawing.Point(586, 29);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(5);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(110, 36);
            this.btn_GoBack.TabIndex = 6;
            this.btn_GoBack.Text = "<<繼續選課";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_GoPay
            // 
            this.btn_GoPay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_GoPay.BackColor = System.Drawing.Color.Snow;
            this.btn_GoPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_GoPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_GoPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_GoPay.Location = new System.Drawing.Point(586, 660);
            this.btn_GoPay.Margin = new System.Windows.Forms.Padding(5);
            this.btn_GoPay.Name = "btn_GoPay";
            this.btn_GoPay.Size = new System.Drawing.Size(110, 42);
            this.btn_GoPay.TabIndex = 7;
            this.btn_GoPay.Text = "前往付款";
            this.btn_GoPay.UseVisualStyleBackColor = false;
            this.btn_GoPay.Click += new System.EventHandler(this.btn_GoPay_Click);
            // 
            // panel_PayPage
            // 
            this.panel_PayPage.BackColor = System.Drawing.Color.Transparent;
            this.panel_PayPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_PayPage.Location = new System.Drawing.Point(739, 0);
            this.panel_PayPage.Name = "panel_PayPage";
            this.panel_PayPage.Size = new System.Drawing.Size(532, 710);
            this.panel_PayPage.TabIndex = 8;
            // 
            // pb_Cover
            // 
            this.pb_Cover.BackColor = System.Drawing.Color.Transparent;
            this.pb_Cover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Cover.BackgroundImage")));
            this.pb_Cover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Cover.Location = new System.Drawing.Point(0, 0);
            this.pb_Cover.Name = "pb_Cover";
            this.pb_Cover.Size = new System.Drawing.Size(739, 710);
            this.pb_Cover.TabIndex = 9;
            this.pb_Cover.TabStop = false;
            this.pb_Cover.Visible = false;
            // 
            // FrmMember_CourseCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 710);
            this.Controls.Add(this.pb_Cover);
            this.Controls.Add(this.panel_PayPage);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_GoPay);
            this.Controls.Add(this.lbl_TotalPrice);
            this.Controls.Add(this.lbl_Cart);
            this.Controls.Add(this.flowLayoutPanel_ReservedCourseList);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMember_CourseCart";
            this.Text = "Member | 購物車";
            this.Load += new System.EventHandler(this.FrmMember_CheckCourseReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ReservedCourseList;
        private System.Windows.Forms.Label lbl_Cart;
        private System.Windows.Forms.Label lbl_TotalPrice;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_GoPay;
        private System.Windows.Forms.Panel panel_PayPage;
        private System.Windows.Forms.PictureBox pb_Cover;
    }
}