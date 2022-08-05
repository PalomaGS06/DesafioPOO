using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Viagem
    {
        public float ValorCorrida = 23.90f;
        public Passageiro _passageiro;
        public Motorista _motorista;
        public Corrida.Status statusviagem;

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
