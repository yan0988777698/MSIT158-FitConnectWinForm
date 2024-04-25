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
    public partial class FrmMember_CourseCart : Form
    {
        public tIdentity member { get; set; }
        gymEntities _gymEntities = new gymEntities();
        int _numberOfCourses = 0;
        int _totalPrice = 0;
        public Darg0 goBack;
        public FrmMember_CourseCart()
        {
            InitializeComponent();
        }

        private void FrmMember_CheckCourseReservation_Load(object sender, EventArgs e)
        {
            showReservedCourse();
        }

        private void showReservedCourse()
        {
            this.flowLayoutPanel_ReservedCourseList.Controls.Clear();
            var reserves = from reserve in _gymEntities.tclass_reserve
                           where reserve.tIdentity.name.Equals(this.member.name) 
                           && reserve.payment_status == false
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
            try
            {
                if (!reserves.Any())
                {
                    this.flowLayoutPanel_ReservedCourseList.BackgroundImage = new Bitmap(Application.StartupPath + "\\cry.png");
                    this.flowLayoutPanel_ReservedCourseList.BackgroundImageLayout = ImageLayout.Stretch;
                    _numberOfCourses = _totalPrice = 0;
                    return;
                }
                _numberOfCourses = _totalPrice = 0;
                bool Odd = true;
                foreach (var reserve in reserves)
                {
                    UCMember_ReservedCourse reservedCourse = new UCMember_ReservedCourse();
                    if (Odd)
                        reservedCourse.BackColor = Color.White;
                    else
                        reservedCourse.BackColor = Color.LightGray;
                    reservedCourse.coach = reserve.教練;
                    reservedCourse.date = reserve.日期.ToString("yyyy/MM/dd");
                    reservedCourse.time = reserve.時段.ToString();
                    reservedCourse.field = reserve.場地;
                    reservedCourse.pay = reserve.金額.ToString("C0");
                    reservedCourse.cancel.Click += Cancel_Click;
                    reservedCourse.cancel.Tag = reserve.流水號;
                    this.flowLayoutPanel_ReservedCourseList.Controls.Add(reservedCourse);
                    _numberOfCourses++;
                    _totalPrice += Convert.ToInt16(reserve.金額);
                    Odd = !Odd;
                }
            }
            finally
            {
                lbl_Cart.Text = $"課程購物車({_numberOfCourses})";
                lbl_TotalPrice.Text = $"總價: NT{_totalPrice}";
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定取消課程?", "通知", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int courseID = Convert.ToInt32(((Button)sender).Tag);
                tclass_reserve deleted = _gymEntities.tclass_reserve.FirstOrDefault(x => x.reserve_id == courseID);
                _gymEntities.tclass_reserve.Remove(deleted);
                _gymEntities.SaveChanges();
                this.flowLayoutPanel_ReservedCourseList.Controls.Clear();
                showReservedCourse();
            }
            else
                return;
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            if(goBack!=null)
                goBack();
            this.Close();
        }

        private void btn_GoPay_Click(object sender, EventArgs e)
        {
            if(_numberOfCourses == 0)
            {
                MessageBox.Show("您還沒有預約任何課程喔","訊息",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            FrmMember_GoPay frmMember_GoPay = new FrmMember_GoPay();
            frmMember_GoPay.afterPay = this.purchaseCourse;
            frmMember_GoPay.afterClose = this.hideCover;
            frmMember_GoPay.member = this.member;
            frmMember_GoPay.courseNumber = this._numberOfCourses;
            frmMember_GoPay.totalPrice = this._totalPrice;

            frmMember_GoPay.TopLevel = false;
            frmMember_GoPay.FormBorderStyle = FormBorderStyle.None;
            frmMember_GoPay.Dock = DockStyle.Fill;
            frmMember_GoPay.Visible = true;
            this.panel_PayPage.Controls.Add(frmMember_GoPay);

            this.pb_Cover.Visible = true;
        }

        private void purchaseCourse()
        {
            var reserves = from reserve in _gymEntities.tclass_reserve
                           where reserve.tIdentity.name.Equals(this.member.name)
                           && reserve.payment_status == false
                           && reserve.reserve_status == true
                           select reserve;
            foreach ( var reserve in reserves )
            {
                reserve.payment_status = true;
            }
            _gymEntities.SaveChanges();
            showReservedCourse();
        }

        private void hideCover()
        {
            this.pb_Cover.Visible = false;
        }
    }
}
