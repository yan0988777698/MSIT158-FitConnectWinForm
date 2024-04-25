﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjGym
{
    public partial class FrmMember_FindClass : Form
    {
        List<int> _Categorylist = new List<int>();
        List<int> _Aerobiclist = new List<int>();
        public tIdentity member { get; set; }
        public FrmMember_FindClass()
        {
            InitializeComponent();
        }

        private void FrmClassList_Load(object sender, EventArgs e)
        {
            gymEntities gymEntities = new gymEntities();
            var classCategories = from classCategory in gymEntities.tclass_sort_訓練
                                  select classCategory;
            classCategories.ToList().ForEach(category =>
            {
                CheckBox c = newCheckBox();
                c.Tag = category.class_sort2_id.ToString();
                c.Text = category.class_sort2_detail.ToString();
                c.CheckedChanged += this.afterCategoryChanged;
                this.flowLayoutPanel_ClassCategory.Controls.Add(c);
            });
            var types = from type in gymEntities.tclass_sort_有氧
                        select type;
            types.ToList().ForEach(type =>
            {
                CheckBox c = newCheckBox();
                c.Tag = type.class_sort1_id.ToString();
                c.Text = type.class_sort1_detail.ToString();
                c.CheckedChanged += this.afterAerobicChanged;
                this.flowLayoutPanel_Aerobic.Controls.Add(c);
            });
        }

        private static CheckBox newCheckBox()
        {
            CheckBox c = new CheckBox();
            c.Appearance = Appearance.Button;
            c.Font = new Font("微軟正黑體", 16, FontStyle.Bold);
            c.FlatStyle = FlatStyle.Flat;
            c.BackColor = Color.Snow;
            c.FlatAppearance.CheckedBackColor = Color.MistyRose;
            c.FlatAppearance.MouseDownBackColor = Color.Pink;
            c.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            c.AutoSize = true;
            return c;
        }

        private void afterAerobicChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState == CheckState.Checked)
                _Aerobiclist.Add(int.Parse(((CheckBox)sender).Tag.ToString()));
            else
                _Aerobiclist.Remove(int.Parse(((CheckBox)sender).Tag.ToString()));

            if (_Aerobiclist.Count == 0)
                return;

        }

        private void afterCategoryChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState == CheckState.Checked)
                _Categorylist.Add(int.Parse(((CheckBox)sender).Tag.ToString()));
            else
                _Categorylist.Remove(int.Parse(((CheckBox)sender).Tag.ToString()));

            if (_Categorylist.Count == 0)
                return;

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            gymEntities gymEntities = new gymEntities();
            //選擇有氧 or 無氧課程
            var aerobicQuery = gymEntities.tclasses
                            .Where(aerobic => _Aerobiclist.Contains((int)aerobic.class_sort1_id));


            //選擇課程類別
            var categoryQuery = gymEntities.tclasses
                            .Where(category => _Categorylist.Contains((int)category.class_sort2_id));

            var intersections = aerobicQuery.Intersect(categoryQuery);
            var finalQuery = from intersection in intersections
                             join aerobic in gymEntities.tclass_sort_有氧
                             on intersection.class_sort1_id equals aerobic.class_sort1_id
                             join category in gymEntities.tclass_sort_訓練
                             on intersection.class_sort2_id equals category.class_sort2_id
                             select new
                             {
                                 課程照片 = intersection.class_photo,
                                 課程名稱 = intersection.class_name,
                                 運動類型 = aerobic.class_sort1_detail,
                                 課程種類 = category.class_sort2_detail,
                                 介紹 = intersection.class_introduction
                             };
            //如果[有氧無氧]與[課程類型]的交集為null，就顯示全部課程
            //if (finalQuery.ToList().Count == 0)
            //{
            //    var another = from alls in gymEntities.@class select alls;
            //    this.dataGridView_Test.DataSource = another.ToList();
            //    return;
            //}
            this.flowLayoutPanel_Course.Controls.Clear();
            foreach (var final in finalQuery)
            {
                UCMember_FindCourse box = new UCMember_FindCourse();
                box.btnReserve.Click += this.clickReserve;
                box.btnReserve.Tag = box.courseName = final.課程名稱;
                box.courseIntro = final.介紹;
                box.coursePhoto = final.課程照片;
                this.flowLayoutPanel_Course.Controls.Add(box);
            }
        }

        private void clickReserve(object sender, EventArgs e)
        {
            string course = ((Button)sender).Tag.ToString();
            FrmMember_FindClassAndReserve frmMember_CourseReservation = new FrmMember_FindClassAndReserve();
            frmMember_CourseReservation.member = this.member;
            frmMember_CourseReservation.course = course;
            frmMember_CourseReservation.StartPosition = FormStartPosition.CenterScreen;
            frmMember_CourseReservation.ShowDialog();
        }
    }
}
