using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Dinheiro
    {
        private float Valor { get; set; }

        public bool Pagar()
        {
            Console.WriteLine("Pagamento Concluído!");
            return true;
        }
    }
}
