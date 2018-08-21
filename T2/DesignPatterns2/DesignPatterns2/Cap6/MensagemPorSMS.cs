using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap6
{
    class MensagemPorSMS : IMensagem
    {
        private string nome;

        public MensagemPorSMS(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            Console.WriteLine("Enviando a mensagem por SMS");
            Console.WriteLine("Mensagem pra o cliente {0}", nome);
        }
    }
}
