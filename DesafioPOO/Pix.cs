using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
     public class Pix
    {
        private string ChaveTipo { get; set; }
        private string Chave { get; set; }

        private string GerarChave { get; set; }

        public int tamanho { get; set; }


        public FormaPagamento Dinheiro;

        public void Pagar()
        {
                        
            Console.WriteLine("Você deseja gerar uma chave? (S/N)!");
            GerarChave = Console.ReadLine().ToUpper();

            while (GerarChave != "S" && GerarChave != "N")
            {
                Console.Write("\nOpção inválida. Tente novamente (S - Sim, N - Não):\n\n ");
                GerarChave = Console.ReadLine();
            }
            if (GerarChave.ToUpper() == "S")
            {
                
                Random random = new Random();

                Console.WriteLine($"Código gerado: {GerarCodigo("LKJKA32165D")}");
                //const string codigo = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&.";
                //new string(Enumerable.Repeat(codigo, tamanho)
                //                 .Select(s => s[random.Next(s.Length)]).ToArray());

                //RandomString(64);


               //Console.WriteLine("Chave gerada: {0}", random.GetHashCode());

            }
            else if (GerarChave.ToUpper() == "N")
            {
                Console.Write("Insira sua chave Pix (Ex: CPF, Email, Telefone): ");
                ChaveTipo = Console.ReadLine();

                Console.WriteLine("Pagamento Concluído!");
            }

     

    }
        public string GerarCodigo(string valor)
        {
            MD5 md5Hasher = MD5.Create();            
            byte[] valorCriptografado = md5Hasher.ComputeHash(Encoding.Default.GetBytes(valor));
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < valorCriptografado.Length; i++)
            {
                strBuilder.Append(valorCriptografado[i].ToString("X3"));
            }
            return strBuilder.ToString();
        }


    }
}
