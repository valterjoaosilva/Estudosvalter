using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class BancoArrays
    {
        ContaArrays[] conta = new ContaArrays[10];
        private int quantidade;
        public void Adiciona(ContaArrays conta)
        {
            this.conta[this.quantidade] = conta;
            this.quantidade++;
        }
    }
}
