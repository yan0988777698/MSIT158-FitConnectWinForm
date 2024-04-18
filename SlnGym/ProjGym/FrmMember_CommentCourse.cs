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
        public FrmMember_CommentCourse()
        {
            InitializeComponent();
            lbl_EvaluateCoachError.Text = string.Empty;
            lbl_EvaluateCourseError.Text = string.Empty;
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
            lbl_CommentCourse.ForeColor = Color.Green;
            lbl_CommentCourse.Text = $"剩餘可輸入字數:{300 - textBox.Text.Length}";
        }
    }
}
