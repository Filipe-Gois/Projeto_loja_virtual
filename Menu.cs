using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_loja_virtual
{
    public class MenuClass
    {
        public void MenuInicial() {
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
            [2] Cartão 
            [3] Sair");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"\nEscolha a Forma de pagamento:");
            Console.ResetColor();

            resposta = Console.ReadLine();

            switch(resposta){
                case"1":
                Console.Clear();
                
                // Boleto

                break;
                case"2":
                Console.Clear();
                
                MenuCartão();
                
                break;
                case"3":
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Finalizando o programa...");
                Console.ResetColor();
                break;
                default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine($"Valor inválido, tente novamente...");
                Console.ResetColor();
                break;
            }
            } while (resposta != "3");
            
            // FIM
        }

        public void MenuCartão() {
            string resposta = "";

            do {
                Console.Clear();
                Console.WriteLine(@$"
                [1] Cartão de Débito
                [2] Cartão de Crédito
                [3] Cancelar operação
                ");
                Console.WriteLine($"Insira o tipo do cartão");
                
                resposta = Console.ReadLine();
                switch(resposta) {
                    case"1":

                    //Cartão de Débito


                    break;

                    case"2":

                    //Cartão de Crédito

                    break;

                    case"3":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Cancelando a operação");
                    Console.ResetColor();
                    break;

                    default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine($"Valor inválido, tente novamente...");
                    Console.ResetColor();
                    break;
                } 
            } while (resposta != "3");
            
        }
    }
}