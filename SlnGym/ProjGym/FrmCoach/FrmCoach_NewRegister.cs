using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjGym
{
    public partial class FrmCoach_NewRegister : Form
    {
        string _filename = string.Empty;
        gymEntities _gymEntities = new gymEntities();
        List<int> _expertise = new List<int>();
        bool _stop = false;
        public FrmCoach_NewRegister()
        {
            InitializeComponent();
            tb_Password.PasswordChar = '●';
            tb_Recheck.PasswordChar = '●';
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_Photo_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "圖片|*.jpeg;*.jpg;*.png";
            if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            string path = Application.StartupPath + "\\CoachImages";
            _filename = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            File.Copy(this.openFileDialog1.FileName, path + "\\" + _filename);
            pb_Photo.Image = new Bitmap(path + "\\" + _filename);
            lblPhoto.Text = "";
        }

        private void FrmCoach_NewRegister_Load(object sender, EventArgs e)
        {
            cb_Gender.Items.Clear();

            var genders = from gender in _gymEntities.tgender_Table select gender;
            genders.ToList().ForEach(gender => { cb_Gender.Items.Add(gender.gender_text); });

            cb_Expertise.Items.Clear();
            var expertises = from expertise in _gymEntities.tclasses select expertise;
            expertises.ToList().ForEach(expertise => { cb_Expertise.Items.Add(expertise.class_name); });

            var cities = from city in _gymEntities.tcity select city;
            cities.ToList().ForEach(city => { cb_city.Items.Add(city.city); });
            cb_city.SelectedIndexChanged += cb_city_SelectedIndexChanged;
        }
        private void cb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_region.Items.Clear();


            // 獲取選擇的city名稱
            string selectedCity = cb_city.SelectedItem.ToString();

            if (selectedCity != null)
            {
                // 根據選擇的city查詢對應的region
                var regions = from region in _gymEntities.tregion_table
                              where region.city_id == _gymEntities.tcity.FirstOrDefault(c => c.city == selectedCity).city_id
                              select region;

                regions.ToList().ForEach(region => { cb_region.Items.Add(region.region); });
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            bool hasError = checkError();
            if (hasError) return;
            tIdentity identity = new tIdentity();
            identity.name = this.tb_Name.Text;
            identity.role_id = 2;
            identity.gender_id = this.cb_Gender.SelectedIndex + 1;
            identity.phone = this.tb_Phone.Text;
            identity.birthday = this.dateTimePicker_Birth.Value.Date;
            identity.address = this.tb_Address.Text;
            identity.e_mail = this.tb_Mail.Text;
            identity.password = this.tb_Password.Text;
            identity.photo = _filename;
            _gymEntities.tIdentity.Add(identity);

            foreach(int _ex in _expertise)
            {
                tcoach_expert expert = new tcoach_expert();
                expert.coach_id = identity.id;
                expert.class_id = _ex;
                _gymEntities.tcoach_expert.Add(expert);
            }  

            tcoach_info_id info = new tcoach_info_id();
            info.coach_id = identity.id;
            info.coach_intro = this.tb_Intro.Text;
            _gymEntities.tcoach_info_id.Add(info);

            _gymEntities.SaveChanges();
            MessageBox.Show("註冊成功，請使用電話/信箱 + 密碼登入");
            this.Close();
        }

        private bool checkError()
        {
            bool hasError = false;
            hideError();
            string passwordPattern = @"^(?=.*[a-z])(?=.*\d).{8,}$";
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regexPassword = new Regex(passwordPattern);
            Regex regexEmail = new Regex(emailPattern);

            if (string.IsNullOrEmpty(tb_Name.Text))
            {
                hasError = true; pb_ErrorName.Visible = true;
            }
            if (cb_Gender.SelectedIndex == -1)
            {
                hasError = true; pb_ErrorGender.Visible = true;
            }
            if (string.IsNullOrEmpty(tb_Phone.Text))
            {
                hasError = true; pb_ErrorPhone.Visible = true;
            }
            if ((DateTime.Now.Year - dateTimePicker_Birth.Value.Year) < 18)
            {
                hasError = true; pb_ErrorBirth.Visible = true;
            }
            if (string.IsNullOrEmpty(tb_Address.Text))
            {
                hasError = true; pb_ErrorAddress.Visible = true;
            }
            if (!regexEmail.IsMatch(tb_Mail.Text))
            {
                hasError = true; pb_ErrorMail.Visible = true;
            }
            if (string.IsNullOrEmpty(tb_Password.Text))
            {
                hasError = true; pb_ErrorPassword.Visible = true;
            }
            if (!regexPassword.IsMatch(tb_Password.Text))
            {
                hasError = true; pb_ErrorPassword.Visible = true;
            }
            if (_expertise.Count == 0)
            {
                hasError = true; pb_ErrorExpertise.Visible = true;
            }
            if (string.IsNullOrEmpty(tb_Intro.Text))
            {
                hasError = true; pb_ErrorIntro.Visible = true;
            }
            if (string.IsNullOrEmpty(tb_Recheck.Text))
            {
                hasError = true; pb_ErrorRecheck.Visible = true;
            }
            if (pb_Photo.Image == null)
            {
                hasError = true; lblPhoto.Visible = true;
            }
            else
            {
                lblPhoto.Visible = false;
            }
            //檢查歲數是否超過18
            if (checkAge())
            {
                hasError = true;
            }
            return hasError;
        }
        private bool checkAge()
        {
            DateTime birthDate = dateTimePicker_Birth.Value;
            DateTime currentDate = DateTime.Now;

            // 年齡不可以是未來日期
            while (birthDate > currentDate)
            {
                MessageBox.Show("生日日期不能大於當前日期！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            // 年齡不可小於18歲
            int age = currentDate.Year - birthDate.Year;
            if (currentDate < birthDate.AddYears(age))
            {
                age--;
            }
            if (age < 14)
            {
                MessageBox.Show("Sorry, 你的年齡還太小了喔!", "真可惜", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (age >= 14 && age <= 18)
            {
                MessageBox.Show("教練需要年滿18歲，您可以由法定代理人代理申請，成為會員！", "下次再來", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void hideError()
        {
            pb_ErrorName.Visible = pb_ErrorGender.Visible = pb_ErrorPhone.Visible = pb_ErrorBirth.Visible = pb_ErrorAddress.Visible = pb_ErrorMail.Visible = pb_ErrorPassword.Visible = pb_ErrorExpertise.Visible = pb_ErrorIntro.Visible = false;
        }

        private void cb_Expertise_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex + 1;
            if (_expertise.Contains(index)) return;
            _expertise.Add(index);
            Button btn = new Button();
            btn.BackColor = Color.PapayaWhip;
            btn.FlatStyle = FlatStyle.Flat;
            btn.AutoSize = true;
            btn.Tag = index;
            btn.Text = "✘ " + ((ComboBox)sender).SelectedItem.ToString();
            btn.Click += delete;
            flowLayoutPanel_Exp.Controls.Add(btn);
        }

        private void delete(object sender, EventArgs e)
        {
            flowLayoutPanel_Exp.Controls.Remove((Button)sender);
            _expertise.Remove((int)((Button)sender).Tag);
        }
        //再次確認密碼
        private void tb_Recheck_TextChanged(object sender, EventArgs e)
        {
            string p1 = tb_Password.Text;
            string p2 = tb_Recheck.Text;
            if (String.Equals(p1, p2))
            {
                lblRecheck.Text = "驗證通過";
                lblRecheck.ForeColor = Color.Green;
                Correct(lblRecheck);
            }
            else
            {
                lblRecheck.Text = "兩次密碼輸入不同，請再次確認";
                lblRecheck.ForeColor = Color.Red;
                UnCorrect(tb_Recheck, lblRecheck);
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

        //電話號碼審核
        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {
            string typePhone = tb_Phone.Text;
            bool flag = (Regex.IsMatch(typePhone, @"^09[0-9]{8}$"));
            //必須為09開頭，並且長度為10碼
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
        //電子信箱審核
        private void tb_Mail_TextChanged(object sender, EventArgs e)
        {
            string typeEmail = tb_Mail.Text;
            bool flag = (Regex.IsMatch(typeEmail, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"));
            //必須為___@____.___格式
            if (flag)
            {
                lblEmail.Text = "驗證通過";
                lblEmail.ForeColor = Color.Green;
                Correct(lblEmail);
            }
            else
            {
                lblEmail.Text = "請輸入正確格式之電子郵件";
                lblEmail.ForeColor = Color.Red;
                UnCorrect(tb_Mail, lblEmail);
            }
        }
        //密碼審核
        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            string typein = tb_Password.Text;
            bool flag = (Regex.IsMatch(typein, @"^(?=.*[a-zA-Z])(?=.*\d).{10,}$"));//正則表達式
                                                                              //必須包含英文字母和數字的組合，長度在10以上(英文字母不分大小寫)
            if (flag)
            {
                lblPassword.Text = "此密碼符合條件";
                lblPassword.ForeColor = Color.Green;
                Correct(lblPassword);

            }
            else if (tb_Password.Text.Length < 10)
            {
                lblPassword.Text = "您的密碼長度應大於10碼";
                lblPassword.ForeColor = Color.Red;
                UnCorrect(tb_Password, lblPassword);
            }
            else if (!flag)
            {
                lblPassword.Text = "您的密碼應同時包含至少一個英文字母及數字";
                lblPassword.ForeColor = Color.Red;
                UnCorrect(tb_Password, lblPassword);
            }
        }

        private void cb_hide1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hide1.Checked) { tb_Password.PasswordChar = '\0'; }
            else { tb_Password.PasswordChar = '●'; }
        }

        private void cb_hide2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hide2.Checked) { tb_Recheck.PasswordChar = '\0'; }
            else { tb_Recheck.PasswordChar = '●'; }
        }
        //顯示密碼
    }
}
