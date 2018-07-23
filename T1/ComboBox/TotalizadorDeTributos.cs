﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BennerComboBox
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }
        public void Acumula(ITributável cp)
        {
            this.Total += cp.CalculaTributos();
        }
    }
}
