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
    public partial class UCMember_FindCoach : UserControl
    {
        public string name { get { return this.lbl_Name.Text; } set { this.lbl_Name.Text = value; } }
        public string expertise { get { return this.lbl_Expertise.Text; } set { this.lbl_Expertise.Text = value; } }
        public string district { get { return this.lbl_District.Text; } set { this.lbl_District.Text = value; } }
        public string intro { get { return this.lbl_Intro.Text; } set { this.lbl_Intro.Text = value; } }
        public Button btnMore { get { return this.btn_More; } }
        public UCMember_FindCoach()
        {
            InitializeComponent();
        }


    }
}
