using System;

namespace Abstracao
{
    public class Pagamento
    {
        public DateTime data { get; set; }
        public float valor { get; set; }

        public string Pagar(float valorPago){
            return "valor pago: R$"+valorPago;   
        }
        public string Cancelar(){
            return "Compra cacelada";
        }

    }
}