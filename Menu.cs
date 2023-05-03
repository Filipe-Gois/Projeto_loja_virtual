using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_loja_virtual
{
    public class MenuClass
    {
        public void MenuInicial(float valorInformado) {
            string resposta = "";
            string input = "";
            bool sair = false;
            // INICIO


            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"            === Bem-vindo ===");
            Console.ResetColor();
            Console.WriteLine($"\nValor da compra: {valorInformado}");
            Thread.Sleep(1000);

            do {
                Console.WriteLine(@$"Escolha a forma de pagamento da compra:
                
            [1] Boleto
            [2] Cartão 
            [3] Sair");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ResetColor();

            resposta = Console.ReadLine()!;
            switch(resposta){

                case"1":
                Console.WriteLine($"\nValor da compra: {valorInformado}");
                Boleto pagamentoBoleto = new Boleto();
                Console.Clear();
                //Boleto
                
                do {
                    pagamentoBoleto.Valor = valorInformado;
                    pagamentoBoleto.Registrar();
                    Console.WriteLine(@$"
            [1] Finalizar compra
            [2] Cancelar Operação
                    ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"Insira o valor desejado:");
                    Console.ResetColor();
                    input = Console.ReadLine()!;
                    switch(input) {
                        case "1":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nCompra Finalizada... Seu boleto vence em 3 dias, no dia {pagamentoBoleto.GerarData()}");
                        Console.ResetColor();
                        Environment.Exit(0);
                        break;

                        case"2":
                        pagamentoBoleto.Cancelar();
                        break;

                        default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine($"Opção selecionada inválida");
                        Console.ReadLine();
                        
                        Console.ResetColor();       
                        break;
                    }
                    
                } while(input != "2");

                break;
                case"2":
                Console.Clear();
                
                MenuCartao(valorInformado);
                
                break;
                case"3":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nSair do programa? S/N\n");
                Console.ResetColor();
                resposta = Console.ReadLine()!.ToUpper();
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

        public void MenuCartao(float valorInformado) {
            string resposta = "";
            string cadastroCartao = "";
            string outroCartao = "";
            string input = "";
            bool creditoCadastrado = false;
            bool debitoCadastrado = false;
            string bandeira = "";
            string numeroCartao = "";
            string titular = "";
            string cvv = "";
            Debito pagamentoDebito = new Debito();
            pagamentoDebito.Valor = valorInformado;
            CartaoCredito pagamentoCredito = new CartaoCredito();
            pagamentoCredito.Valor = valorInformado;

            do {
                Console.Clear();
                Console.WriteLine($"\nValor da compra: {valorInformado}\n");
                Console.WriteLine(@$"Escolha dentre as opções de cartão abaixo:

                [1] Cartão de Débito
                [2] Cartão de Crédito
                [3] Voltar ao Menu Anterior
                ");
                cadastroCartao = Console.ReadLine()!;

                while(cadastroCartao != "1" && cadastroCartao != "2" && cadastroCartao != "3"){
                    Console.WriteLine($"Opção informada inválida, escolha entre (1) para Débito ou (2) para Crédito:");
                    cadastroCartao = Console.ReadLine()!;
                }

                switch(cadastroCartao){
                    case "1":
                        if(debitoCadastrado == false){
                            Console.WriteLine($"\nCadastro de novo cartão:");
                
            Console.WriteLine($"\nQual a bandeira do cartão:");
            bandeira = Console.ReadLine()!;

            while(bandeira == ""){
                Console.WriteLine($"Campo digitado inválido. Digite um valor válido para a bandeira do cartão:");
                bandeira = Console.ReadLine()!;
            }

            Console.WriteLine($"\nQual o número do cartão:");
            numeroCartao = Console.ReadLine()!;

            while(numeroCartao == ""){
                Console.WriteLine($"Campo digitado inválido. Digite um valor válido para o número do cartão:");
                numeroCartao = Console.ReadLine()!;
            }

            Console.WriteLine($"\nQual o titular do cartão:");
            titular = Console.ReadLine()!;

            while(titular == ""){
                Console.WriteLine($"Campo digitado inválido. Digite um valor válido para o titular do cartão:");
                titular = Console.ReadLine()!;
            }

            Console.WriteLine($"\nQual o cvv do cartão:");
            cvv = Console.ReadLine()!;

            while(cvv == ""){
                Console.WriteLine($"Campo digitado inválido. Digite um valor válido para o cvv do cartão:");
                cvv = Console.ReadLine()!;
            }
                            Console.WriteLine(pagamentoDebito.SalvarCartao(bandeira, numeroCartao, titular, cvv));
                            debitoCadastrado = true;
                        }
                        
                        break;
                    
                    case "2":
                        if(creditoCadastrado == false){
                            Console.WriteLine($"\nCadastro de novo cartão:");
                
            Console.WriteLine($"\nQual a bandeira do cartão:");
            bandeira = Console.ReadLine()!;

            while(bandeira == ""){
                Console.WriteLine($"Campo digitado inválido. Digite um valor válido para a bandeira do cartão:");
                bandeira = Console.ReadLine()!;
            }

            Console.WriteLine($"\nQual o número do cartão:");
            numeroCartao = Console.ReadLine()!;

            while(numeroCartao == ""){
                Console.WriteLine($"Campo digitado inválido. Digite um valor válido para o número do cartão:");
                numeroCartao = Console.ReadLine()!;
            }

            Console.WriteLine($"\nQual o titular do cartão:");
            titular = Console.ReadLine()!;

            while(titular == ""){
                Console.WriteLine($"Campo digitado inválido. Digite um valor válido para o titular do cartão:");
                titular = Console.ReadLine()!;
            }

            Console.WriteLine($"\nQual o cvv do cartão:");
            cvv = Console.ReadLine()!;

            while(cvv == ""){
                Console.WriteLine($"Campo digitado inválido. Digite um valor válido para o cvv do cartão:");
                cvv = Console.ReadLine()!;
            }
                            Console.WriteLine(pagamentoCredito.SalvarCartao(bandeira, numeroCartao, titular, cvv));
                            creditoCadastrado = true;
                        }
                        break;

                    case "3":
                        MenuInicial(valorInformado);
                        break;
                }

                if(cadastroCartao == "1"){
                    Console.WriteLine($"\nDeseja cadastrar este mesmo cartão para Crétito? (s/n)");
                    outroCartao = Console.ReadLine()!.ToLower();
                    while(outroCartao != "s" && outroCartao != "n"){
                        Console.WriteLine($"Opção informada inválida. Escolha entre (s) para sim ou (n) para não:");
                        outroCartao = Console.ReadLine()!.ToLower();
                    }
                    if(outroCartao == "s"){
                        pagamentoCredito.SalvarCartao(bandeira, numeroCartao, titular, cvv);
                        creditoCadastrado = true;
                    }
                }else{
                    Console.WriteLine($"\nDeseja cadastrar este mesmo cartão para Débito?");
                    outroCartao = Console.ReadLine()!.ToLower();
                    while(outroCartao != "s" && outroCartao != "n"){
                        Console.WriteLine($"Opção informada inválida. Escolha entre (s) para sim ou (n) para não:");
                        outroCartao = Console.ReadLine()!.ToLower();
                    }
                    if(outroCartao == "s"){
                        pagamentoDebito.SalvarCartao(bandeira, numeroCartao, titular, cvv);
                        debitoCadastrado = true;
                    }
                }
                
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.WriteLine($"\nValor da compra: {valorInformado}\n");
                Console.WriteLine(@$"Escolha dentre as opções abaixo:

                [1] Pagar com o Cartão de Débito
                [2] Pagar com o Cartão de Crétido
                [3] Voltar ao Menu Inicial
                ");
                Console.ResetColor();
                resposta = Console.ReadLine()!;
                switch(resposta) {
                    case"1":
                        if(debitoCadastrado){
                            pagamentoDebito.Pagar();
                        do {
                        Console.WriteLine(@$"
                        [1] Finalizar compra
                        [2] Cancelar Operação
                        ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine($"Insira o valor desejado:");
                            Console.ResetColor();
                            input = Console.ReadLine()!;
                            switch(input) {
                                case "1":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nCompra Finalizada...");
                                Console.ResetColor();

                                // Como ainda n tenho nenhuma váriavel eu n botei pra imprimir o novo saldo ent só ta saindo do programa
                                Environment.Exit(0);
                                break;
                                case"2":
                                pagamentoDebito.Cancelar();
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
                        } else{
                            Console.WriteLine($"Não há um cartão de débito cadastrado. Pressione ENTER para voltar ao menu de cadastro:");
                            Console.ReadLine();
                            MenuCartao(valorInformado);
                        }

                    break;

                    case"2":

                    //Cartão de Crédito
                    if(debitoCadastrado){
                        pagamentoCredito.Pagar();
                        do {
                        Console.WriteLine(@$"
                        [1] Finalizar compra
                        [2] Cancelar Operação
                        ");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine($"Insira o valor desejado:");
                            Console.ResetColor();
                            input = Console.ReadLine()!;
                            switch(input) {
                                case "1":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nCompra Finalizada...");
                                Console.ResetColor();

                                // Como ainda n tenho nenhuma váriavel eu n botei pra imprimir o novo saldo ent só ta saindo do programa
                                Environment.Exit(0);
                                break;
                                case"2":
                                pagamentoCredito.Cancelar();
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
                    }else{
                        Console.WriteLine($"Não há um cartão de crédito cadastrado. Pressione ENTER para voltar ao menu inicial:");
                        Console.ReadLine();
                        MenuCartao(valorInformado);
                    }

                    break;

                    case"3":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Cancelando a operação");
                    Console.WriteLine($"Pressione ENTER para continuar...");
                    Console.ReadLine();
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