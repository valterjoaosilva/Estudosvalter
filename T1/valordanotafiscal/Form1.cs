using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valordanotafiscal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valordanotafiscal = 3250;
            if (valordanotafiscal <= 999)
            {
                MessageBox.Show("Imposto deve ser 2%");
            }
            else if (valordanotafiscal >= 1000 && valordanotafiscal <= 2999)
            {
                MessageBox.Show("imposto deve ser 2,5%");
            }
            else if (valordanotafiscal >= 3000 && valordanotafiscal <= 6999)
            {
                MessageBox.Show("imposto deve ser 2,8%");
            }
            else
            {
                MessageBox.Show("imposto deve ser 3%");
            }
               
            


        }

    }
}
