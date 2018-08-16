using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            



            IImposto iss = new ISS(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);

            Console.ReadKey();





            //IImposto icms = new ICMS();
            //IImposto iccc = new ICCC();



            //CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            //calculador.RealizaCalculo(orcamento, icms);
            //calculador.RealizaCalculo(orcamento, iss);
            //calculador.RealizaCalculo(orcamento, iccc);

            //Console.ReadKey();

            //Calculos de descontos
            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            //Orcamento orcamento = new Orcamento(500);
            //orcamento.AdicionaItem(new Item("CANETA", 250));
            //orcamento.AdicionaItem(new Item("LAPIS", 250));
            //orcamento.AdicionaItem(new Item("GELADEIRA", 250));
            //orcamento.AdicionaItem(new Item("FOGÃO", 250));
            //orcamento.AdicionaItem(new Item("FERRO", 250));
            //orcamento.AdicionaItem(new Item("MICROONDAS", 250));


            //double desconto = calculador.Calcula(orcamento);
            //Console.WriteLine(desconto);

            //Console.ReadKey();


        }
    }
}
