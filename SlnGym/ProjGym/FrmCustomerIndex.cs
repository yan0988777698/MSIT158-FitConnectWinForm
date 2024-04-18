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
    public partial class FrmCustomerIndex : Form
    {
        public FrmCustomerIndex()
        {
            InitializeComponent();
        }

        private void btn_Member_Click(object sender, EventArgs e)
        {
            FrmMember member = new FrmMember();
            member.Show();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            FrmProduct product = new FrmProduct();
            product.Show();
        }


    }
}
