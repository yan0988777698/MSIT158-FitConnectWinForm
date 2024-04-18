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
    public partial class UCMember_FindCourse : UserControl
    {
        public string courseName
        {
            get { return this.lbl_CourseName.Text; }
            set { this.lbl_CourseName.Text = value; }
        }
        public string courseIntro
        {
            get { return this.lbl_CourseIntro.Text; }
            set { this.lbl_CourseIntro.Text = value; }
        }
        public string coursePhoto
        {
            get { return this.pb_CoursePhoto.ImageLocation; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                pb_CoursePhoto.Image = new Bitmap(Application.StartupPath + "\\ClassPic\\" + value);
            }
        }
        public Button btnReserve { get { return this.btn_Reserve; } }

        public UCMember_FindCourse()
        {
            InitializeComponent();
        }

    }
}
