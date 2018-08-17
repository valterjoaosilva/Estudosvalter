using System;

namespace CursoDesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
                
            criador
                .ParaEmpresa("Caelum Ensino e Inovacao")
                .ComCnpj("23.456.789/0001-12")
                .comItem(new ItemDaNota("item 1", 100.0))
                .comItem(new ItemDaNota("item 2", 200.0))
                .NaDataAtual()
                .ComObservacoes("uma obs qualquer");

            NotaFiscal nf = criador.Constroi();
            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.ReadKey();


            //IImposto iss = new ISS(new ICMS());

            //Orcamento orcamento = new Orcamento(500.0);

            //double valor = iss.Calcula(orcamento);

            //Console.WriteLine(valor);







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
