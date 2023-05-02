using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_loja_virtual
{
    public class Pagamento
    {
        public DateTime DataAtual = DateTime.Now;
        public float Valor;

        public DateTime GerarData(){
            DateTime DataFinal = new DateTime(DataAtual.Year, DataAtual.Month, DataAtual.Day + 3, DataAtual.Hour, DataAtual.Minute, DataAtual.Second);
            return DataFinal;
        }
        public string Cancelar(){
            return "Operação Cancelada!";
        }
    }
}