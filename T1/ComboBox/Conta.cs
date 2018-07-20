using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox
{
    class Conta
    {
        public string Titular;
        public double Saldo;
        public int Numero;

        public virtual void deposita(double Valor)
        {
            if (Valor > 0)
            {
                this.Saldo += Valor;
            }
        }
        public void Saca(double Valor)
        {
            if (this.Saldo > Valor)
            {
                this.Saldo -= Valor;
            }

        }
        public void transfere(double Valor, Conta destino)
        {
            this.Saca(Valor);
            destino.deposita(Valor);
        }
    }
}
