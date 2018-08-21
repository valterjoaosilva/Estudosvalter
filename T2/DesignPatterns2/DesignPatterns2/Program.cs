using DesignPatterns2.cap1;
using DesignPatterns2.cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            
           IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
           IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
           IExpressao soma = new Soma(esquerda, direita);

           Console.WriteLine(soma.Avalia()); 
        }
    }
}
