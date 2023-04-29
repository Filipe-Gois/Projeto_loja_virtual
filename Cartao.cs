namespace Projeto_loja_virtual{
    public abstract class Cartao : Pagamento{
        // Atributos
        public string Bandeira {get; set;}
        public string NumeroCartao {get; set;}
        public string Titular {get; set;}
        public string Cvv {get; set;}

        // Métodos
        public abstract void Pagar();
        public string SalvarCartao(){
            return "Cartão Salvo"
        }
    }
}