using System;
using System.Windows.Forms;


namespace My_vending_machine.ScreensControls
{
    public partial class DrinksUserControl : UserControl
    {
        public DrinksUserControl()
        {
            InitializeComponent();
        }

        private void btnBuyNaturalJuice_Click(object sender, EventArgs e)
        {
            varPrice.total += Convert.ToDecimal("2,8");
        }

        private void btnBuyCoca_Click(object sender, EventArgs e)
        {
            varPrice.total += Convert.ToDecimal("2,5");
        }

        private void btnBuyPepsi_Click(object sender, EventArgs e)
        {
            varPrice.total += Convert.ToDecimal("2,3");
        }

        private void btnBuyCoffe_Click(object sender, EventArgs e)
        {
            varPrice.total += Convert.ToDecimal("1,5");
        }
    }
}
