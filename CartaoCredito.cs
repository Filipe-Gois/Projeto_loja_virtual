using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_loja_virtual
{
    public class CartaoCredito
    {
        // - limite estabelecido no cartão de crédito deve ser pré-definido
        // - máximo de parcelamento 12x
        // - até 6x - acrescentar juros de 5% no valor da compra
        // - entre 7x e 12x acrescentar juros de 8% no valor da compra

        private float Limite = 1000;
        public float ValorCompra;
        public float ValorFinal;
        public int Parcelas;


        public void ExibirLimite()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Limite atual do cartão: {1000.ToString("C")}");
            Console.ResetColor();
        }
        public float CreditoMetodo()
        {
            Console.WriteLine($"Informe o valor do produto:");
            ValorCompra = float.Parse(Console.ReadLine()!);

            if (ValorCompra <= Limite)
            {

            do
            {
                Console.WriteLine(@$"
            Deseja parcelar em quantas vezes ?
            
            Até 6x: Juros de 5%
            7x à 12x: Juros de 8%");

                Parcelas = int.Parse(Console.ReadLine()!);

            } while (Parcelas > 12 || Parcelas <= 0);


            if (Parcelas <= 6)
            {
                ValorFinal = (ValorCompra * 1.05f) / Parcelas;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                
                Console.WriteLine($"Total: {Math.Round(ValorFinal, 2).ToString("C")} de {Parcelas} vezes com juros.");
                Console.ResetColor();

                return ValorFinal;
            }

            else
            {
                ValorFinal = (ValorCompra * 1.08f) / Parcelas;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                
                Console.WriteLine($"Total: {Math.Round(ValorFinal, 2).ToString("C")} de {Parcelas}x com juros.");
                Console.ResetColor();

                return ValorFinal;

            }
            }
            else 
            {
                Console.WriteLine($"Saldo insuficiente.");
                return 0;
            }   
        }
        }
    }

