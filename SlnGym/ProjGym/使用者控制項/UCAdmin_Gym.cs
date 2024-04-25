using ProjGym.FrmMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjGym.使用者控制項
{
    public partial class UCAdmin_Gym : UserControl
    {
        public UCAdmin_Gym()
        {
            InitializeComponent();
        }
        public void showGymInfo()
        {
            this.lbl_GymName.Text = gymname;
            this.lbl_BusinessHours.Text = "營業時間:" + gymtime;
            this.lbl_Address.Text = "地址:" + gymaddress;
            if (!string.IsNullOrEmpty(this.gymphoto))
                this.pb_GymPhoto.Image = new Bitmap(Application.StartupPath + "\\GymImages\\" + gymphoto);
        }
        public string gymname { get; set; }
        public string gymtime { get; set; }
        public string gymaddress { get; set; }
        public string gymphoto { get; set; }
        public int gymid { get; set; }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //TODO:
            FrmMember_GymInfo frmMember_GymInfo = new FrmMember_GymInfo();
            frmMember_GymInfo.gymname = this.gymname;
            frmMember_GymInfo.gymtime = this.gymtime;
            frmMember_GymInfo.gymaddress = this.gymaddress;
            frmMember_GymInfo.gymdescribe = "";
            frmMember_GymInfo.gymid = this.gymid;
            frmMember_GymInfo.Show();
        }
    }
}
