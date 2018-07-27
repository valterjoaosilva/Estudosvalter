
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Promocao
    {
        public string Descricao { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataTermino { get; internal set; }
        public object Produto { get; internal set; }
    }
}
