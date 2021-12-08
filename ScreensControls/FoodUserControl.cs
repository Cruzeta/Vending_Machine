using System;
using System.Windows.Forms;

namespace My_vending_machine.Controls
{
    public partial class FoodUserControl : UserControl
    {
        public FoodUserControl()
        {
            InitializeComponent();
        }

        private void btnBuyHam_Click(object sender, EventArgs e)
        {
            varPrice.total += Convert.ToDecimal("3,5");
        }

        private void btnBuyPizza_Click(object sender, EventArgs e)
        {
            varPrice.total += Convert.ToDecimal("7,9");
        }

        private void btnBuySalad1_Click(object sender, EventArgs e)
        {
            varPrice.total += Convert.ToDecimal("6,2");
        }

        private void btnBuySalad2_Click(object sender, EventArgs e)
        {
            varPrice.total += Convert.ToDecimal("5,5");
        }

    }
}
