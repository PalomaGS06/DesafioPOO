using System;

namespace DesafioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Passageiro passenger = new Passageiro();
         passenger.Nome = " ";

            Console.Write("Login: ");
            string userLogin = Console.ReadLine();

            Console.WriteLine("Senha: ");
            string senhaLogin = Console.ReadLine();

           bool Logar(string userLogin, string senhaLogin)
            {
                bool valido = false;
                bool valido1 = false;
                bool valido2 = false;

                if (userLogin == passenger.Nome)
                {
                    valido1 = true;
                }

                if (senhaLogin == passenger.Senha)
                {
                    valido2 = true;
                }

                if (valido1 && valido2)
                {
                   valido= true;
                }
                return valido;
            }


        }
    }
}
