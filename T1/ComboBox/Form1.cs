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

            contas  = new Conta[3];

            Conta contaSamira = new Conta();
            contaSamira.Numero = 2;
            contaSamira.Titular = "Samira Regina Oecksler";
            contas[1] = contaSamira;

            contas = new Conta[3];

            Conta contaPedro = new Conta();
            contaPedro.Numero = 3;
            contaPedro.Titular = "Pedro Alex Martins";
            contas[3] = contaPedro;

            foreach(Conta conta in contas)//o professor colocou Conta c porém não encontrei referência para a mesma
            {
                ComboDeContas.Items.Add(conta.Titular);
            }


        }
        private void ComboDeContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = ComboDeContas.SelectedIndex;
            Conta contaSelecionada = this.contas[indiceSelecionado];

            this.MostraConta(contaSelecionada);// comando dando erro pois não é um método criado
          
                              
            
        }
    }
}
