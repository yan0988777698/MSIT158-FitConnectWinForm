using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;
namespace ProjGym
{
    public delegate void D(FrmMember_NewRegister frm);
    public partial class FrmMember_NewRegister : Form
    {
        string _filename = "";
        gymEntities _gymEntities = new gymEntities();
        public event D savedata;
        bool _stop = false;
        public string name { get { return this.tb_Name.Text.ToString(); } }
        public string gender { get { return this.cb_GenderList.SelectedItem.ToString(); } }
        public string phone { get { return this.tb_Phone.Text.ToString(); } }
        public string birth { get { return this.dateTimePicker_Birth.Text.ToString(); } }
        public string address { get { return this.tb_Address.Text.ToString(); } }
        public string mail { get { return this.tb_Mail.Text.ToString(); } }
        public string password { get { return this.tb_Password.Text.ToString(); } }
        public string file { get { return this._filename.ToString(); } }
        public DialogResult result { get; set; }
        public FrmMember_NewRegister()
        {
            InitializeComponent();
            tb_Password.PasswordChar = '●';
            tb_Recheck.PasswordChar = '●';
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool hasError = checkError();
            if (hasError) return;
            this.result = DialogResult.OK;
            if (this.savedata != null)
            {
                savedata(this);
            }
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
            if (cb_GenderList.SelectedIndex == -1)
            {
                hasError = true; pb_ErrorGender.Visible = true;
            }
            if (string.IsNullOrEmpty(tb_Phone.Text))
            {
                hasError = true; pb_ErrorPhone.Visible = true;
            }
            if ((DateTime.Now.Year - dateTimePicker_Birth.Value.Year) < 14)
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
            //檢查歲數是否超過14
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
            // 年齡不可小於14歲
            int age = currentDate.Year - birthDate.Year;
            if (currentDate < birthDate.AddYears(age))
            {
                age--;
            }
            if (age < 14)
            {
                MessageBox.Show("Sorry, 你的年齡還太小了喔!", "資格不符", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void hideError()
        {
            pb_ErrorName.Visible = pb_ErrorGender.Visible = pb_ErrorPhone.Visible = pb_ErrorBirth.Visible = pb_ErrorAddress.Visible = pb_ErrorMail.Visible = pb_ErrorPassword.Visible = pb_ErrorRecheck.Visible = false;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.result = DialogResult.No;
            this.Close();
        }

        private void pb_Photo_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "圖片|*.jpeg;*.jpg;*.png";
            if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            string path = Application.StartupPath + "\\MemberImages";
            _filename = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            File.Copy(this.openFileDialog1.FileName, path + "\\" + _filename);
            pb_Photo.Image = new Bitmap(path + "\\" + _filename);
        }

        private void FrmNewMemberRegister_Load(object sender, EventArgs e)
        {
            cb_GenderList.Items.Clear();

            var genders = from gender in _gymEntities.tgender_Table select gender;
            genders.ToList().ForEach(gender => { cb_GenderList.Items.Add(gender.gender_text); });
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
        private void UnCorrect(TextBox textbox, Label label)
        {
            label.ForeColor = Color.Red;
            _stop = true;
            textbox.Focus();
            textbox.Select(textbox.TextLength, 1);
        }

        private void Correct(Label label)
        {
            label.ForeColor = Color.Green;
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
                Correct(lblPhone);
            }
            else
            {
                lblPhone.Text = "請輸入正確格式之手機號碼";
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
                Correct(lblEmail);
            }
            else
            {
                lblEmail.Text = "請輸入正確格式之電子郵件";
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
                Correct(lblPassword);

            }
            else if (tb_Password.Text.Length < 10)
            {
                lblPassword.Text = "您的密碼長度應大於10碼";
                UnCorrect(tb_Password, lblPassword);
            }
            else if (!flag)
            {
                lblPassword.Text = "您的密碼應同時包含至少一個英文字母及數字";
                UnCorrect(tb_Password, lblPassword);
            }
        }


        //再次確認密碼
        private void tb_RecheckPW_TextChanged(object sender, EventArgs e)
        {
            string p1 = tb_Password.Text;
            string p2 = tb_Recheck.Text;
            if (String.Equals(p1, p2))
            {
                lblRecheck.Text = "驗證通過";
                Correct(lblRecheck);
            }
            else
            {
                lblRecheck.Text = "兩次密碼輸入不同，請再次確認";
                UnCorrect(tb_Recheck, lblRecheck);
            }
        }
        //顯示密碼
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

        //放入照片後，lblPhoto消失
        private void pb_Photo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            lblPhoto.Text = "";
        }

    }
}
