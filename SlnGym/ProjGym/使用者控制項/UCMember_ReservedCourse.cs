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
    public partial class UCMember_ReservedCourse : UserControl
    {
        public string coach {  set { this.lbl_Coach.Text = value; } }
        public string date { set { this.lbl_Date.Text = value; } }
        public string time { set { this.lbl_Time.Text = value; } }
        public string field { set { this.lbl_Field.Text = value; } }
        public string pay { set {this.lbl_Pay.Text = value; } }
        public Button cancel { get { return this.btn_Cancel; } }

        public UCMember_ReservedCourse()
        {
            InitializeComponent();
        }


    }
}
