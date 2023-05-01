namespace Projeto_loja_virtual
{
    public class Boleto : Pagamento
    {
        Random CdgBarras = new Random();

        private string CodigoBarras()
        {
            Console.WriteLine($"0339{CdgBarras.Next(9).ToString()}.{CdgBarras.Next(9000).ToString()}5 {CdgBarras.Next(90000).ToString()}.{CdgBarras.Next(9000).ToString()}5 {CdgBarras.Next(90000).ToString()}.{CdgBarras.Next(9000).ToString()}5 {CdgBarras.Next(9).ToString()} {CdgBarras.Next(90000).ToString()}.{CdgBarras.Next(90000).ToString()}");
            return "";
        }
    }
}