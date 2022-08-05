using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Passageiro : Usuario
    {
        public Endereco EndOrigem { get; set; }
        public Endereco EndDestino { get; set; }
        public FormaPagamento Pagamento { get; set; }

        //bool Logar(string userLogin, string senhaLogin)
        //{
        //    bool valido = false;
        //    bool valido1 = false;
        //    bool valido2 = false;

        //    if (userLogin == passenger.Nome)
        //    {
        //        valido1 = true;
        //    }

        //    if (senhaLogin == passenger.Senha)
        //    {
        //        valido2 = true;
        //    }

        //    if (valido1 && valido2)
        //    {
        //        valido = true;
        //    }
        //    return valido;
        //}


        Endereco adress = new Endereco();
    

        public void SolicitarDestino (Endereco partida, Endereco chegada)
        {
            EndOrigem = partida;
            EndDestino = chegada;
        }

        public void AdicionarPagamento()
        {
            Console.Write("Qual sua forma de pagamento? ");
        }


    }
}
