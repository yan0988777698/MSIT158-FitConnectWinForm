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
        public FrmCoach_NewRegister()
        {
            InitializeComponent();
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
        }

        private void FrmCoach_NewRegister_Load(object sender, EventArgs e)
        {
            cb_Gender.Items.Clear();

            var genders = from gender in _gymEntities.tgender_Table select gender;
            genders.ToList().ForEach(gender => { cb_Gender.Items.Add(gender.gender_text); });

            cb_Expertise.Items.Clear();
            var expertises = from expertise in _gymEntities.tclasses select expertise;
            expertises.ToList().ForEach(expertise => { cb_Expertise.Items.Add(expertise.class_name); });
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
            return hasError;
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
    }
}
