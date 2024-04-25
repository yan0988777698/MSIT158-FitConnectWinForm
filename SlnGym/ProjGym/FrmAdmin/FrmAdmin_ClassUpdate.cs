using ProjGym;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid_Coonect
{
    public partial class FrmAdmin_ClassUpdate : Form
    {
        private DialogResult _isOK;
        public DialogResult isOK { get { return _isOK; } }
        private string _imagepath;
        private tclasses _course;
        int _index = 1;
        public tclasses course
        {
            get
            {
                if (_course == null) { _course = new tclasses(); }
                _course.class_id = Convert.ToInt32(lbl_ID.Text);
                _course.class_sort1_id = Convert.ToInt32(cb_Sort1.Text);
                _course.class_sort2_id = Convert.ToInt32(cb_Sort2.Text);
                _course.limited_gender = Convert.ToInt32(cb_Limit.Text);
                _course.class_name = txt_ClassName.Text;
                _course.class_introduction = this.txt_Introduction.Text;

                _course.class_photo = _imagepath;
                return _course;
            }
            set
            {
                _course = value;
                lbl_ID.Text = _course.class_id.ToString();
                cb_Sort1.Text = _course.class_sort1_id.ToString();
                cb_Sort2.Text = _course.class_sort2_id.ToString();
                cb_Limit.Text = _course.limited_gender.ToString();
                txt_ClassName.Text = _course.class_name;
                txt_Introduction.Text = _course.class_introduction;
                _imagepath = _course.class_photo;
                if (!string.IsNullOrEmpty(_imagepath))
                {
                    string path = Application.StartupPath + "\\ClassPic";
                    pb_ClassPhoto.Image = new Bitmap(path + "\\" + _imagepath);
                }
            }
        }
        public FrmAdmin_ClassUpdate()
        {
            InitializeComponent();
        }

        private void pb_ClassPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "課程照片|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            _imagepath = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            string path = Application.StartupPath + "\\ClassPic";
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            File.Copy(openFileDialog1.FileName, path + "\\" + _imagepath);
            this.pb_ClassPhoto.Image = new Bitmap(path + "\\" + _imagepath);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _isOK = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (this.lbl_ID.Text.ToString().Equals("id")) return;
            _isOK = DialogResult.OK;
            try
            {
                int id = Convert.ToInt32(lbl_ID.Text);
                dbEdit(id);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { ShowdbCalss(); dbSelect(1); }
        }
        private void ShowdbCalss()
        {
            gymEntities db = new gymEntities();
            var classsort = from r in db.tclasses
                            select new
                            {
                                編號 = r.class_id,
                                課程名稱 = r.class_name,
                                類型 = r.tclass_sort_有氧.class_sort1_detail,
                                分類 = r.tclass_sort_訓練.class_sort2_detail,
                                //照片 = r.class_photo,
                                //介紹 = r.class_introduction,
                                開放 = r.class_status,
                                限制 = r.tclass_limit_details.describe
                            };
            this.dataGridView_ClassSortList.DataSource = classsort.ToList();
            this.dataGridView_ClassSortList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void FrmClassUpdate_Load(object sender, EventArgs e)
        {
            gymEntities gymEntities = new gymEntities();
            var sort1s = from sort1 in gymEntities.tclass_sort_有氧 select sort1;
            foreach (var sort1 in sort1s)
                this.cb_Sort1.Items.Add(sort1.class_sort1_detail);

            var sort2s = from sort2 in gymEntities.tclass_sort_訓練 select sort2;
            foreach (var sort2 in sort2s)
                this.cb_Sort2.Items.Add(sort2.class_sort2_detail);
            var limits = from limit in gymEntities.tclass_limit_details select limit;
            foreach (var limit in limits)
                this.cb_Limit.Items.Add(limit.describe);


            this.cb_Open.Items.Add("關閉");
            this.cb_Open.Items.Add("開放");
            ShowdbCalss();
            dbSelect(1);
        }
        private void dbSelect(int id)
        {
            gymEntities db = new gymEntities();
            pb_ClassPhoto.Image = null;
            tclasses classsort = db.tclasses.FirstOrDefault(x => x.class_id == id);
            if (classsort == null) return;
            this.course = classsort;
            lbl_ID.Text = classsort.class_id.ToString();
            cb_Sort1.Text = classsort.tclass_sort_有氧.class_sort1_detail.ToString();
            cb_Sort2.Text = classsort.tclass_sort_訓練.class_sort2_detail.ToString();
            cb_Limit.Text = classsort.tclass_limit_details.describe.ToString();
            cb_Open.SelectedIndex = Convert.ToInt32(classsort.class_status);
            txt_ClassName.Text = classsort.class_name;
            txt_Introduction.Text = classsort.class_introduction;
            _imagepath = classsort.class_photo;
            if (!string.IsNullOrEmpty(_imagepath))
            {
                string path = Application.StartupPath + "\\ClassPic";
                pb_ClassPhoto.Image = new Bitmap(path + "\\" + _imagepath);
            }
        }
        private void dbEdit(int id)
        {
            using (gymEntities db = new gymEntities())
            {
                var classsort = db.tclasses.FirstOrDefault(x => x.class_id == id);
                if (classsort == null) return;
                classsort.class_sort1_id = db.tclass_sort_有氧.FirstOrDefault(x => x.class_sort1_detail.Equals(cb_Sort1.Text)).class_sort1_id;
                classsort.class_sort2_id = db.tclass_sort_訓練.FirstOrDefault(x => x.class_sort2_detail.Equals(cb_Sort2.Text)).class_sort2_id;
                classsort.limited_gender = db.tclass_limit_details.FirstOrDefault(x => x.describe.Equals(cb_Limit.Text)).class_limited_id;
                classsort.class_status = Convert.ToBoolean(cb_Open.SelectedIndex);
                classsort.class_name = txt_ClassName.Text;
                classsort.class_introduction = txt_Introduction.Text;

                if (!string.IsNullOrEmpty(_imagepath))
                {
                    string path = Application.StartupPath + "\\ClassPic";
                    pb_ClassPhoto.Image = new Bitmap(path + "\\" + _imagepath);
                }
                classsort.class_photo = _imagepath;
                MessageBox.Show("資料儲存成功");
                db.SaveChanges();
            }
        }
        private void DataGridView_ClassSortList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            _index = (int)dataGridView_ClassSortList.Rows[e.RowIndex].Cells[0].Value;
            dbSelect(_index);
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            //TODO:新增的課程會跳號，會導致其他表單的課程combobox selectedIndex + 1 的寫法對不上新增課程的流水號
            gymEntities gymEntities = new gymEntities();
            tclasses c = new tclasses();
            c.class_sort1_id = c.class_sort2_id = 1;
            c.class_status = true;
            c.limited_gender = 0;
            c.class_name = "新增課程名稱";
            gymEntities.tclasses.Add(c);
            gymEntities.SaveChanges();
            dbSelect(1);
            ShowdbCalss();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            gymEntities gymEntities = new gymEntities();
            var removedClass = gymEntities.tclasses.FirstOrDefault(x => x.class_id == _index);
            gymEntities.tclasses.Remove(removedClass);
            gymEntities.SaveChanges();
            dbSelect(1);
            ShowdbCalss();
        }
    }
}
