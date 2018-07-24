using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoBanco
{
    public abstract class Contas
    {
        public string Titular;
        public double Saldo { get; protected set; }
        public int Numero { get; set; }

        public virtual void deposita(double Valor)
        {
            if (Valor > 0)
            {
                this.Saldo += Valor;
            }
        }
        public abstract void Saca(double Valor);

        public void transfere(double Valor, Contas destino)
        {
            this.Saca(Valor);
            destino.deposita(Valor);
        }

    }
}
