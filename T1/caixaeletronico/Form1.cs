﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixaeletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numerodaconta;
            numerodaconta = 1;
            double saldo = 100.0;
            double saque = 10.0;
            double saldonaconta = saldo - saque;
            MessageBox.Show("saldo da conta é: " + saldonaconta);
        }
    }
}
