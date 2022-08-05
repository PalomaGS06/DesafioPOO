using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Automovel
    {
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        public Automovel(string _placa, string _cor, string _modelo, string _marca )
        {
            Placa = _placa;
            Cor = _cor;
            Modelo = _modelo;
            Marca = _marca;
        }
    }
}
