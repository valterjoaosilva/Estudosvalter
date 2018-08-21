using DesignPatterns2.cap1;
using DesignPatterns2.cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.cap5;
using DesignPatterns2.Cap6;
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

        public static MensagemPorEmail MensagemPorEmail { get; private set; }
        

        static void Main(string[] args)
        {
            MensagemPorEmail = new MensagemPorEmail("valter");
            mensagem.Envia();
            
         
        }
    }
}
