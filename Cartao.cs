using System;

namespace Abstracao
{
    public class Cartao : Pagamento
    {
        public string token { get; set; }
        public string bandeira { get; set; }
        public int numero { get; set; }
        public string tituar { get; set; }
        public string cvv { get; set; }

        public bool ValidarToken(){
            if (token != null){
                return true;
            }
            return false;
        }
    }
}