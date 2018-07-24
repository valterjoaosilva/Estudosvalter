using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronicoBanco
{
    public partial class CadastroDeContas : Form
    {
        private Form1 aplicacaoPrincipal;
        public CadastroDeContas(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String titular = titularConta.Text;
            int numero = Convert.ToInt32(numeroConta.Text);

            Contas conta = new ContaCorrente()
            {
                Numero = numero, Titular = titular
            };
            this.aplicacaoPrincipal.AdicionaConta(conta);
        }

        private void CadastroDeContas_Load(object sender, EventArgs e)
        {

        }
    }
}
