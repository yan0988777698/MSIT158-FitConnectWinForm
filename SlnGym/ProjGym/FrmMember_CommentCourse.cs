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
    public partial class FrmMember_CommentCourse : Form
    {
        gymEntities _gymEntities = new gymEntities();
        public tIdentity member { get; set; }
        public int _classReserveID { get; set; }
        public int _coachID { get; set; }
        public FrmMember_CommentCourse()
        {
            InitializeComponent();
            lbl_EvaluateCoachError.Text = string.Empty;
            lbl_EvaluateCourseError.Text = string.Empty;
            lbl_CommentCoach.Text = string.Empty;
            lbl_CommentCourse.Text = string.Empty;

        }

        private void tb_EvaluateCoach_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_EvaluateCoachError.Text = string.Empty;
            //只能使用數字小數點及刪除鍵
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // 只允許一個小數點
            if ((e.KeyChar == '.') && (tb_EvaluateCoach.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void tb_EvaluateCoach_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                // 轉成浮點數
                if (!float.TryParse(textBox.Text, out float value))
                {
                    lbl_EvaluateCoachError.Text = "✘ 請輸入有效數字";
                    lbl_EvaluateCoachError.ForeColor = Color.Red;
                    e.Cancel = true;
                    return;
                }

                // 檢查範圍是否在1.0到5.0之間
                if (value < 1.0f || value > 5.0f)
                {
                    lbl_EvaluateCoachError.Text = "✘ 請輸入1.0到5.0之間的數字";
                    lbl_EvaluateCoachError.ForeColor = Color.Red;
                    e.Cancel = true;
                    return;
                }
                if (value.ToString().Count() > 3)
                {
                    lbl_EvaluateCoachError.Text = "✘ 小數點後僅可輸入一位數字";
                    lbl_EvaluateCoachError.ForeColor = Color.Red;
                    e.Cancel = true;
                    return;
                }
                lbl_EvaluateCoachError.Text = "✔";
                lbl_EvaluateCoachError.ForeColor = Color.Green;
            }

        }


        private void tb_EvaluateCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_EvaluateCourseError.Text = string.Empty;
            //只能使用數字小數點及刪除鍵
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // 只允許一個小數點
            if ((e.KeyChar == '.') && (tb_EvaluateCourse.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void tb_EvaluateCourse_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                // 轉成浮點數
                if (!float.TryParse(textBox.Text, out float value))
                {
                    lbl_EvaluateCourseError.Text = "✘ 請輸入有效數字";
                    lbl_EvaluateCourseError.ForeColor = Color.Red;
                    e.Cancel = true;
                    return;
                }

                // 檢查範圍是否在1.0到5.0之間
                if (value < 1.0f || value > 5.0f)
                {
                    lbl_EvaluateCourseError.Text = "✘ 請輸入1.0到5.0之間的數字";
                    lbl_EvaluateCourseError.ForeColor = Color.Red;
                    e.Cancel = true;
                    return;
                }
                if (value.ToString().Count() > 3)
                {
                    lbl_EvaluateCourseError.Text = "✘ 小數點後僅可輸入一位數字";
                    lbl_EvaluateCourseError.ForeColor = Color.Red;
                    e.Cancel = true;
                    return;
                }
                lbl_EvaluateCourseError.Text = "✔";
                lbl_EvaluateCourseError.ForeColor = Color.Green;
            }
        }

        private void tb_CommentCoach_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                lbl_CommentCoach.Text = string.Empty;
                return;
            }
            if (textBox.Text.Length == 300)
            {
                lbl_CommentCoach.ForeColor = Color.Red;
                lbl_CommentCoach.Text = $"剩餘可輸入字數:{300 - textBox.Text.Length}";
            }
            else
            {
                lbl_CommentCoach.ForeColor = Color.Green;
                lbl_CommentCoach.Text = $"剩餘可輸入字數:{300 - textBox.Text.Length}";
            }

        }


        private void tb_CommentCourse_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                lbl_CommentCourse.Text = string.Empty;
                return;
            }
            if (textBox.Text.Length == 300)
            {
                lbl_CommentCourse.ForeColor = Color.Red;
                lbl_CommentCourse.Text = $"剩餘可輸入字數:{300 - textBox.Text.Length}";
            }
            else
            {
                lbl_CommentCourse.ForeColor = Color.Green;
                lbl_CommentCourse.Text = $"剩餘可輸入字數:{300 - textBox.Text.Length}";
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_CommentCoach.Text) || string.IsNullOrEmpty(tb_CommentCourse.Text) || string.IsNullOrEmpty(tb_EvaluateCoach.Text) || string.IsNullOrEmpty(tb_EvaluateCourse.Text))
            {
                MessageBox.Show("請將內容填寫完整", "評分提交通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //TODO: 檢查是否已經寫入資料庫
            if(_gymEntities.tmember_rate_class.FirstOrDefault(x=>x.reserve_id == this._classReserveID && x.member_id == this.member.id) != null)
            {
                MessageBox.Show("您已經評價過此課程及教練囉!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            tmember_rate_class member_Rate_Class = new tmember_rate_class();
            member_Rate_Class.reserve_id = this._classReserveID;
            member_Rate_Class.member_id = this.member.id;
            member_Rate_Class.class_id = _gymEntities.tclass_reserve.FirstOrDefault(x => x.reserve_id == _classReserveID).tclass_schedule.tclasses.class_id;
            member_Rate_Class.coach_id = this._coachID;
            member_Rate_Class.rate_coach = Convert.ToDecimal(this.tb_EvaluateCoach.Text);
            member_Rate_Class.coach_describe = this.tb_CommentCoach.Text;
            member_Rate_Class.rate_class = Convert.ToDecimal(this.tb_EvaluateCourse.Text);
            member_Rate_Class.class_describe = this.tb_CommentCourse.Text;
            _gymEntities.tmember_rate_class.Add(member_Rate_Class);
            _gymEntities.SaveChanges();
            this.Close();
        }

        private void FrmMember_CommentCourse_Load(object sender, EventArgs e)
        {

            _coachID = _gymEntities.tclass_reserve.FirstOrDefault(x => x.reserve_id == _classReserveID).tclass_schedule.coach_id;
            lbl_tag.Text = $"會員ID:{member.id} | 教練ID:{_coachID} | 課程預約序號:{_classReserveID}";
        }
    }
}
