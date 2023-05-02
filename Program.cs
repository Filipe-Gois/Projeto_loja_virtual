using Projeto_loja_virtual;

Boleto teste = new Boleto();

Console.WriteLine($"Insira o valor da compra:");
teste.Valor = float.Parse(Console.ReadLine()!);

teste.Registrar();