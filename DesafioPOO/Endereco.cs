using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Endereco
    {
        public int CEP;
        public string Rua;
        public int Numero;
        public string Bairro;
        public string Cidade;
        public string Estado;
        public string Pais;

        public Endereco(int cep, string rua, int numero, string bairro, string cidade, string estado, string pais)
        {
            CEP = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }

        public override string ToString()
        {
            return $"\n CEP: {CEP}\n Rua: {Rua}\n Número: {Numero}\n Bairro: {Bairro}\n Cidade: {Cidade}\n Estado: {Estado}\n País: {Pais}\n";
        }
    }
}
