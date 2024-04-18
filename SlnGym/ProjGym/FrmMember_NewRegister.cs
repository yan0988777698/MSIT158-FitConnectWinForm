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
        public event D savedata;
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

            return hasError;
        }
        private void hideError()
        {
            pb_ErrorName.Visible = pb_ErrorGender.Visible = pb_ErrorPhone.Visible = pb_ErrorBirth.Visible = pb_ErrorAddress.Visible = pb_ErrorMail.Visible = pb_ErrorPassword.Visible = false;
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
            gymEntities gymEntities = new gymEntities();
            var genders = from gender in gymEntities.tgender_Table select gender;
            genders.ToList().ForEach(gender => { cb_GenderList.Items.Add(gender.gender_text); });
        }


    }
}
