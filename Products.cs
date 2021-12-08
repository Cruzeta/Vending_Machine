using My_vending_machine.Controls;
using My_vending_machine.ScreensControls;
using System;
using System.Windows.Forms;


namespace Vending_Machine
{
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(new FoodUserControl());

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void btnFood_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(new FoodUserControl());
        }
        private void btnDrink_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(new DrinksUserControl());
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            pnlmain.Controls.Add(new BalanceUserControl()); 
        } 
    }
}
