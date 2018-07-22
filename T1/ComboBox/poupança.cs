using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox
{
    class poupança : Conta, ITributável
    {
       public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }

    }
}
