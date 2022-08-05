using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesafioPOO
{
    public class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public int Agencia { get; set; }
        public string Banco { get; set; }
        
        public ContaBancaria(){ }
            public ContaBancaria(int _numero, int _agencia, string _banco)
        {
            NumeroConta = _numero;
            Agencia = _agencia;
            Banco = _banco;
        }

    }
}
