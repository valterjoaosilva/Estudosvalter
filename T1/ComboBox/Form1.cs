using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {   Conta[] contas;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[3];

            Conta contaValter = new Conta();
            contaValter.Numero = 1;
            contaValter.Titular = "Valter João da Silva Junior";
            contas[0] = contaValter;

            

            Conta contaSamira = new Conta();
            contaSamira.Numero = 2;
            contaSamira.Titular = "Samira Regina Oecksler";
            contas[1] = contaSamira;

            

            Conta contaPedro = new Conta();
            contaPedro.Numero = 3;
            contaPedro.Titular = "Pedro Alex Martins";
            contas[2] = contaPedro;


            foreach(Conta conta in contas)//o professor colocou Conta c porém não encontrei referência para a mesma
            {
                ComboDeContas.Items.Add(conta.Titular);
            }

            

        }
        private void ComboDeContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = ComboDeContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];

            TextoTitular.Text = contaSelecionada.Titular;
            TextoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            TextoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
                                    
            
        }
        private Conta BuscaContaSelecionada()
        {

            int indiceSelecionado = ComboDeContas.SelectedIndex;
            return this.contas[indiceSelecionado];
        }
        private void TextoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String textoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoValorDoDeposito);
            Conta contaSelecionada = this.BuscaContaSelecionada();
            contaSelecionada.deposita(valorDeposito);
            this.MostraConta(contaSelecionada);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoValorSaque = textoValor.Text;
            double valorSaque = Convert.ToDouble(textoValorSaque);
            int indiceSelecionado = ComboDeContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];
            contaSelecionada.Saca(valorSaque);
            this.MostraConta(contaSelecionada);
        }
        private void MostraConta(Conta contaSelecionada)
        {
            TextoTitular.Text = contaSelecionada.Titular;
            TextoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            TextoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);

        }

        private void TextoValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
