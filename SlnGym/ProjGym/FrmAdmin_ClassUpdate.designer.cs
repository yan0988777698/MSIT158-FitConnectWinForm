using ProjGym;
using System.Linq;
namespace mid_Coonect
{
    partial class FrmAdmin_ClassUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin_ClassUpdate));
            this.pb_ClassPhoto = new System.Windows.Forms.PictureBox();
            this.lbl_Divider = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_IDTitle = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Sort1Title = new System.Windows.Forms.Label();
            this.cb_Sort1 = new System.Windows.Forms.ComboBox();
            this.lbl_Sort2Title = new System.Windows.Forms.Label();
            this.cb_Sort2 = new System.Windows.Forms.ComboBox();
            this.lbl_ClassNameTitle = new System.Windows.Forms.Label();
            this.txt_ClassName = new System.Windows.Forms.TextBox();
            this.txt_Introduction = new System.Windows.Forms.TextBox();
            this.lbl_IntroductionTitle = new System.Windows.Forms.Label();
            this.cb_Limit = new System.Windows.Forms.ComboBox();
            this.lbl_LimitTitle = new System.Windows.Forms.Label();
            this.dataGridView_ClassSortList = new System.Windows.Forms.DataGridView();
            this.lbl_PhotoTitle = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.cb_Open = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ClassPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClassSortList)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_ClassPhoto
            // 
            this.pb_ClassPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_ClassPhoto.BackColor = System.Drawing.SystemColors.Window;
            this.pb_ClassPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_ClassPhoto.Location = new System.Drawing.Point(706, 532);
            this.pb_ClassPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_ClassPhoto.Name = "pb_ClassPhoto";
            this.pb_ClassPhoto.Size = new System.Drawing.Size(515, 185);
            this.pb_ClassPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ClassPhoto.TabIndex = 7;
            this.pb_ClassPhoto.TabStop = false;
            this.pb_ClassPhoto.Click += new System.EventHandler(this.pb_ClassPhoto_Click);
            // 
            // lbl_Divider
            // 
            this.lbl_Divider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Divider.Location = new System.Drawing.Point(689, 729);
            this.lbl_Divider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Divider.Name = "lbl_Divider";
            this.lbl_Divider.Size = new System.Drawing.Size(545, 2);
            this.lbl_Divider.TabIndex = 6;
            this.lbl_Divider.Text = "label1";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.BackColor = System.Drawing.Color.Snow;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.Location = new System.Drawing.Point(1003, 741);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(103, 45);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "儲存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cancel.BackColor = System.Drawing.Color.Snow;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancel.Location = new System.Drawing.Point(833, 741);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 45);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_IDTitle
            // 
            this.lbl_IDTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_IDTitle.AutoSize = true;
            this.lbl_IDTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IDTitle.Location = new System.Drawing.Point(701, 10);
            this.lbl_IDTitle.Name = "lbl_IDTitle";
            this.lbl_IDTitle.Size = new System.Drawing.Size(74, 21);
            this.lbl_IDTitle.TabIndex = 8;
            this.lbl_IDTitle.Text = "課程編號";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_ID.Location = new System.Drawing.Point(791, 9);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(24, 21);
            this.lbl_ID.TabIndex = 9;
            this.lbl_ID.Text = "id";
            // 
            // lbl_Sort1Title
            // 
            this.lbl_Sort1Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Sort1Title.AutoSize = true;
            this.lbl_Sort1Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sort1Title.Location = new System.Drawing.Point(729, 68);
            this.lbl_Sort1Title.Name = "lbl_Sort1Title";
            this.lbl_Sort1Title.Size = new System.Drawing.Size(42, 21);
            this.lbl_Sort1Title.TabIndex = 10;
            this.lbl_Sort1Title.Text = "類型";
            // 
            // cb_Sort1
            // 
            this.cb_Sort1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Sort1.FormattingEnabled = true;
            this.cb_Sort1.Location = new System.Drawing.Point(796, 64);
            this.cb_Sort1.Name = "cb_Sort1";
            this.cb_Sort1.Size = new System.Drawing.Size(158, 29);
            this.cb_Sort1.TabIndex = 11;
            this.cb_Sort1.Text = "--";
            // 
            // lbl_Sort2Title
            // 
            this.lbl_Sort2Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Sort2Title.AutoSize = true;
            this.lbl_Sort2Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sort2Title.Location = new System.Drawing.Point(995, 68);
            this.lbl_Sort2Title.Name = "lbl_Sort2Title";
            this.lbl_Sort2Title.Size = new System.Drawing.Size(42, 21);
            this.lbl_Sort2Title.TabIndex = 10;
            this.lbl_Sort2Title.Text = "分類";
            // 
            // cb_Sort2
            // 
            this.cb_Sort2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Sort2.FormattingEnabled = true;
            this.cb_Sort2.Location = new System.Drawing.Point(1052, 64);
            this.cb_Sort2.Name = "cb_Sort2";
            this.cb_Sort2.Size = new System.Drawing.Size(158, 29);
            this.cb_Sort2.TabIndex = 11;
            this.cb_Sort2.Text = "--";
            // 
            // lbl_ClassNameTitle
            // 
            this.lbl_ClassNameTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ClassNameTitle.AutoSize = true;
            this.lbl_ClassNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ClassNameTitle.Location = new System.Drawing.Point(701, 177);
            this.lbl_ClassNameTitle.Name = "lbl_ClassNameTitle";
            this.lbl_ClassNameTitle.Size = new System.Drawing.Size(74, 21);
            this.lbl_ClassNameTitle.TabIndex = 12;
            this.lbl_ClassNameTitle.Text = "課程名稱";
            // 
            // txt_ClassName
            // 
            this.txt_ClassName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ClassName.Location = new System.Drawing.Point(706, 201);
            this.txt_ClassName.Name = "txt_ClassName";
            this.txt_ClassName.Size = new System.Drawing.Size(515, 29);
            this.txt_ClassName.TabIndex = 13;
            // 
            // txt_Introduction
            // 
            this.txt_Introduction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Introduction.Location = new System.Drawing.Point(706, 298);
            this.txt_Introduction.Multiline = true;
            this.txt_Introduction.Name = "txt_Introduction";
            this.txt_Introduction.Size = new System.Drawing.Size(515, 181);
            this.txt_Introduction.TabIndex = 15;
            // 
            // lbl_IntroductionTitle
            // 
            this.lbl_IntroductionTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_IntroductionTitle.AutoSize = true;
            this.lbl_IntroductionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_IntroductionTitle.Location = new System.Drawing.Point(701, 274);
            this.lbl_IntroductionTitle.Name = "lbl_IntroductionTitle";
            this.lbl_IntroductionTitle.Size = new System.Drawing.Size(42, 21);
            this.lbl_IntroductionTitle.TabIndex = 14;
            this.lbl_IntroductionTitle.Text = "介紹";
            // 
            // cb_Limit
            // 
            this.cb_Limit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Limit.FormattingEnabled = true;
            this.cb_Limit.Location = new System.Drawing.Point(796, 115);
            this.cb_Limit.Name = "cb_Limit";
            this.cb_Limit.Size = new System.Drawing.Size(158, 29);
            this.cb_Limit.TabIndex = 17;
            this.cb_Limit.Text = "--";
            // 
            // lbl_LimitTitle
            // 
            this.lbl_LimitTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_LimitTitle.AutoSize = true;
            this.lbl_LimitTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LimitTitle.Location = new System.Drawing.Point(729, 120);
            this.lbl_LimitTitle.Name = "lbl_LimitTitle";
            this.lbl_LimitTitle.Size = new System.Drawing.Size(42, 21);
            this.lbl_LimitTitle.TabIndex = 16;
            this.lbl_LimitTitle.Text = "限制";
            // 
            // dataGridView_ClassSortList
            // 
            this.dataGridView_ClassSortList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView_ClassSortList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_ClassSortList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ClassSortList.Location = new System.Drawing.Point(71, 65);
            this.dataGridView_ClassSortList.Name = "dataGridView_ClassSortList";
            this.dataGridView_ClassSortList.RowHeadersWidth = 51;
            this.dataGridView_ClassSortList.RowTemplate.Height = 27;
            this.dataGridView_ClassSortList.Size = new System.Drawing.Size(556, 654);
            this.dataGridView_ClassSortList.TabIndex = 22;
            this.dataGridView_ClassSortList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ClassSortList_CellDoubleClick);
            this.dataGridView_ClassSortList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ClassSortList_CellDoubleClick);
            // 
            // lbl_PhotoTitle
            // 
            this.lbl_PhotoTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_PhotoTitle.AutoSize = true;
            this.lbl_PhotoTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PhotoTitle.Location = new System.Drawing.Point(701, 505);
            this.lbl_PhotoTitle.Name = "lbl_PhotoTitle";
            this.lbl_PhotoTitle.Size = new System.Drawing.Size(42, 21);
            this.lbl_PhotoTitle.TabIndex = 14;
            this.lbl_PhotoTitle.Text = "照片";
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Create.BackColor = System.Drawing.Color.Snow;
            this.btn_Create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Create.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Create.Location = new System.Drawing.Point(228, 741);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(103, 45);
            this.btn_Create.TabIndex = 4;
            this.btn_Create.Text = "新增類別";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Delete.BackColor = System.Drawing.Color.Snow;
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("微軟正黑體", 10.76635F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Delete.Location = new System.Drawing.Point(72, 741);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(103, 45);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "刪除類別";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // cb_Open
            // 
            this.cb_Open.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Open.FormattingEnabled = true;
            this.cb_Open.Location = new System.Drawing.Point(1052, 115);
            this.cb_Open.Name = "cb_Open";
            this.cb_Open.Size = new System.Drawing.Size(158, 29);
            this.cb_Open.TabIndex = 24;
            this.cb_Open.Text = "--";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(995, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "開放";
            // 
            // FrmAdmin_ClassUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1272, 857);
            this.Controls.Add(this.cb_Open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_ClassSortList);
            this.Controls.Add(this.cb_Limit);
            this.Controls.Add(this.lbl_LimitTitle);
            this.Controls.Add(this.txt_Introduction);
            this.Controls.Add(this.lbl_PhotoTitle);
            this.Controls.Add(this.lbl_IntroductionTitle);
            this.Controls.Add(this.txt_ClassName);
            this.Controls.Add(this.lbl_ClassNameTitle);
            this.Controls.Add(this.cb_Sort2);
            this.Controls.Add(this.cb_Sort1);
            this.Controls.Add(this.lbl_Sort2Title);
            this.Controls.Add(this.lbl_Sort1Title);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_IDTitle);
            this.Controls.Add(this.pb_ClassPhoto);
            this.Controls.Add(this.lbl_Divider);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdmin_ClassUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin | 課程管理";
            this.Load += new System.EventHandler(this.FrmClassUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ClassPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClassSortList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ClassPhoto;
        private System.Windows.Forms.Label lbl_Divider;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_IDTitle;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Sort1Title;
        private System.Windows.Forms.ComboBox cb_Sort1;
        private System.Windows.Forms.Label lbl_Sort2Title;
        private System.Windows.Forms.ComboBox cb_Sort2;
        private System.Windows.Forms.Label lbl_ClassNameTitle;
        private System.Windows.Forms.TextBox txt_ClassName;
        private System.Windows.Forms.TextBox txt_Introduction;
        private System.Windows.Forms.Label lbl_IntroductionTitle;
        private System.Windows.Forms.ComboBox cb_Limit;
        private System.Windows.Forms.Label lbl_LimitTitle;
        private System.Windows.Forms.DataGridView dataGridView_ClassSortList;
        private System.Windows.Forms.Label lbl_PhotoTitle;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ComboBox cb_Open;
        private System.Windows.Forms.Label label1;
    }
}