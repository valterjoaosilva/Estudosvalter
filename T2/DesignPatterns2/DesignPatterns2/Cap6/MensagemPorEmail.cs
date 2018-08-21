using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap6
{
    class MensagemPorEmail : IMensagem
    {
        private string nome;

        public MensagemPorEmail(string nome)
        {
            this.nome = nome;
        }
        public void Envia()
        {
            Console.WriteLine("enviando a mensagem por e-mail");
            Console.WriteLine("Mensagem para o cliente {0} ", nome);
        }
    }
}
