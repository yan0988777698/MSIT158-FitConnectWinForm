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
    public partial class FrmMember_FindClassAndReserve : Form
    {
        List<int> _Classlist = new List<int>();
        List<DateTime> _Preiod = new List<DateTime>();
        gymEntities _gymEntities = new gymEntities();
        DataGridViewButtonColumn _buttonColumn = new DataGridViewButtonColumn();
        public tIdentity member { get; set; }
        public string course { get; set; }
        public FrmMember_FindClassAndReserve()
        {
            InitializeComponent();
        }

        private void FrmCurriculum_Load(object sender, EventArgs e)
        {

            var courses = from schedule in _gymEntities.tclass_schedule.AsEnumerable()
                          where schedule.tclasses.class_name.Equals(course)
                          select new
                          {
                              流水號 = schedule.class_schedule_id,
                              課程種類 = schedule.tclasses.class_name,
                              教練 = schedule.tIdentity.name,
                              場地 = schedule.tfield.field_name,
                              日期 = schedule.course_date,
                              時段 = schedule.ttimes_detail.time_name,
                              人數上限 = schedule.Max_student,
                              課程費用 = schedule.class_payment.ToString("C0"),
                          };

            formatDataGridView(dataGridView_Reserve);

            addButtonColumnIntoView();

            this.dataGridView_Reserve.DataSource = courses.ToList();
        }

        private void addButtonColumnIntoView()
        {
            _buttonColumn.HeaderText = "操作";
            _buttonColumn.Text = "預約";
            _buttonColumn.UseColumnTextForButtonValue = true; // 設置按鈕文本
            _buttonColumn.DefaultCellStyle.Padding = new Padding(2, 1, 2, 1);
            _buttonColumn.DefaultCellStyle.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
            dataGridView_Reserve.Columns.Add(_buttonColumn);
        }

        private void formatDataGridView(DataGridView view)
        {
            view.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
            view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            view.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dataGridView_Reserve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView_Reserve.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                bool haveQuota = checkQuota(sender, e);
                if (haveQuota)
                {

                    int index = (int)this.dataGridView_Reserve.Rows[e.RowIndex].Cells[1].Value;
                    tclass_reserve reserve = new tclass_reserve();
                    reserve.class_schedule_id = index;
                    reserve.member_id = member.id;
                    reserve.payment_status = false;
                    reserve.reserve_status = true;
                    _gymEntities.tclass_reserve.Add(reserve);
                    _gymEntities.SaveChanges();
                    showInfo(sender, e);
                    MessageBox.Show("預約成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    showInfo(sender, e);
                    MessageBox.Show("課程人數已滿，無法預約", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void showInfo(object sender, DataGridViewCellEventArgs e)
        {
            int index = (int)this.dataGridView_Reserve.Rows[e.RowIndex].Cells[1].Value;
            var quotas = from quota in _gymEntities.tclass_reserve
                         where quota.class_schedule_id == index
                         group quota by quota.class_schedule_id into g
                         select new
                         {
                             流水號 = g.Key,
                             已預約人數 = g.Count()
                         };

            formatDataGridView(dataGridView_ClassInfo);
            this.dataGridView_ClassInfo.DataSource = quotas.ToList();
        }

        private bool checkQuota(object sender, DataGridViewCellEventArgs e)
        {
            int index = (int)this.dataGridView_Reserve.Rows[e.RowIndex].Cells[1].Value;
            var quotas = from quota in _gymEntities.tclass_reserve
                         where quota.class_schedule_id == index
                         group quota by quota.class_schedule_id into g
                         select new
                         {
                             流水號 = g.Key,
                             已預約人數 = g.Count()
                         };
            if (quotas.ToList().Count == 0)
                return true;
            int max = _gymEntities.tclass_schedule.FirstOrDefault(x => x.class_schedule_id == index).Max_student;
            int reserved = quotas.FirstOrDefault().已預約人數;
            if (reserved < max)
                return true;
            else
                return false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            var courses = from schedule in _gymEntities.tclass_schedule.AsEnumerable()
                          where schedule.tclasses.class_name.Equals(course)
                          select new
                          {
                              流水號 = schedule.class_schedule_id,
                              課程種類 = schedule.tclasses.class_name,
                              教練 = schedule.tIdentity.name,
                              場地 = schedule.tfield.field_name,
                              日期 = schedule.course_date,
                              時段 = schedule.ttimes_detail.time_name,
                              人數上限 = schedule.Max_student,
                              課程費用 = schedule.class_payment.ToString("C0"),
                          };
            formatDataGridView(dataGridView_Reserve);
            this.dataGridView_Reserve.DataSource = courses.ToList();
        }

        private void dateTimePicker_Start_ValueChanged(object sender, EventArgs e)
        {
            //TODO:按下篩選時，若沒有任何資料，還是會出現button column
            DateTime start = this.dateTimePicker_Start.Value.Date;

            var queries = from query in _gymEntities.tclass_schedule.AsEnumerable()
                          where query.course_date >= start.Date
                          && query.tclasses.class_name == course
                          select new
                          {
                              流水號 = query.class_schedule_id,
                              課程種類 = query.tclasses.class_name,
                              教練 = query.tIdentity.name,
                              場地 = query.tfield.field_name,
                              日期 = query.course_date,
                              時段 = query.ttimes_detail.time_name,
                              人數上限 = query.Max_student,
                              課程費用 = query.class_payment.ToString("C0"),
                          };


            if (queries.ToList().Count == 0)
            {
                _buttonColumn.Visible = false;
                this.dataGridView_Reserve.DataSource = null;
            }
            else
            {
                _buttonColumn.Visible = true;
                this.dataGridView_Reserve.DataSource = queries.ToList();
            }
        }
    }
}
