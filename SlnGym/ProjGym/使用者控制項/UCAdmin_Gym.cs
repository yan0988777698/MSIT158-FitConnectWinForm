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
            //FrmGymInfo f = new FrmGymInfo();
            //f.gymname = this.gymname;
            //f.gymtime = this.gymtime;
            //f.gymaddress = this.gymaddress;
            //f.gymdescribe = "";
            //f.fieldid = this.gymid;
            //f.showGymfield();
            //f.Show();
        }
    }
}
