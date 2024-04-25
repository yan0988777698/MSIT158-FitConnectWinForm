using ProjGym.使用者控制項;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjGym
{
    public partial class FrmMember_CourseHistory : Form
    {
        public tIdentity member { get; set; }
        gymEntities _gymEntities = new gymEntities();
        int _numberOfCourses = 0;
        public FrmMember_CourseHistory()
        {
            InitializeComponent();
        }

        private void FrmMember_CourseHistory_Load(object sender, EventArgs e)
        {
            showHistoryCourse();
        }

        private void showHistoryCourse()
        {
            var reserves = from reserve in _gymEntities.tclass_reserve
                           where reserve.tIdentity.name.Equals(this.member.name)
                           && reserve.payment_status == true
                           && reserve.reserve_status == true
                           select new
                           {
                               流水號 = reserve.reserve_id,
                               課程名稱 = reserve.tclass_schedule.tclasses.class_name,
                               教練 = _gymEntities.tIdentity.FirstOrDefault(x => x.id == reserve.tclass_schedule.coach_id).name,
                               日期 = reserve.tclass_schedule.course_date,
                               時段 = reserve.tclass_schedule.ttimes_detail.time_name,
                               場地 = reserve.tclass_schedule.tfield.field_name,
                               金額 = reserve.tclass_schedule.class_payment,
                           };

            if (!reserves.Any())
            {
                this.flowLayoutPanel_History.BackgroundImage = new Bitmap(Application.StartupPath + "\\cry.png");
                this.flowLayoutPanel_History.BackgroundImageLayout = ImageLayout.Stretch;
                lbl_History.Text = $"歷史課程清單(0)";
                return;
            }

            bool Odd = true;
            foreach (var reserve in reserves)
            {
                UCMember_HistoryCourse uCMember_HistoryCourse = new UCMember_HistoryCourse();
                if (Odd)
                    uCMember_HistoryCourse.BackColor = Color.White;
                else
                    uCMember_HistoryCourse.BackColor = Color.LightGray;
                uCMember_HistoryCourse.coach = reserve.教練;
                uCMember_HistoryCourse.date = reserve.日期.ToString("yyyy/MM/dd");
                uCMember_HistoryCourse.time = reserve.時段.ToString();
                uCMember_HistoryCourse.field = reserve.場地;
                uCMember_HistoryCourse.pay = reserve.金額.ToString("C0");

                uCMember_HistoryCourse.like.Tag = reserve.流水號;
                uCMember_HistoryCourse.comment.Tag = reserve.流水號;
                uCMember_HistoryCourse.comment.Click += comment;
                uCMember_HistoryCourse.dislike.Tag = reserve.流水號;
                this.flowLayoutPanel_History.Controls.Add(uCMember_HistoryCourse);
                Odd = !Odd;
                _numberOfCourses++;
            }
            lbl_History.Text = $"歷史課程清單({_numberOfCourses})";
        }

        private void comment(object sender, EventArgs e)
        {
            Button btn_comment = (Button)sender;
            FrmMember_CommentCourse frmMember_CommentCourse = new FrmMember_CommentCourse();
            frmMember_CommentCourse.StartPosition = FormStartPosition.CenterScreen;
            frmMember_CommentCourse.member = this.member;
            frmMember_CommentCourse._classReserveID = Convert.ToInt32(btn_comment.Tag);
            frmMember_CommentCourse.ShowDialog();
        }
    }
}
