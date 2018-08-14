using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class ISS
    {
        public double CalculaISS(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        internal double CalculaISS(Orcameto orcamento)
        {
            throw new NotImplementedException();
        }
    }
}
