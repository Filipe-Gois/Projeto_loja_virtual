using Projeto_loja_virtual;

CartaoCredito credito = new CartaoCredito();
Console.WriteLine();
credito.ExibirLimite();
Console.WriteLine();
Console.WriteLine($"Digite o valor do Produto:");
credito.Valor = float.Parse(Console.ReadLine()!);
Console.WriteLine();
credito.Pagar();