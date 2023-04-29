using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_loja_virtual
{
    public class NewClass
    {
        public void Menu() {
            string resposta = "";

            // INICIO


            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"            === Bem-vindo ===");
            Console.ResetColor();
            Thread.Sleep(1000);
            do {
                Console.WriteLine(@$"
                
            [1] Boleto
            [2] Cartão de Débito
            [3] Cartão de Crédito
            [4] Sair");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\nEscolha a Forma de pagamento:");
            Console.ResetColor();

            resposta = Console.ReadLine();

            switch(resposta){
                case"1":
                Console.WriteLine($"Caso 1");
                break;
                case"2":
                Console.WriteLine($"Caso 2");
                
                break;
                case"3":
                Console.WriteLine($"Caso 3");
                
                break;
                case"4":
                Console.WriteLine($"Caso 4");
                
                break;
                default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine($"Valor inválido, tente novamente...");
                Console.ResetColor();
                break;
            }
            } while (resposta != "4");
            
            // FIM
        }
    }
}