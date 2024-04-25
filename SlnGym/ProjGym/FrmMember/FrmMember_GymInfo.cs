using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjGym.FrmMember
{
    public partial class FrmMember_GymInfo : Form
    {
        private int currentImageIndex = -1;
        gymEntities _gymEntities = new gymEntities();
        public FrmMember_GymInfo()
        {
            InitializeComponent();
            timer1.Interval = 2500; // 時間間隔
        }
        public void showGymfield()
        {
            this.lblName.Text = gymname;
            this.lblTime.Text = "營業時間:" + gymtime;
            this.lblAddress.Text = "地址:" + gymaddress;
            this.lblDescribe.Text = gymdescribe;
        }
        public string gymname { get; set; }
        public string gymtime { get; set; }
        public string gymaddress { get; set; }
        public string gymdescribe { get; set; }
        public string fieldphoto { get; set; }
        public int gymid { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowNextPicture();
        }

        private void FrmMember_GymInfo_Load(object sender, EventArgs e)
        {
            showGymfield();

            var photoes = from photo in _gymEntities.tfield_photo
                          where photo.tfield.Gym_id == gymid
                          select photo;

            foreach (var photo in photoes)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 160;
                pictureBox.Height = 80;
                pictureBox.Image = new Bitmap($"{Application.StartupPath}\\FieldImages\\{photo.field_photo}");
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Click += showClickedPicture;
                flowLayoutPanel_pb_Field.Controls.Add(pictureBox);
            }
            ShowNextPicture();
            timer1.Start();
        }

        private void showClickedPicture(object sender, EventArgs e)
        {
            pb_Field.Image = ((PictureBox)sender).Image;
        }

        private void ShowNextPicture()
        {
            if (flowLayoutPanel_pb_Field.Controls.Count > 0)
            {
                currentImageIndex = (currentImageIndex + 1) % flowLayoutPanel_pb_Field.Controls.Count;
                PictureBox nextImage = (PictureBox)flowLayoutPanel_pb_Field.Controls[currentImageIndex];
                pb_Field.Image = nextImage.Image;
            }
        }

    }
}
