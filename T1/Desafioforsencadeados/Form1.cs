using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafioforsencadeados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ql = 5;
            string triangulo = " ";
            for (int l = 1; l <= ql; l++)
            {
                for (int c =1; c<=l; c++)
                {
                    triangulo += (l * c) + " ";
                }
                triangulo += "\n";
            }
            MessageBox.Show(triangulo);
        }
    }
}
