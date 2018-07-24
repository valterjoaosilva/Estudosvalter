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
        private int quantidadeDeContas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Contas[10];

            contas[0] = new ContaCorrente();
            contas[0].Numero = 1;
            contas[0].Titular = "Valter João da Silva Junior";
            quantidadeDeContas++;

            contas[1] = new ContaCorrente();
            contas[1].Numero = 2;
            contas[1].Titular = "Samira Regina Oechsler";
            quantidadeDeContas++;

            for (int i = 0; i < quantidadeDeContas; i++)
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

        public void AdicionaConta(Contas contas)
        {
            if (this.quantidadeDeContas == this.contas.Length)
            {
                Contas[] novo = new Contas[this.quantidadeDeContas * 2];
                for (int i = 0; i < this.quantidadeDeContas; i++)
                {
                    novo[i] = this.contas[i];
                }
            }
            this.contas[this.quantidadeDeContas] = contas;
            this.quantidadeDeContas++;
            comboContas.Items.Add(contas.Titular);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroDeContas cadastro = new CadastroDeContas(this);
            cadastro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveConta(contas[comboContas.SelectedIndex]);

            if (quantidadeDeContas > 1 )
            {
                textoTitular.Text = Convert.ToString(contas[comboContas.SelectedIndex].Titular);
                textoNumero.Text = Convert.ToString(contas[comboContas.SelectedIndex].Numero);
                textoSaldo.Text = Convert.ToString(contas[comboContas.SelectedIndex].Saldo);
            }
            else if (quantidadeDeContas == 1)
            {
                textoNumero.Clear();
                textoTitular.Clear();
                textoSaldo.Clear();
            }
            else
            {
                comboContas.ResetText();
                textoNumero.Clear();
                textoTitular.Clear();
                textoSaldo.Clear();
            }
        }

        public void RemoveConta(Contas conta)
        {
            comboContas.Items.Remove(conta.Titular);
     
            int i;
            for (i = 0; i < quantidadeDeContas; i++)
            {
                if (contas[i] == conta)
                {
                    break;
                }
            }
            while (i + 1 <= quantidadeDeContas)
            {
                contas[i] = contas[i + 1];
                i++;
            }

            quantidadeDeContas--;
        }
    }
}
