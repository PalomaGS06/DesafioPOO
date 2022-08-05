using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public abstract class Usuario
    {
        protected int Id;
        public string Nome { get; set; }
        protected string Email { get; set; }
        public string Senha { get; set; }
        protected int Telefone { get; set; }

        public void Cadastrar ()
        {
            Console.Write("Insira seu CPF, só com números: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Insira seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Insira seu email: ");
            Email = Console.ReadLine();

            Console.Write("Insira uma senha: ");
            Senha = Console.ReadLine();

            Console.Write("Insira seu contato com o DDD: ");
            Telefone = int.Parse(Console.ReadLine());

                        
            Console.WriteLine("Usuário Cadastrado!");
            Thread.Sleep(55000);
        }

        public bool FazerLogin ( string nome, string senha)
        {

            if (nome == Nome && senha == Senha)
            {
                Console.WriteLine("Usuário conectado com sucesso!");
                return true;
            }
            else
            {
                Console.WriteLine("Nome ou senha inválidos, por favor, tente novamente!");
            }

            return false;
        }


    }
}
