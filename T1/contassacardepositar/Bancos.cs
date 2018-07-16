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
        public void deposita(double valoradepositar)
        {
            If(valoradepositar > 0)
            {
                this.saldo += valordodeposito;
            }
        }
        //alterado o meto valor que saca
        public bool saca(double valorasacar)
        {
            if (valorasacar > this.saldo || valorasacar > 0)
            {
                return false;
            }
            else
            {
                if (this.titular.Ehmaiordeidade)
                {
                    this.saldo -= valorasacar;
                    return true;
                }
            }
            else
            {
                if(valorasacar <= 200)
                {
                    this.saldo -= valorasacar;
                }
                else
                {
                    return false;
                }
                            
            }

        }
                  
        public void transfere(double valor, Bancos destino)
        {
            this.saca(valor);
            destino.deposita(valor);
        }

           


    }

            
    
    
    

}



        

       
    


