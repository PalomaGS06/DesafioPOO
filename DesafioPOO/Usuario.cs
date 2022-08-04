using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public abstract class Usuario
    {
        protected int Id;
        protected string Nome { get; set; }
        protected string Email { get; set; }
        protected string Senha { get; set; }
        protected int Telefone { get; set; }

        public void Cadastrar ()
        {
            Console.WriteLine("Usuário Cadastrado!");
        }

        public bool FazerLogin (string email, int id, string senha)
        {
            Email = email;
            Id = id;
            Senha = senha;

            return true;
        }


    }
}
