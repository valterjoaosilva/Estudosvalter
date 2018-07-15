using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contassacardepositar
{
    class Bancos
    {
        public int numero;
        public string titular;
        public double saldo;
        public Cliente cliente;
        public void deposita; (double valoradepositar)
        {
            if (valoradepositar > 0)
            {
            this.saldo += valoradepositar;
            }
        }
        public void saca; (double valorasacar)
        {
            if (this.saldo => valorasacar && valorasacar >0)
             {
                this.saldo -= valorasacar;
             }       
        public void transfere (double valor, Bancos destino )
        {
            this.saca (valor),
            destino.deposita (valor),
        }

            
    
    
    

    }



        

       

    }
       

}        
        

    


