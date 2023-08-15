using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione A para alugar um filme ou S para sair da locadora: ");
            char opcao = Console.ReadKey(true).KeyChar;
            if(opcao == 'a' || opcao == 'A')
            {
                //alugar filme
                Console.WriteLine("Pressione 1 para alugar Top Gun");
                Console.WriteLine("Pressione 2 para alugar A Bela e a Fera");
                Console.WriteLine("Pressione 3 para alugar O Homem Aranha");
                int opcaoFilme = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());

                switch(opcaoFilme)
                {
                    case 1:
                        Console.WriteLine("Você alugou Top Gun!");
                        break;
                    case 2:
                        Console.WriteLine("Você alugou A Bela e a Fera!");
                        break;
                    case 3:
                        Console.WriteLine("Você alugou O Homem Aranha!");
                        break;
                }
            }
            else if(opcao == 's' || opcao == 'S')
            {
                //sair
                Console.WriteLine("Muito obrigado, volte sempre!");
            }
            else
            {
                //opção desconhecida
                Console.WriteLine("Opção desconhecida!");
            }

            Console.ReadKey();
        }
    }
}
