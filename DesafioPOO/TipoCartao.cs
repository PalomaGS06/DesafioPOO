using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class TipoCartao : Cartao
    {


     public enum Cartoes
        {
            Debito,
            Credito
        }

        public void EscolherCartao(int numero , string nome, DateTime validade, int cvv)
        {
            NumeroCartao = numero;
            NomeTitular = nome;
            Validade = validade;
            CVV = cvv;

        }



        public void EscolherDebito( float Saldo, float Valor)
        {
            Console.WriteLine(Cartoes.Debito);
             Saldo -= Valor;
             
        }

        public void EscolherCredito(float Limite, float Valor)
        {
            {
                Console.WriteLine(Cartoes.Credito);
                Limite -= Valor;
            }
            
        }

        public override string ToString()
        {
            return $"Número do cartão: {NumeroCartao}\nNome: {NomeTitular}\nValidade: {Validade}\nCVV: {CVV}\n  ";
        }
    }
}
