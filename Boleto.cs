using System.Globalization;
using System;
using static System.Globalization.CultureInfo;

namespace Projeto_loja_virtual
{
    public class Boleto : Pagamento
    {
        Random CodigoDeBarras = new Random();
        // public DateTime Data;

    
        private string CodigoBarras()
        {

            return $"0339{CodigoDeBarras.Next(9).ToString()}.{CodigoDeBarras.Next(9000).ToString()}5 {CodigoDeBarras.Next(90000).ToString()}.{CodigoDeBarras.Next(9000).ToString()}5 {CodigoDeBarras.Next(90000).ToString()}.{CodigoDeBarras.Next(9000).ToString()}5 {CodigoDeBarras.Next(9).ToString()} {CodigoDeBarras.Next(90000).ToString()}.{CodigoDeBarras.Next(90000).ToString()}";
        }


        public void Registrar()
        {
            this.Valor = this.Valor * 0.88f;

            Console.WriteLine($"\n");
            Console.WriteLine($"Compras efetuadas no boleto tem 12% de desconto!!");

            Console.WriteLine(@$"
            ____________________________________________________________________________
            
            Beneficiário: Projeto Loja Virtual
            Valor do boleto: {this.Valor.ToString(CultureInfo.GetCultureInfo("pt-BR"))}
            Código de barras: {CodigoBarras()}

            Seu boleto vence em 3 dias.
            ____________________________________________________________________________
            ");
        }
    }
}