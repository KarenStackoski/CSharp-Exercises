using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu Nome: ");
            string Nome = Console.ReadLine(); //tudo será armazenado como string
            Console.WriteLine("Olá " + Nome + " !"); //concatenar

            Console.WriteLine("Digite a sua Idade: ");
            string Idade = Console.ReadLine();
            Console.WriteLine("Você tem " + Idade + " anos.");

            int IdadeInt = Convert.ToInt32(Idade);

            Console.WriteLine("Pressione qualquer tecla!");
            char Tecla = Console.ReadKey(true).KeyChar; //lê a tecla pressionada
                                                        // true esconde a tecla pressionada

            // convertendo char p/ string
            string TeclaString = Convert.ToString(Console.ReadKey(true).KeyChar);

            Console.WriteLine("Olá, a tecla que você pressionou foi: " + Tecla);

            Console.WriteLine("Pressione qualquer tecla para sair.");

            Console.ReadKey();
        }
    }
}
