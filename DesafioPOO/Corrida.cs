using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Corrida
    {
        protected Motorista _motorista { get; set; }
        public Status StatusAtual { get; set; }

        public enum Status
        {
            Aguardando,
            Iniciada,
            Finalizada
        }

        public bool ReceberPedidoViagem()
        {
            return true;
        }
    }
}
