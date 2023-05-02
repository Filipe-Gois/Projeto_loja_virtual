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
            string input = "";
            bool sair = false;
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
            Console.WriteLine($"\nInsira o valor desejado:");
            Console.ResetColor();

            resposta = Console.ReadLine();
            switch(resposta){

                case"1":
                Console.Clear();
                //Boleto
                
                do {
                    Console.WriteLine(@$"
            [1] Finalizar compra
            [2] Cancelar Operação
                    ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"Insira o valor desejado:");
                    Console.ResetColor();
                    input = Console.ReadLine();
                    switch(input) {
                        case "1":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Compra Finalizada...");
                        Console.ResetColor();

                        // Como ainda n tenho nenhuma váriavel eu n botei pra imprimir o novo saldo ent só ta saindo do programa
                        Environment.Exit(0);
                        break;
                        case"2":
                        Console.Clear();
                        break;
                        default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine($"Valor inválido, tente novamente...");
                        Console.ResetColor();       
                        break;
                    }
                    
                } while(input != "2");

                break;
                case"2":
                Console.Clear();
                
                MenuCartão();
                
                break;
                case"3":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nSair do programa? S/N\n");
                Console.ResetColor();
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "S") {
                    Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Finalizando o programa...");
                Console.ResetColor();
                    sair = true;
                }
                else {
                    sair = false;
                    Console.Clear();
                }
                break;
                default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine($"Valor inválido, tente novamente...");
                Console.ResetColor();
                break;
            }
            } while (!sair);
            
            // FIM
        }

        public void MenuCartão() {
            string resposta = "";
            string input = "";

            do {
                Console.Clear();
                Console.WriteLine(@$"
                [1] Cartão de Débito
                [2] Cartão de Crédito
                [3] Cancelar operação
                ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"Insira o tipo do cartão");
                Console.ResetColor();
                resposta = Console.ReadLine();
                switch(resposta) {
                    case"1":

                    //Cartão de Débito
                    
                    do {
                    Console.WriteLine(@$"
                    [1] Finalizar compra
                    [2] Cancelar Operação
                            ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine($"Insira o valor desejado:");
                            Console.ResetColor();
                            input = Console.ReadLine();
                            switch(input) {
                                case "1":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Compra Finalizada...");
                                Console.ResetColor();

                                // Como ainda n tenho nenhuma váriavel eu n botei pra imprimir o novo saldo ent só ta saindo do programa
                                Environment.Exit(0);
                                break;
                                case"2":
                                Console.Clear();
                                break;
                                default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine($"Valor inválido, tente novamente...");
                                Console.ResetColor();
                                break;
                            }
                            
                    } while(input != "2");


                    break;

                    case"2":

                    //Cartão de Crédito

                    do {
                    Console.WriteLine(@$"
                    [1] Finalizar compra
                    [2] Cancelar Operação
                            ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine($"Insira o valor desejado:");
                            Console.ResetColor();
                            input = Console.ReadLine();
                            switch(input) {
                                case "1":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Compra Finalizada...");
                                Console.ResetColor();

                                // Como ainda n tenho nenhuma váriavel eu n botei pra imprimir o novo saldo ent só ta saindo do programa
                                Environment.Exit(0);
                                break;
                                case"2":
                                Console.Clear();
                                break;
                                default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine($"Valor inválido, tente novamente...");
                                Console.ResetColor();
                                break;
                            }
                            
                    } while(input != "2");

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