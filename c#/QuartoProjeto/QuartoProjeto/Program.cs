using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QuartoProjeto
{   // EVOLUÇÃO DO CADASTRO DE USUÁRIOS
    internal class Program
    {
        struct DadosCadastrais_Struct
        {
            public string nome;
            public string nomeRua;
            public UInt32 numCasa;
            public string numDocumento;
        };
        static void Main(string[] args)
        {
            List<DadosCadastrais_Struct> ListaDeCadastros = new List<DadosCadastrais_Struct>();
            string opcao;

            do
            {
                Console.WriteLine("Digite C para cadastrar ou S para sair:");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    //cadastro
                    DadosCadastrais_Struct dados; //vai receber os dados p/ a struct
                    Console.WriteLine("Digite seu nome: ");
                    dados.nome = Console.ReadLine();
                    Console.WriteLine("Digite o nome da rua: ");
                    dados.nomeRua = Console.ReadLine();
                    Console.WriteLine("Digite o número da casa: ");
                    dados.numCasa = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("Digite o Número do documento: ");
                    dados.numDocumento = Console.ReadLine();
                    ListaDeCadastros.Add(dados); //adicionando na lista os dados cadastrados

                    Console.Clear();
                }
                else if (opcao == "s")
                {
                    //encerrar
                    Console.WriteLine("Encerrando a aplicação...");
                }
                else
                {
                    Console.WriteLine("Opção Desconhecida");
                }
            } while (opcao != "s"); //enquanto opcao for diferente de else

            Console.WriteLine("Digite qualquer tecla p/ sair: ");
            Console.ReadKey();
        }
    }
}
