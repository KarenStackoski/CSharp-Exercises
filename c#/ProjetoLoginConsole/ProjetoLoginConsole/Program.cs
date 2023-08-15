using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLoginConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite o usuário: ");
                string usuario = Console.ReadLine();
                Console.WriteLine("Digite a sua senha: ");
                string senha = "";
                while (true)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    else
                    {
                        senha += tecla.KeyChar;
                    }
                }
                if (usuario == "Karen" & senha == "1234")
                {
                    Console.WriteLine("Usuário válido");
                    break;
                }
                else
                {
                    Console.WriteLine("Usuário e senha inválidos!");
                    Console.WriteLine("Pressione qualquer tecla p/ continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("Pressione qualquer tecla p/ sair");
            Console.ReadKey();  
        }
    }
}
