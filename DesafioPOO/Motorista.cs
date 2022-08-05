using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Motorista : Usuario
    {
        private ContaBancaria Conta = new ContaBancaria();
        public Automovel TipoTransporte = new Automovel();

        public Motorista()
        {         
        }
        public Motorista(int _id, string _nome, string _email, string _senha, int _telefone, Automovel _tipoveiculo, ContaBancaria _conta)
        {
            Id = _id;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            Telefone = _telefone;
            TipoTransporte = _tipoveiculo;
            Conta = _conta;
        }

        public void DescricaoVeiculo()
           
        {
            Console.Write("\nPor favor, insira os dados do veículo abaixo: ");

            Console.Write("\nPlaca:   ");
            TipoTransporte.Placa = Console.ReadLine();

            Console.Write("\nCor:   ");
            TipoTransporte.Cor = Console.ReadLine();

            Console.Write("\nModelo:   ");
            TipoTransporte.Modelo = Console.ReadLine();

            Console.Write("\nMarca:   ");
            TipoTransporte.Marca = Console.ReadLine();

            Console.WriteLine("Veículo cadastrado com sucesso!");
        }
        public void PagarMotorista(float valor)

        {
            Console.Write("\nPor favor, insira os dados da conta abaixo: ");
            Console.Write("\nNúmero da conta:   ");
            Conta.NumeroConta = int.Parse (Console.ReadLine());

            Console.Write("\nAgência:     ");
            Conta.Agencia = int.Parse(Console.ReadLine());

            Console.Write("\nBanco:     ");
            Conta.Banco = Console.ReadLine();

            Console.WriteLine("Dados cadastrados com sucesso!");
        }
        public bool ReceberPedidoViagem()

        {
            return true;
        }

    }
}
