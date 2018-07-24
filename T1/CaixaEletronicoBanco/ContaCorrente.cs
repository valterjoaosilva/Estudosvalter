using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoBanco
{
    class ContaCorrente : Contas
    {
        public override void Saca(double Valor)
        {
            if (this.Saldo > Valor)
            {
                this.Saldo -= Valor;
            }

        }

    }
}