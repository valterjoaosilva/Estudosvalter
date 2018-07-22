using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox
{
    class GerenciadorDeImpostos
    {
        public double Total { get; private set; }
        public void Adiciona(ITributável tributavel)
        {
            this.Total += tributavel.CalculaTributos();
        }
    }
}
