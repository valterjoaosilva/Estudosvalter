using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoCadastroDeContas
{
    public partial class CadastroDeContas : Form
    {
        public CadastroDeContas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String titular = titularConta.Text;
            int numero = Convert.ToInt32 (numeroConta.Text);

            Contas contas = new ContaCorrente()
            {
                Numero = numero,
                Titular = titular
            };


        }
    }
}
