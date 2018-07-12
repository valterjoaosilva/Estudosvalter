using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seriefibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seriefibonacci = " ";
            int atual = 0;
            int anterior = 1;
            while (atual < 100)
            {
                seriefibonacci += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
                MessageBox.Show("a serie fibonacci até 100:" + seriefibonacci);
            }
        }
    }
}
