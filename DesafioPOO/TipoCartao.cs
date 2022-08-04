using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class TipoCartao : Cartao
    {
        public bool Debito { get; set; }
        public bool Credito { get; set; }

        public bool EscolherDebito(float Saldo)
        {
            if (Debito)
            {
                Console.WriteLine($"Seu saldo é de R$:{Math.Round(Saldo, 2)} !");
            }
            return true;
        }

        public bool EscolherCredito(float Limite)
        {
            if (Credito)
            {
                Console.WriteLine($"Seu limite é de R$:{Math.Round(Limite, 2)} !");
            }
            return true;
        }

    }
}
