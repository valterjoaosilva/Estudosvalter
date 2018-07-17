using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contassacardepositar
{
    class Cliente
    {
        public string Titular;
        public string rg;
        public string endereco;
        public int idade;
        public bool Ehmaiordeidade()
        {
            return this.idade > 0; 
        }
        public Cliente(string titular)
        {
            this.Titular = titular;
        } 
    }
}
