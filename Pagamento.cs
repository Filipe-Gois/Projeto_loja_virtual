using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_loja_virtual
{
    public abstract class Pagamento
    {
        private DateTime Data {get; set;}
        public float this.Valor;

        public string Cancelar(){
            return "Operação Cancelada!";
        }
    }
}