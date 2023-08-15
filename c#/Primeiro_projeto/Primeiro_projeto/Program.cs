using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            UInt16 Idade = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Digite o número do seu documento: ");
            string Documento = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua rua: ");
            string Rua = Console.ReadLine();

            Console.WriteLine("Digite o número da casa: ");
            UInt32 Casa = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Informe o seu gênero. Pressione F para Feminino e M para Masculino.");
            string Genero = Console.ReadKey(true).KeyChar.ToString(); //convertendo p/ string o readkey

            Console.WriteLine("Olá " + Nome);
            Console.WriteLine("Você tem " + Idade + " anos de idade.");
            Console.WriteLine("O número do documento informado é " + Documento);
            Console.WriteLine("O número da rua é " + Rua);
            Console.WriteLine("O número da casa é " + Casa);
            Console.WriteLine("O seu gênero é " + Genero);

            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey();
        }
    }
}
