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
        static void Main(string[] args)
        {
            //IMensagem mensagem = new MensagemPorEmail("valter");
            IMensagem mensagem = new MensagemAdministrativa("valter");
           // IMensagem mensagem = new MensagemCliente("valter")
            IEnviador enviador = new EnviaPorEmail();
            //IEnviador enviador = new EnviaPorSMS();
            mensagem.Enviador = enviador;
            mensagem.Envia();
            
         
        }
    }
}
