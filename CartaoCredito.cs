using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Projeto_loja_virtual
{
    public class CartaoCredito : Cartao
    {        
        // Atributos
        private float Limite = 1000;
        public float ValorFinal;
        public int Parcelas;

        // Métodos

        // Método para exibir o limite do cartão de crédito
        public void ExibirLimite()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Limite atual do cartão: {Limite.ToString("C", new CultureInfo("pt-br"))}");
            Console.ResetColor();
        }
        // Método para calcular e retornar o valor total da compra no cartão de crédito
        // public float CreditoMetodo()
        // {
        //     Console.WriteLine($"Informe o valor do produto:");
        //     this.Valor = float.Parse(Console.ReadLine()!);

        //     if (this.Valor <= Limite)
        //     {

        //     do
        //     {
        //         Console.WriteLine(@$"
        //     Deseja parcelar em quantas vezes ?
            
        //     Até 6x: Juros de 5%
        //     7x à 12x: Juros de 8%");

        //         Parcelas = int.Parse(Console.ReadLine()!);

        //     } while (Parcelas > 12 || Parcelas <= 0);


        //     if (Parcelas <= 6)
        //     {
        //         ValorFinal = (this.Valor * 1.05f) / Parcelas;

        //         Console.ForegroundColor = ConsoleColor.Blue;
        //         Console.WriteLine();
                
        //         Console.WriteLine($"Total: {Math.Round(ValorFinal, 2).ToString("C", new CultureInfo("pt-br"))} de {Parcelas} vezes com juros.");
        //         Console.ResetColor();

        //         return ValorFinal;
        //     }

        //     else
        //     {
        //         ValorFinal = (this.Valor * 1.08f) / Parcelas;

        //         Console.ForegroundColor = ConsoleColor.Blue;
        //         Console.WriteLine();
                
        //         Console.WriteLine($"Total: {Math.Round(ValorFinal, 2).ToString("C", new CultureInfo("pt-br"))} de {Parcelas}x com juros.");
        //         Console.ResetColor();

        //         return ValorFinal;

        //     }
        //     }
        //     else 
        //     {
        //         Console.WriteLine($"Limite do cartão estourado.");
        //         return 0;
        //     }   
        // }

        // Método para exibir a mensagem de "Compra concluída"
        public override void Pagar()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            
            Console.WriteLine($"Informe em quantas parcelas deseja pagar o produto: (máximo de 12 parcelas)");
            this.Parcelas = int.Parse(Console.ReadLine()!);
            do{
                Console.WriteLine($"Número de parcelas inválido. Digite entre 1 ou 12 parcelas");
                this.Parcelas = int.Parse(Console.ReadLine()!);
            } while(this.Parcelas > 12 || this.Parcelas <= 0);

            Console.ResetColor(); 
        }  
        }
        }
    

