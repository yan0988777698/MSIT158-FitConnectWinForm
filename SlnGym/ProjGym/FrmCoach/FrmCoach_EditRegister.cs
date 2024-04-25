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
    public delegate void DCoachEdit(tIdentity MM);

    public partial class FrmCoach_EditRegister : Form
    {
        gymEntities _gymEntity = new gymEntities();
        public event DCoachEdit afterEdit;
        List<int> _expertise = new List<int>();
        public tIdentity coach { get; set; }
        private string _filename = string.Empty;
        private string _ImagePath = string.Empty;
        public TextBox name { get { return this.tb_Name; } }
        public ComboBox gender { get { return this.cb_Gender; } }
        public TextBox phone { get { return this.tb_Phone; } }
        public DateTimePicker birth { get { return this.dateTimePicker_Birth; } }
        public TextBox mail { get { return this.tb_Mail; } }
        public TextBox address { get { return this.tb_Address; } }
        public TextBox password { get { return this.tb_Password; } }
        public PictureBox photo { get { return this.pb_Photo; } }
        public ComboBox expertise { get { return this.cb_Expertise; } }
        public Button save { get { return this.btn_Save; } }
        public Button cancel { get { return this.btn_Cancel; } }
        public FrmCoach_EditRegister()
        {
            InitializeComponent();
            cb_Gender.Items.Clear();
            var genders = from gender in _gymEntity.tgender_Table select gender;
            genders.ToList().ForEach(gender => { cb_Gender.Items.Add(gender.gender_text); });
            var experts = from expert in _gymEntity.tclasses select expert;
            experts.ToList().ForEach(expert => { cb_Expertise.Items.Add(expert.class_name); });
        }

        private void pb_Photo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "照片|*.jpeg;*.jpg;*.png";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            _filename = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            string path = Application.StartupPath + "\\CoachImages";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            File.Copy(openFileDialog1.FileName, path + "\\" + _filename);

            pb_Photo.Image = new Bitmap(path + "\\" + _filename);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool hasError = checkError();
            if (hasError) return;
            int index = this.coach.id;
            tIdentity identity = _gymEntity.tIdentity.FirstOrDefault(x => x.id == index);
            identity.name = this.tb_Name.Text;
            identity.gender_id = this.cb_Gender.SelectedIndex + 1;
            identity.phone = this.tb_Phone.Text;
            identity.birthday = this.dateTimePicker_Birth.Value.Date;
            identity.e_mail = this.tb_Mail.Text;
            identity.password = this.tb_Password.Text;
            identity.address = this.tb_Address.Text;
            identity.photo = this._filename;

            tcoach_info_id tcoach_Info = _gymEntity.tcoach_info_id.FirstOrDefault(x => x.coach_id == identity.id);
            tcoach_Info.coach_intro = this.tb_Intro.Text;

            var expertises = from expertise in _gymEntity.tcoach_expert
                             where expertise.coach_id == index
                             select expertise;
            foreach (var expertise in expertises)
            {
                _gymEntity.tcoach_expert.Remove(expertise);
            }
            foreach (int _ex in _expertise)
            {
                tcoach_expert expert = new tcoach_expert();
                expert.coach_id = identity.id;
                expert.class_id = _ex;
                _gymEntity.tcoach_expert.Add(expert);
            }
            _gymEntity.SaveChanges();
            MessageBox.Show("資料已成功儲存");
            if (afterEdit != null)
                afterEdit(identity);
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

        private void FrmCoach_EditRegister_Load(object sender, EventArgs e)
        {
            int index = this.coach.id;
            tIdentity identity = _gymEntity.tIdentity.FirstOrDefault(x => x.id == index);
            this.tb_Name.Text = identity.name;
            this.cb_Gender.SelectedIndex = identity.gender_id - 1;
            this.tb_Phone.Text = identity.phone;
            this.dateTimePicker_Birth.Text = identity.birthday.ToString();
            this.tb_Mail.Text = identity.e_mail;
            this.tb_Address.Text = identity.address;
            this.tb_Password.Text = identity.password;
            this._filename = identity.photo;

            var expertises = from expertise in _gymEntity.tcoach_expert
                             where expertise.coach_id == index
                             select expertise;
            expertises.ToList().ForEach(expertise => this.cb_Expertise.SelectedIndex = expertise.class_id - 1);
            tcoach_info_id coach_Info = _gymEntity.tcoach_info_id.FirstOrDefault(x => x.coach_id == index);
            if (coach_Info != null)
                tb_Intro.Text = coach_Info.coach_intro;

            if (!string.IsNullOrEmpty(_filename))
            {
                string fullpath = Application.StartupPath + "\\CoachImages\\" + _filename;
                this.pb_Photo.Image = new Bitmap(fullpath);
            }
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
