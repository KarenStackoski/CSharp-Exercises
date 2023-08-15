using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terceiro_projeto
{
    internal class Program
    {
        /*
            Melhoria do projeto de login:
            * cadastrar inúmeros usuários;
            * S = SAIR; C = CADASTRAR;
            * Solicitar nome completo, Gênero (M/F), data de nascimento (dd/mm/aaaa), nome da rua, nº casa
        */
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Pressione S p/ sair ou C para cadastrar: ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    //cadastro
                    Console.WriteLine("Digite o seu nome completo: ");
                    string nomeCompleto = Console.ReadLine();
                    Console.WriteLine("Informe o seu gênero (F/M): ");
                    char genero = Console.ReadKey(true).KeyChar;
                    Console.WriteLine("Digite sua data de nascimento: ");
                    DateTime nascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Digite o nome da Rua: ");
                    string rua = Console.ReadLine();
                    Console.WriteLine("Digite o nº da casa: ");
                    UInt32 casa = Convert.ToUInt32(Console.ReadLine());
                    Console.Clear();
                }else if(opcao == "s")
                {
                    //sair
                    Console.WriteLine("Encerrando o programa...");
                }
                else
                {
                    Console.WriteLine("Opção desconhecida!!!");
                }
            }while (opcao != "s");
            Console.WriteLine("Pressione qualquer tecla p/ sair");
            Console.ReadKey();
        }
    }
}
