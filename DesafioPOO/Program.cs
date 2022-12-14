using System;
using System.Collections.Generic;
using System.Threading;

namespace DesafioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Titulo();

            string userLogin;
            string senhaLogin;
            Passageiro passenger; 

          

          
            // Dados de Login e Senha para o usuário preencher
            //do
            //{
            //    Console.Write("Login:  ");
            //    userLogin = Console.ReadLine();

            //    Console.Write("Senha:  ");
            //    senhaLogin = Console.ReadLine();

             passenger = new Passageiro(_id: 463465256, _nome: "Bilbo", _email: "bilbobaggins@gmail.com", _senha: "naosouladrao", _telefone: 952529014);    

            //} while (!passenger.FazerLogin(userLogin, senhaLogin));



                List < Motorista > motorista = new List<Motorista>();

                Automovel carro = new Automovel(_placa: "ABC1234", _cor: "Branco", _modelo: "CRV", _marca: "Honda");
                ContaBancaria conta = new ContaBancaria(656526, 56, "Bradesco");
                Motorista m2 = new Motorista(6156894, "Gandalf", "gandalfmago@gmail.com", "mithrandir", 9558648, carro, conta);
                motorista.Add(m2);
                carro = new Automovel("EFG4896", "Prata", "HB20", "Hyundai");
                conta = new ContaBancaria(465456, 015, "Santander");
                Motorista m3 = new Motorista(2985652, "Thranduil", "thranduilflorest@gmail.com", "vaidoso", 561615663, carro, conta);
                motorista.Add(m3);
                carro = new Automovel("AFE645", "Branco", "Focus", "Ford");
                conta = new ContaBancaria(22395, 05, "Nubank");
                Motorista m4 = new Motorista(6859256, "Legolas", "elfofoda@gmail.com", "ninjadaflecha", 64565659, carro, conta);
                motorista.Add(m4);
                carro = new Automovel("OIJ9581", "Cinza", "qq", "Chery");
                conta = new ContaBancaria(626186, 84, "C6 Bank");
                Motorista m5 = new Motorista(5926854, "Thorin", "thorinsonthrain@gmail.com", "escudodecarvalho", 5968695, carro, conta);
                motorista.Add(m5);
                carro = new Automovel("VKO5695", "Branco", "Lancer", "Mitsubishi");
                conta = new ContaBancaria(392451, 72, "Next");
                Motorista m6 = new Motorista(172142, "Galadriel", "elfaforte@gmail.com", "elfadeRivendell", 52649985, carro, conta);
                motorista.Add(m6);

                passenger.EndOrigem = new Endereco(13216516, "rua Shire", 43, "Villa dos Hobbit", "Aukland", "Welligton", "New Zealand");
                passenger.EndDestino = new Endereco(132216, "rua Erebor", 65, "Gondor", "Aukland", "Welligton", "New Zealand");

                Dinheiro dinheiro = new Dinheiro();
                passenger.pagar.Add(FormaPagamento.Dinheiro);


                bool exit = false;

                Console.Write("\n\n\n\nIniciando  ");
                Thread.Sleep(1000);
                Console.Write("☺");
                Thread.Sleep(1000);
                Console.Write("☻");
                Thread.Sleep(1000);
                Console.Write("☺");
                Thread.Sleep(1000);
                Console.Write("☻");
                Thread.Sleep(1000);
                Console.Write("☺");
                Thread.Sleep(1000);
                Console.Write("☻");
                Thread.Sleep(1000);

                Console.Clear();
                Titulo();

                Console.Write($"\n\n\nBem-Vindo(a) {passenger.Nome} !!");

                do
                {
                    string escolher;

                    Console.Write($"\n\nSelecione uma opção desejada: \n" +
                        $"\n1 - Solicitar corrida" +
                        $"\n2 - Adicionar cartão" +
                        $"\n3 - Sair:  \n\n ");
                    escolher = Console.ReadLine();

                    while (escolher != "1" && escolher != "2" && escolher != "3")
                    {
                        Console.Write("\n Opção inválida. Tente outra vez:   ");
                        escolher = Console.ReadLine();
                    }

                    if (escolher == "3")
                    {
                        break;
                    }
                    else if (escolher == "2")
                    {
                        passenger.AdicionarCartao(62915456, "Bilbo", new DateTime(2025, 05, 21), 261);
                        continue;
                    }
                    else
                    {
                        passenger.SolicitarDestino(passenger.EndOrigem, passenger.EndDestino, passenger, motorista, passenger.pagar);
                    }

                    Console.Clear();

                    Titulo();

                    Console.Write("\nDeseja sair?\n" +
                        "\n1 - Sim" +
                        "\n2 - Não:\n\n    ");
                    escolher = Console.ReadLine();

                    while (escolher != "1" && escolher != "2")
                    {
                        Console.Write("\nOpção inválida. Tente outra vez (1- Sim, 2- Não):\n\n ");
                        escolher = Console.ReadLine();
                    }

                    if (escolher == "1")
                    {
                        break;
                    }

                    if (escolher == "2")
                    {
                        exit = false;
                    }
                    else
                    {
                        exit = false;
                    }

                    Console.Clear();

                } while (!exit);

                Console.Clear();
                Titulo();
                Console.WriteLine("Obrigado por usar Nopein!");


            }

            static void Titulo()
            {

                for (int x = 0; x < Console.WindowWidth / 2; x++)
                {
                    Console.Write("<>");
                }

                Console.WriteLine("  ");

                //Título centralizado na coloração azul claro
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($" ☺ NOPEIN ☻ \n".PadLeft(73, ' '));
                Console.ResetColor();

                //Linhas centralizadas sublinhando o título
                Console.Write($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n".PadLeft(83, ' '));

            


        }

    }
}
