using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_decisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade: ");
            UInt32 Idade = Convert.ToUInt32(Console.ReadLine());
            //if ... else
            if(Idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você não é maior de idade.");
            }
            //else opcional

            Console.WriteLine("Digite o seu salário: ");
            UInt32 Salario = Convert.ToUInt32(Console.ReadLine());
            //if ... else ... if
            if(Salario < 1000)
            {
                Console.WriteLine("Você ganha menos que um salário mínimo!");
            }
            else if(Salario < 2000)
            {
                Console.WriteLine("Você ganha menos que dois salários mínimos!");
            }
            else if(Salario < 5000)
            {
                Console.WriteLine("Você ganha menos que cinco salários mínimos!");
            }
            else
            {
                Console.WriteLine("Você é rico!!!");
            }

            Console.WriteLine("Pressione uma tecla: ");
            char tecla = Console.ReadKey(true).KeyChar;
            //switch(comutador)
            switch(tecla) //variavel
            {
                case 'a': //variavel
                    Console.WriteLine("Você pressionou a.");
                    break;
                case 'b':
                    Console.WriteLine("Você pressionou b.");
                    break;
                default: //padrão - opcional. tipo else
                    Console.WriteLine("Eu não conheço essa tecla!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
