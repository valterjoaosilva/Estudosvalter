﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario cs = new CalculadoraDeSalario();
            Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorCento()), 2000);
            double resultado;

            resultado = cs.Calcula(funcionario);

            Console.WriteLine("O salario de um desenvolvedor que ganha 2000 bruto é : " + resultado);
            Console.ReadKey();
        }
    }
}
