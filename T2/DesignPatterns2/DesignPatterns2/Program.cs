using DesignPatterns2.cap1;
using DesignPatterns2.cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.cap5;
using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
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
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Mauricio", 100.0);
            Pedido pedido2 = new Pedido("Marcelo", 200.0);
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();

            
         
        }
    }
}
