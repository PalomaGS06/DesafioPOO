using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Passageiro : Usuario
    {
        private Endereco EndOrigem { get; set; }
        private Endereco EndDestino { get; set; }
        private FormaPagamento Pagamento { get; set; }

        public void SolicitarDestino (Endereco partida, Endereco chegada)
        {
            EndOrigem = partida;
            EndDestino = chegada;
        }

        public void AdicionarPagamento()
        {
            Console.Write("Qual sua forma de pagamento? ");
        }
       
    }
}
