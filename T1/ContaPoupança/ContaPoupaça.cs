using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaPoupança
{
    class ContaPoupaça : Conta
    {
        public virtual void deposita(double valor)
        {
            this.Saldo += valor + 0.10;
        }
    }
}
