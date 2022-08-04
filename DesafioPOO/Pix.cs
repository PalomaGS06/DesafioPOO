using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
     public class Pix
    {
        private string ChaveTipo { get; set; }
        private char Chave { get; set; }

        public void Pagar()
        {
            Console.WriteLine("Pagamento Concluído!");
        }
    }
}
