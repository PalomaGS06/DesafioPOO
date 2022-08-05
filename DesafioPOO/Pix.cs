using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
     public class Pix
    {
        private string ChaveTipo { get; set; }
        private char Chave { get; set; }

        private string GerarChave { get; set; }

        public int tamanho { get; set; }


        public FormaPagamento Dinheiro;

        public void Pagar()
        {
            Console.Write("Insira qual tipo da sua chave (Ex: CPF, Email, Telefone): ");
            ChaveTipo = Console.ReadLine();

            Console.Write("Insira sua chave: ");
            Chave = char.Parse(Console.ReadLine());

            Console.WriteLine("Ou deseja gerar uma chave? (S/N)!");
            GerarChave = Console.ReadLine();
            
            if (GerarChave.ToUpper() == "S")
            {
                
                Random random = new Random();

                
                const string codigo = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&.";
                new string(Enumerable.Repeat(codigo, tamanho)
                                 .Select(s => s[random.Next(s.Length)]).ToArray());

                RandomString(64);


               // Console.WriteLine("The hash code of object is: {0}", random.GetHashCode());

            }
            else if (GerarChave.ToUpper() == "N")
            {
                Console.WriteLine("Pagamento Concluído!");
            }



    }

        private void RandomString(int v)
        {
            throw new NotImplementedException();
        }
    }
}
