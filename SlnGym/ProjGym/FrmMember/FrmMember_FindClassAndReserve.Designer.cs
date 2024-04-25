namespace ProjGym
{
    partial class FrmMember_FindClassAndReserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember_FindClassAndReserve));
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Reserve = new System.Windows.Forms.DataGridView();
            this.dataGridView_ClassInfo = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClassInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker_Start.Location = new System.Drawing.Point(249, 36);
            this.dateTimePicker_Start.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker_Start.MinDate = new System.DateTime(2024, 4, 17, 0, 0, 0, 0);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(161, 29);
            this.dateTimePicker_Start.TabIndex = 1;
            this.dateTimePicker_Start.ValueChanged += new System.EventHandler(this.dateTimePicker_Start_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(130, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "課程起始日:";
            // 
            // dataGridView_Reserve
            // 
            this.dataGridView_Reserve.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView_Reserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Reserve.Location = new System.Drawing.Point(134, 104);
            this.dataGridView_Reserve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_Reserve.Name = "dataGridView_Reserve";
            this.dataGridView_Reserve.RowHeadersWidth = 51;
            this.dataGridView_Reserve.RowTemplate.Height = 27;
            this.dataGridView_Reserve.Size = new System.Drawing.Size(938, 502);
            this.dataGridView_Reserve.TabIndex = 6;
            this.dataGridView_Reserve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Reserve_CellContentClick);
            // 
            // dataGridView_ClassInfo
            // 
            this.dataGridView_ClassInfo.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView_ClassInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ClassInfo.Location = new System.Drawing.Point(134, 624);
            this.dataGridView_ClassInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_ClassInfo.Name = "dataGridView_ClassInfo";
            this.dataGridView_ClassInfo.RowHeadersWidth = 51;
            this.dataGridView_ClassInfo.RowTemplate.Height = 27;
            this.dataGridView_ClassInfo.Size = new System.Drawing.Size(285, 134);
            this.dataGridView_ClassInfo.TabIndex = 9;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Snow;
            this.btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Clear.Location = new System.Drawing.Point(429, 34);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(68, 33);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // FrmMember_FindClassAndReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 799);
            this.Controls.Add(this.dataGridView_ClassInfo);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dataGridView_Reserve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_Start);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMember_FindClassAndReserve";
            this.Text = "Member | 課程預約";
            this.Load += new System.EventHandler(this.FrmCurriculum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClassInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Reserve;
        private System.Windows.Forms.DataGridView dataGridView_ClassInfo;
        private System.Windows.Forms.Button btn_Clear;
    }
}