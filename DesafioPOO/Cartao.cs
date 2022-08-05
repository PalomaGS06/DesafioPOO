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
        protected int NumeroCartao;
        protected string NomeTitular;
        protected DateTime Validade;
        protected int CVV;


    }
}
