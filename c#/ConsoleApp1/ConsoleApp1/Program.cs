using System;
using System.Collections.Generic;

namespace CadastroClientes
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();

            while (true)
            {
                
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("3 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite o nome do cliente:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite o endereço do cliente:");
                    string endereco = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do cliente:");
                    string telefone = Console.ReadLine();

                    Console.WriteLine("Digite o email do cliente:");
                    string email = Console.ReadLine();

                    Cliente cliente = new Cliente
                    {
                        Nome = nome,
                        Endereco = endereco,
                        Telefone = telefone,
                        Email = email
                    };

                    clientes.Add(cliente);

                    Console.WriteLine("Cliente cadastrado com sucesso!");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Lista de clientes:");

                    foreach (Cliente cliente in clientes)
                    {
                        Console.WriteLine($"Nome: {cliente.Nome}");
                        Console.WriteLine($"Endereço: {cliente.Endereco}");
                        Console.WriteLine($"Telefone: {cliente.Telefone}");
                        Console.WriteLine($"Email: {cliente.Email}");
                        Console.WriteLine("----------------------------");
                    }
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }

                Console.WriteLine();
            }
        }
    }
}
