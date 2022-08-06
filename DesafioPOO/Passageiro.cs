using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Passageiro : Usuario
    {
        public Endereco EndOrigem { get; set; }
        public Endereco EndDestino { get; set; }
        public FormaPagamento Pagamento { get; set; }
        public TipoCartao Cartao { get; set; }


        public List<FormaPagamento> pagar = new List<FormaPagamento>();

        public Passageiro() { }

        public Passageiro(int _id, string _nome, string _email, string _senha, int _telefone)
        {
            Id = _id;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            Telefone = _telefone;
        }

        public Viagem viajar = new Viagem();


        public void SolicitarDestino(Endereco partida, Endereco chegada, Passageiro _passageiro, List<Motorista> _motorista, List<FormaPagamento> _pagamento)
        {
            bool exit = false;


            do
            {
                Console.Clear();

                Titulo();

                viajar.passageiro = _passageiro;

                //Console.Write("Informar seu endereço de origem:   ");
                //string origem = Console.ReadLine();
                //viajar.EndOrigem = partida;

                //Console.Write("\nInformar seu endereço de destino:    ");
                //string destino = Console.ReadLine();
                //viajar.EndDestino = chegada;


                Console.Write($"\nO valor da corrida ficará em  R$:{viajar.ValorCorrida}. Deseja Confirmar?\n" +
                              $"\n1 - Sim" +
                              $"\n2 - Não: \n\n ");

                string escolher = Console.ReadLine();


                while (escolher != "1" && escolher != "2")
                {
                    Console.Write("\nOpção inválida. Tente outra vez (1- Sim, 2- Não):  \n\n ");
                    escolher = Console.ReadLine();
                }

                if (escolher == "2")
                {
                    break;
                }
                else
                {

                    do
                    {
                        Console.Clear();

                        Titulo();

                        Console.WriteLine($"Valor da Corrida: R$:{viajar.ValorCorrida}.\n" +
                                          $"\nEscolha uma forma de pagamento de sua preferência:  ");


                        Console.Write("\n\n1 Cartão " +
                                      "\n2 - Dinheiro " +
                                      "\n3 - Pix :\n\n ");
                        escolher = Console.ReadLine();


                        Dinheiro dinheiro = new Dinheiro();
                        Pix pix = new Pix();


                        switch (escolher)
                        {
                            case "1":
                                Console.Write("\n\nEscolha o tipo de cartão :  \n\n");
                                Console.Write("\n1 - Débito:  \n2 - Crédito:\n\n");
                                escolher = Console.ReadLine();

                                if (escolher == "1")
                                {
                                    Console.WriteLine(TipoCartao.Cartoes.Debito);
                                    exit = true;
                                }
                                else if (escolher == "2")
                                {
                                    Console.WriteLine(TipoCartao.Cartoes.Credito);
                                    exit = true;
                                }
                                else
                                {
                                    Console.WriteLine("Cartão inválido! ");
                                }
                                break;


                            case "2":
                                Console.WriteLine(FormaPagamento.Dinheiro);
                                exit = true;
                                break;

                            case "3":

                                Console.WriteLine(FormaPagamento.Pix);
                                Console.Clear();
                                //cabecalho.Cabecalho("Nova Viagem");
                                pix.Pagar();
                                Thread.Sleep(3000);
                                Console.WriteLine("\n Pagamento efetuado. Aperte qualquer tecla para começar sua corrida!");
                                Console.ReadKey();

                                exit = true;
                                break;

                            default:

                                Console.WriteLine("\n\nOpção inválida. Tente novamente.");
                                Thread.Sleep(2000);
                                exit = false;
                                break;

                        }
                    } while (!exit);
                   

                    Console.Clear();


                    viajar.statusviagem = Corrida.Status.Aguardando;
                    Console.WriteLine("\n");
                    Titulo();

                    Console.WriteLine("Endereço de origem: ");
                    Console.WriteLine(_passageiro.EndOrigem);

                    Console.WriteLine("Endereço de destino: ");
                    Console.WriteLine(_passageiro.EndDestino);

                    Console.Write("Procurando motorista!  ");
                    Thread.Sleep(800);
                    Console.Write("☺");
                    Thread.Sleep(800);
                    Console.Write("☻");
                    Thread.Sleep(800);
                    Console.Write("☺");
                    Thread.Sleep(800);
                    Console.Write("☻");
                    Thread.Sleep(800);
                    Console.Write("☺");
                    Thread.Sleep(800);


                    viajar.statusviagem = Corrida.Status.Encontrado;
                    Console.WriteLine("\n\nMotorista encontrado! \n");
                    Thread.Sleep(1500);


                    Random random = new Random();
                    int MotoristaAleatorio = random.Next(0, _motorista.Count);
                    viajar.motorista = _motorista[MotoristaAleatorio];
                    Console.Write($"Seu motorista é: {_motorista[MotoristaAleatorio].Nome}\nCarro: {_motorista[MotoristaAleatorio].TipoTransporte.Modelo}, {_motorista[MotoristaAleatorio].TipoTransporte.Marca} \nPlaca: {_motorista[MotoristaAleatorio].TipoTransporte.Placa}\nCor: {_motorista[MotoristaAleatorio].TipoTransporte.Cor}\n\n");
                    Thread.Sleep(3000);

                    viajar.statusviagem = Corrida.Status.Iniciada;
                    Console.Write("\n\nO motorista chegou ao destino! ");
                    Thread.Sleep(5000);

                    viajar.statusviagem = Corrida.Status.Andando;
                    Console.Write("\n\nViagem em percurso ");
                    Thread.Sleep(1500);
                    Console.Write("☺");
                    Thread.Sleep(1500);
                    Console.Write("☻");
                    Thread.Sleep(1500);
                    Console.Write("☺");
                    Thread.Sleep(1500);
                    Console.Write("☻");
                    Thread.Sleep(1500);

                    viajar.statusviagem = Corrida.Status.Finalizada;
                    Console.Write("\n\nParabéns! Você chegou ao seu destino! Lembre-se de pegar seus pertences antes de sair do veículo!\n\n\n  ");
                    Thread.Sleep(8000);

                    Console.Clear();

                    Titulo();

                    Console.Write("Obrigado por viajar conosco!\n\n");

                    exit = true;

                }

            } while (!exit);

        }

        public void AdicionarCartao(int numero, string nome, DateTime validade, int cvv)
        {

            bool exit = false;

            Cartao = new TipoCartao();

            Cartao.EscolherCartao(numero, nome, validade, cvv);

            do
            {
                Console.Clear();

                Titulo();

                Console.Write($"DADOS do Cartão:\n\n" +
                                  $"{Cartao}");


                Console.Write("Deseja confirmar seus dados?\n" +
                              "\n1 - Sim" +
                              "\n2 - Não:  \n\n ");
                string escolher = Console.ReadLine();

                while (escolher != "1" && escolher != "2")
                {
                    Console.Write("\nOpção inválida. Tente outra vez... ");
                    escolher = Console.ReadLine();
                }

                if (escolher == "1")
                {
                    exit = true;
                }
                else
                {
                    Console.Write("\n\nCancelar o cartão adicional?\n" +
                                  "\n1 - Sim" +
                                  "\n2 - Não :  \n\n ");
                    escolher = Console.ReadLine();

                    while (escolher != "1" && escolher != "2")
                    {
                        Console.Write("\nOpção inválida. Tente novamente (1 - Sim, 2 - Não):\n\n ");
                        escolher = Console.ReadLine();
                    }

                    if (escolher == "1")
                    {
                        Console.Clear();

                        Titulo();

                        break;
                    }

                    else
                    {
                        exit = false;
                    }

                }

                Console.Clear();
                Titulo();

            } while (!exit);
        }

        public static void Titulo()
        {

            for (int x = 0; x < Console.WindowWidth / 2; x++)
            {
                Console.Write("<>");
            }

            Console.WriteLine("  ");

            //Título centralizado na coloração azul claro
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"  NOPEIN  \n".PadLeft(73, ' '));
            Console.ResetColor();

            //Linhas centralizadas sublinhando o título
            Console.Write($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n".PadLeft(83, ' '));

        }


    }
}
