﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.cap8
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set;  }

        public DateTime DataDeNascimeto { get; set; }
        public DateTime DataDeNascimento { get; internal set; }
    }
}
