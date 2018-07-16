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
        public double saldo { get; private set; }
        public Cliente cliente;
        public void deposita(double valoradepositar)
        {
            if(valoradepositar > 0)
            {
                this.saldo += valoradepositar;
            }
        }
        //alterado o meto valor que saca
        public bool Saca(double valorasacar)
        {
            if (valorasacar > this.saldo || valorasacar < 0)
            {
                return false;
            }
            else
            {
                if (this.cliente.Ehmaiordeidade())
                {
                    this.saldo -= valorasacar;
                    return true;
                }

                else
                {
                    if (valorasacar <= 200)
                    {
                        this.saldo -= valorasacar;
                        return true; ;
                    }

                    else
                    {
                        return false;
                    }
                }           
            }
     

        }
                  
        public void transfere(double valor, Bancos destino)
        {
            this.Saca(valor);
            destino.deposita(valor);
        }

           


    }

            
    
    
    

}



        

       
    


