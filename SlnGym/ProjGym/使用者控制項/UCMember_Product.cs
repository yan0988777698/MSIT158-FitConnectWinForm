using System.Drawing;
using System.Windows.Forms;

namespace ProjGym
{
    public partial class uc_Product : UserControl
    {
        public uc_Product()
        {
            InitializeComponent();
        }
        //產品展示照
        public Image image { get { return this.pb_Photo.Image; } set { this.pb_Photo.Image = value; } }
        //產品名稱
        public string name { get { return this.lb_ProductName.Text; } set { this.lb_ProductName.Text = value; } }
        //產品價格
        public int price
        {
            get { return int.Parse(this.lb_Price.Text); }
            set { this.lb_Price.Text = value.ToString(); }
        }
        //產品銷售數量
        public int salesVolume
        {
            get { return int.Parse(this.lb_SalesVolume.Text); }
            set { this.lb_SalesVolume.Text = value.ToString(); }
        }
    }
}
