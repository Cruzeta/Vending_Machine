using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_vending_machine.ScreensControls
{
    public partial class BalanceUserControl : UserControl
    {
        double money = 0;
        
        public BalanceUserControl()
        {
            InitializeComponent();
        }
        private void BalanceUserControl_Load(object sender, EventArgs e)
        {
            txtPrice.Text = varPrice.total.ToString();
            txtmoney.Text = money.ToString();
            txtThing.Text = thing.ToString();
            txtmoney.Text = thing.ToString();

        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtPrice.Text = varPrice.total.ToString();
        }

        private void btnvinte_Click(object sender, EventArgs e)
        {
            money += Convert.ToDouble("0,2");

            txtmoney.Text = Convert.ToString(money);
        }

        private void btncinquenta_Click(object sender, EventArgs e)
        {
            money += Convert.ToDouble("0,5");

            txtmoney.Text = Convert.ToString(money);
        }
        private void btnum_Click(object sender, EventArgs e)
        {
            money += Convert.ToDouble("1");

            txtmoney.Text = Convert.ToString(money);
        }

        private void btndois_Click(object sender, EventArgs e)
        {
            money += Convert.ToDouble("2");

            txtmoney.Text = Convert.ToString(money);
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            money += Convert.ToDouble("5");

            txtmoney.Text = Convert.ToString(money);
        }

        decimal thing = 0;
        private void btnPay_Click(object sender, EventArgs e)
        {

            if (Convert.ToDecimal(txtmoney.Text) < Convert.ToDecimal(txtPrice.Text))
            {
                MessageBox.Show("Dinheiro insuficiente", "Insira dinheiro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else if (Convert.ToDecimal(txtmoney.Text) >= Convert.ToDecimal(txtPrice.Text))
            {
                thing = Convert.ToDecimal(txtmoney.Text) - Convert.ToDecimal(txtPrice.Text);
                txtThing.Clear();
                txtThing.Text += (thing);
            }
            txtmoney.Text = thing.ToString();
            money = Convert.ToDouble(thing);
            }
        

    }
}

