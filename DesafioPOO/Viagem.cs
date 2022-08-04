using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Viagem
    {
        private float ValorCorrida { get; set; }

        public void SolicitarDestino (Endereco partida, Endereco chegada)
        {
            Console.WriteLine($"Origem: {partida} ");
            Console.WriteLine($"Destino: {chegada} ");
        }

        public void PagarMotorista(float valor)

        {

        }
    }
}
