using System;

namespace Abstracao
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }

        public void AumentarLimite(float acrescimo){
            
            limite = limite + acrescimo;
        }
    }
}