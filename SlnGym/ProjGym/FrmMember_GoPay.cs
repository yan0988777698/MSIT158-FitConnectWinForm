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
    public delegate void Darg0();
    public partial class FrmMember_GoPay : Form
    {
        public Darg0 afterClose;
        public Darg0 afterPay;
        public tIdentity member { get; set; }
        public int courseNumber { get; set; }
        public int totalPrice { get; set; }
        public FrmMember_GoPay()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (afterClose != null)
                afterClose();
            this.Close();
        }

        private void FrmMember_GoPay_Load(object sender, EventArgs e)
        {
            this.tb_Name.Text = this.member.name;
            this.tb_Phone.Text = this.member.phone;
            this.tb_Mail.Text = this.member.e_mail;
            this.tb_Address.Text = this.member.address;
            this.lbl_Cost.Text = $"NT{this.totalPrice}";

            this.cb_Receipt.Items.Clear();
            this.cb_Receipt.Items.Add("電子發票");
            this.cb_Receipt.Items.Add("手機條碼載具");
            this.cb_Receipt.Items.Add("公司戶發票");
        }

        private void cb_Receipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 0)
            {
                this.flowLayoutPanel_Receipt.Controls.Clear();
                return;
            }
            if(((ComboBox)sender).SelectedIndex == 1)
            {
                this.flowLayoutPanel_Receipt.Controls.Clear();
                this.flowLayoutPanel_Receipt.Controls.Add(new UCMember_MobileCarriers());
                return;
            }
            if (((ComboBox)sender).SelectedIndex == 2)
            {
                this.flowLayoutPanel_Receipt.Controls.Clear();
                this.flowLayoutPanel_Receipt.Controls.Add(new UCMember_UniformNumbers());
                return;
            }
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (afterPay != null)
                afterPay();
            if (afterClose != null)
                afterClose();
            this.Close();
        }
    }
}
