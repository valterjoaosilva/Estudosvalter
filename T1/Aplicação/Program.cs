using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Aplicação
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader leitor = Console.In;
            string linha = leitor.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = leitor.ReadLine();
            }
        }
    }
}
