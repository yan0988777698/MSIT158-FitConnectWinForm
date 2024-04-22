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
    public partial class UCCoach_OpenedCourse : UserControl
    {
        public string coursename
        {
            get { return this.lbl_CourseName.Text; }
            set { this.lbl_CourseName.Text = value; }
        }
        public string maxStudent
        {
            get { return this.lbl_MaxStudents.Text; }
            set { this.lbl_MaxStudents.Text = value; }
        }
        public string field
        {
            get { return this.lbl_Field.Text; }
            set { this.lbl_Field.Text = value; }
        }
        public string date
        {
            get { return this.lbl_Date.Text; }
            set { this.lbl_Date.Text = value; }
        }
        public string time
        {
            get { return this.lbl_Time.Text; }
            set { this.lbl_Time.Text = value; }
        }
        public UCCoach_OpenedCourse()
        {
            InitializeComponent();
        }
    }
}
