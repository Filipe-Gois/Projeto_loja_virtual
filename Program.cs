using Projeto_loja_virtual;

CartaoCredito credito = new CartaoCredito();
Console.WriteLine();
credito.ExibirLimite();
Console.WriteLine();

credito.CreditoMetodo();
if (credito.Valor < 1000)
{
    credito.Pagar();
}
