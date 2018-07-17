using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        public string Titular;
        public double Saldo;
        public int Numero;

        public void deposita(double Valor)
        {
            if(Valor > 0)
            {
                this.Saldo += Valor;
            }
        }
        public void saca(double Valor)
        {
            if(this.Saldo > Valor)
            {
                this.Saldo -= Valor;
            }
             
        }
        public void transfere(double Valor, Conta destino)
        {
            this.saca(Valor);
            destino.deposita(Valor);
        }
    }
}
