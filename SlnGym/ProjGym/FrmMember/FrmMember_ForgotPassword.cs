using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjGym.FrmMember
{
    public partial class FrmMember_ForgotPassword : Form
    {
        gymEntities _gymEntities = new gymEntities();
        bool _stop = false;
        public FrmMember_ForgotPassword()
        {
            InitializeComponent();
        }
        private void btn_ResetPassword_Click_1(object sender, EventArgs e)
        {
            string email = tb_Email.Text;
            string phone = tb_Phone.Text;

            tIdentity user = _gymEntities.tIdentity.FirstOrDefault(x => x.e_mail == email && x.phone == phone);

            if (user != null)
            {
                // 生成重設密碼連結的郵件給使用者
                // 未完成的功能
                MessageBox.Show("已發送重設密碼連結至您的郵箱，請查收。");
            }
            else
            {
                MessageBox.Show("電子信箱或手機號碼錯誤，請重新輸入。");
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Email_TextChanged(object sender, EventArgs e)
        {

            string typeEmail = tb_Email.Text;
            bool flag = (Regex.IsMatch(typeEmail, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"));
            if (flag)
            {
                lblEmail.Text = "格式正確";
                lblEmail.ForeColor = Color.Green;
                Correct(lblEmail);
            }
            else
            {
                lblEmail.Text = "請輸入正確格式之電子郵件";
                lblEmail.ForeColor = Color.Red;
                UnCorrect(tb_Email, lblEmail);

            }
        }
        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {
            string typePhone = tb_Phone.Text;
            bool flag = (Regex.IsMatch(typePhone, @"^09[0-9]{8}$"));
            if (flag)
            {
                lblPhone.Text = "格式正確";
                lblPhone.ForeColor = Color.Green;
                Correct(lblPhone);
            }
            else
            {
                lblPhone.Text = "請輸入正確格式之手機號碼";
                lblPhone.ForeColor = Color.Red;
                UnCorrect(tb_Phone, lblPhone);
            }
        }


        private void UnCorrect(System.Windows.Forms.TextBox t, System.Windows.Forms.Label l)
        {
            l.ForeColor = Color.Red;
            _stop = true;
            t.Focus();
            t.Select(t.TextLength, 1);
        }

        private void Correct(System.Windows.Forms.Label l)
        {
            l.ForeColor = Color.Green;
            _stop = false;
        }
    }
}
