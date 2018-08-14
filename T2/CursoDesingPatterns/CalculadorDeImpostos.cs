using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcameto orcamento, Imposto imposto)
        {

            double icms = new ICMS().calculaICMS(orcamento);
            Console.WriteLine(icms);
                   
        }

       
        }
    }

    public class Orcameto
    {
    }
}
