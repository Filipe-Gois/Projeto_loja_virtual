using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_loja_virtual
{
    public class Debito : Cartao
    {
        private float saldo = 5000;



        public override void Pagar()
        {
            if (saldo < Valor)
            {
                Console.WriteLine($"Saldo não insuficiente para a compra.");
                Cancelar();
            }
            else
            {
                Console.WriteLine($"\nO valor da compra a ser pago será de: {this.Valor:C2} e será debitado em sua conta corrente.");
                saldo = saldo - Valor;
            }

        }
    }
}