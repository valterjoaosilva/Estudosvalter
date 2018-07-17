using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contassacardepositar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bancos contaValter = new Bancos();
           contaValter.numero = 1;
           contaValter.deposita(3500.0);

            Cliente clienteValter = new Cliente();
            clienteValter.titular = "Valter";
            clienteValter.idade = 18;

            clienteValter.titular = contaValter.titular;

            bool sacou = contaValter.Saca(300.0);
            if(sacou)
            {
                MessageBox.Show("saldo contaValter após saque" + contaValter.saldo);

            }
            else
            {
                MessageBox.Show("não foi possível efetuar saque");
            }
        }
    }
}
