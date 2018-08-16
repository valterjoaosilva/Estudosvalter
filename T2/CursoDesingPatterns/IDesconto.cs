using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public interface IDesconto
    {
        
        IDesconto Proximo {get; set;}

        double Calcula(Orcamento orcamento);
        double Desconta(Orcamento orcamento);
    }
}
