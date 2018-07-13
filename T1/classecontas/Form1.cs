using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classecontas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contas Valter = new contas();
            Valter.numero = 1;
            Valter.titular = "Valter João";
            Valter.saldo = 3000.0;
            Valter.cpf = "71264531915";


            MessageBox.Show(Valter.titular);

        }
    }
}