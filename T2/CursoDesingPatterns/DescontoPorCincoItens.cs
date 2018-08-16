using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }
      
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            return Proximo.Calcula(orcamento);
        }
                       
               
             
    }
}
