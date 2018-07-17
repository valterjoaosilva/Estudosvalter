using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta contaValter = new Conta();
            contaValter.Numero = 1;
            contaValter.Titular = "Valter João"; 
            contaValter.deposita(250.0);
            textoTitular.Text = contaValter.Titular;
            textoNumero.Text = Convert.ToString(contaValter.Numero);
            textoSaldo.Text = Convert.ToString(contaValter.Saldo);
            String textoValorDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoValorDeposito);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
