using System;

namespace Abstracao
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento { get; set; }
        public string bancoEmissor { get; set; }
        public string codDeBarras { get; set; }
        public string registrarNoSistema(){
            return "Boleto registrado";
        }




    }
}