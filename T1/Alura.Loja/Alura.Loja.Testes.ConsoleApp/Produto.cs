﻿namespace Alura.Loja.Testes.ConsoleApp
{
    public   class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PreçoUnitario { get; internal set; }
        public string Unidade { get; set; }
      
        public override string ToString()
        {
            return $"Produto:   {this.Id}, {this.Nome}, {this.Categoria}, {this.PreçoUnitario}";
        }
    }
}