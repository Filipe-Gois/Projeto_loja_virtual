using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_loja_virtual
{
    public class Debito : Cartao
    {
        private float saldo;



        public override void Pagar()
        {
            Console.WriteLine($"Digite seu saldo:");
            saldo = float.Parse(Console.ReadLine()!);
             Console.Clear();
            if (saldo < Valor)
            {
                Console.WriteLine($"Saldo não foi suficiente, aperte enter para encerar operação");
                Console.ReadLine();

                { Cancelar(); }

            }
            else
            {
                Console.WriteLine($"O valor a ser pago sera: {this.Valor}");
                saldo = saldo - Valor;
                Console.WriteLine($"Seu saldo ficara: {this.saldo}");


            }

        }
    }
}