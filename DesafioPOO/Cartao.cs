using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public abstract class Cartao
    {
        public TipoCartao Tipo { get; set; }
        public int NumeroCartao;
        public string NomeTitular;
        public DateTime Validade;
        public int CVV;


    }
}
