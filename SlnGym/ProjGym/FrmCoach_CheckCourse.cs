using ProjGym.使用者控制項;
using System;
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
    public partial class FrmCoach_CheckCourse : Form
    {
        private gymEntities _gymEntities = new gymEntities();
        public tIdentity member { get; set; }
        public FrmCoach_CheckCourse()
        {
            InitializeComponent();
        }

        private void FrmCoach_CheckCourse_Load(object sender, EventArgs e)
        {
            var schedules = from schedule in _gymEntities.tclass_schedule
                            where schedule.coach_id == member.id
                            select schedule;
            schedules.ToList().ForEach(schedule =>
            {
                UCCoach_OpenedCourse openedCourse = new UCCoach_OpenedCourse();
                openedCourse.coursename = schedule.tclasses.class_name;
                openedCourse.maxStudent = $"{schedule.Max_student}人";
                openedCourse.field = $"{schedule.tfield.field_name}({schedule.tfield.floor})";
                openedCourse.date = schedule.course_date.Date.ToString("yyyy/MM/dd");
                openedCourse.time = schedule.ttimes_detail.time_name.ToString();
                this.flowLayoutPanel_OpenedCourse.Controls.Add(openedCourse);
            });
        }
    }
}
