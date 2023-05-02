namespace Projeto_loja_virtual{
    public abstract class Cartao : Pagamento{
        // Atributos
        public string Bandeira {get; set;} = "";
        public string NumeroCartao {get; set;} = "";
        public string Titular {get; set;} = "";
        public string Cvv {get; set;} = "";

        // Métodos
        public abstract void Pagar();

        public string SalvarCartao(){
            bool informacoesValidas = true;
            Console.WriteLine($"Qual a bandeira do cartão:");
            this.Bandeira = Console.ReadLine()!;

            Console.WriteLine($"Qual o número do cartão:");
            this.NumeroCartao = Console.ReadLine()!;

            Console.WriteLine($"Qual o titular do cartão:");
            this.Titular = Console.ReadLine()!;

            Console.WriteLine($"Qual o cvv do cartão:");
            this.Cvv = Console.ReadLine()!;

            if((this.Bandeira == "") || (this.NumeroCartao == "") || (this.Titular == "") || (this.Cvv == "")){
                informacoesValidas = false;
            }

            return (informacoesValidas) ? $"Cartão salvo com sucesso!\nPressione ENTER para continuar..." : $"Falha ao cadastrar o cartão!\nPressione ENTER oara inserir os dados novamente...";
        }
    }
}