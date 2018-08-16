﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public abstract class IImposto
    {
        public IImposto OutroImposto { get; set; }

        public IImposto(IImposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public IImposto()
        {
            this.OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcametno);
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }
    }
}
