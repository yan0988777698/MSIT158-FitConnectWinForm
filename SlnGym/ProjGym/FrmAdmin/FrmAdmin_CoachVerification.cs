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
    public partial class FrmAdmin_CoachVerification : Form
    {
        private string _imagepath;
        gymEntities _gymEntities = new gymEntities();
        List<int> _expertise = new List<int>();
        public FrmAdmin_CoachVerification()
        {
            InitializeComponent();
            //TODO:教練審核
        }

        private void FrmAdmin_CoachVerification_Load(object sender, EventArgs e)
        {
            addcbControl();

            showUnvarifiedCoaches();
        }

        private void showUnvarifiedCoaches()
        {
            var unverifiedCoaches = from unverifiedCoach in _gymEntities.tIdentity
                                    where unverifiedCoach.role_id == 2 && unverifiedCoach.activated == false
                                    select new
                                    {
                                        ID = unverifiedCoach.id,
                                        教練姓名 = unverifiedCoach.name,
                                        審核通過 = unverifiedCoach.activated
                                    };
            this.dataGridView_UnVarifiedCoaches.DataSource = unverifiedCoaches.ToList();
            setFormat(dataGridView_UnVarifiedCoaches);
        }

        private void addcbControl()
        {
            cb_Gender.Items.Clear();
            var genders = from gender in _gymEntities.tgender_Table select gender;
            genders.ToList().ForEach(gender => { cb_Gender.Items.Add(gender.gender_text); });

            cb_Expertise.Items.Clear();
            var expertises = from expertise in _gymEntities.tclasses select expertise;
            expertises.ToList().ForEach(expertise => { cb_Expertise.Items.Add(expertise.class_name); });
        }

        private void setFormat(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
        }

        private void dataGridView_UnVarifiedCoaches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (pb_Photo.Image != null) this.pb_Photo.Image = null;
            int unVarifiedCoachID = (int)dataGridView_UnVarifiedCoaches.Rows[e.RowIndex].Cells[0].Value;
            dbSelect(unVarifiedCoachID);
        }

        private void dbSelect(int unVarifiedCoachID)
        {
            tIdentity identity = _gymEntities.tIdentity.FirstOrDefault(x => x.id == unVarifiedCoachID);
            this.lbID.Text = identity.id.ToString();
            this.tb_Name.Text = identity.name.ToString();
            this.cb_Gender.SelectedIndex = identity.gender_id - 1;
            this.tb_Phone.Text = identity.phone.ToString();
            this.dateTimePicker_Birth.Value = identity.birthday;
            this.tb_Address.Text = identity.address;
            this.tb_Mail.Text = identity.e_mail;
            this.tb_Password.Text = identity.password;
            this.tb_Password.PasswordChar = '*';

            if (!string.IsNullOrEmpty(_imagepath))
            {
                string path = Application.StartupPath + "\\CoachImages";
                pb_Photo.Image = new Bitmap(path + "\\" + _imagepath);
            }

            findExpertise(unVarifiedCoachID);
            findIntro(unVarifiedCoachID);

        }

        private void findIntro(int unVarifiedCoachID)
        {
            try { this.tb_intro.Text = _gymEntities.tcoach_info_id.FirstOrDefault(x => x.coach_id == unVarifiedCoachID).coach_intro; }
            catch (Exception ex)
            {
                this.tb_intro.Text = "這位教練沒有寫自我介紹....";
            }
        }

        private void findExpertise(int unVarifiedCoachID)
        {
            _expertise.Clear();
            this.flowLayoutPanel_Exp.Controls.Clear();
            var expertises = from expertise in _gymEntities.tcoach_expert
                             where expertise.coach_id == unVarifiedCoachID
                             select expertise;
            expertises.ToList().ForEach(expertise =>
            {
                this.cb_Expertise.SelectedIndex = expertise.class_id - 1;
                //_expertise.Add(expertise.class_id - 1);
            });
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
            flowLayoutPanel_Exp.Controls.Add(btn);
        }

        private void btn_Agree_Click(object sender, EventArgs e)
        {
            int passedCoachID = Convert.ToInt32(lbID.Text);
            tIdentity identity = _gymEntities.tIdentity.FirstOrDefault(x => x.id == passedCoachID);
            identity.activated = true;
            _gymEntities.SaveChanges();
            showUnvarifiedCoaches();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
