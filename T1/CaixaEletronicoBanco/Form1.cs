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
    public partial class Form1 : Form
    {
        private Contas[] contas;
        private int quantidadesDeContas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas =  new Contas[10];

            contas[0] = new ContaCorrente();
            contas[0].Numero = 1;
            contas[0].Titular = "Valter João da Silva Junior";
            quantidadesDeContas++;

            contas[1] = new ContaCorrente();
            contas[1].Numero = 2;
            contas[1].Titular = "Samira Regina Oechsler";
            quantidadesDeContas++;

            for (int i = 0; i < quantidadesDeContas; i++)
            {
                comboContas.Items.Add(contas[i].Titular);
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            MessageBox.Show(indiceSelecionado.ToString());
            Contas contaSelecionada = contas[indiceSelecionado];

            textoTitular.Text = contaSelecionada.Titular;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);

        }

        public void AdicionaConta(Contas conta)
        {
            if (this.quantidadesDeContas == this.contas.Length)
            {
                Contas[] novo = new Contas[this.quantidadesDeContas * 2];
                for (int i = 0; i < this.quantidadesDeContas; i++)
                {
                    novo[i] = this.contas[i];
                }
            }
            this.contas[this.quantidadesDeContas] = conta;
            this.quantidadesDeContas++;
            comboContas.Items.Add(conta.Titular);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroDeContas cadastro = new CadastroDeContas(this);
            cadastro.ShowDialog();
        }
    }
}
