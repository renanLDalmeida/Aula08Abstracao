using System;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito alelo = new CartaoCredito();
            alelo.limite = 1200f;
            
            Console.WriteLine( "Quanto acrescentar no limite?" );
            float acrescimo = float.Parse (Console.ReadLine());

            alelo.AumentarLimite(acrescimo);
            Console.WriteLine( "Novo limite: R$"+alelo.limite );

            Console.WriteLine( "Digite a data do pagamento:" );
            alelo.data = DateTime.Parse (Console.ReadLine());

            Console.WriteLine( "Data do pagamento: "+alelo.data );
        }
    }
}
