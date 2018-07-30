namespace Alura.Loja.Testes.ConsoleApp
{
    public class Clientes
    {
       public int Id { get; set; }
       public string Nome  { get; internal set; }
       public Endereco EnderecoDeEntrega { get; set; } 
          
    }
}