using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Motorista : Usuario
    {
        public ContaBancaria Conta { get; set; }
        public Automovel TipoTransporte { get; set; }

        public void NomeMotorista()
        {
            
        }

        public void DescricaoVeiculo()
           
        {

        }
        public void PagarMotorista(float valor)

        {

        }
        public bool ReceberPedidoViagem()

        {
            return true;
        }

    }
}
