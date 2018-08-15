﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> itens { get; private set: }
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.itens = new List<Item>();

        }
        
        public void AdicionaItem(Item item)
        {
            itens.Add(item);
        }
        public Orcamento() { }

    }
}
