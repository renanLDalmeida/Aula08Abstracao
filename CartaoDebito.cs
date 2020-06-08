namespace Abstracao
{
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }   

        public string Transferir(float valor){
            return "Valor transferido";
        }

        public string pagarTitulo(){
            return "Título pago";
        }
    }
}