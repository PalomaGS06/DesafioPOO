using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesafioPOO.Corrida;

namespace DesafioPOO
{
    public class Viagem
    {
        public Endereco EndOrigem;
        public Endereco EndDestino;
        public float ValorCorrida = 23.91f;
        public Passageiro passageiro;
        public Motorista motorista;
        public Status statusviagem;

        public void SolicitarDestino (Endereco partida, Endereco chegada)
        {
            Console.WriteLine($"Origem: {partida} ");
            Console.WriteLine($"Destino: {chegada} ");
        }

    }
}
