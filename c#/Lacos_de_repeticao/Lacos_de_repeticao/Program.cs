using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacos_de_repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Laço for
            for(/*inicialização da variável*/ int i = 0;/*condição*/ i < 10;/*alteração da variável*/ i++)
            {
                Console.WriteLine(i);
            }

            //Laço while
            int j = 0;
            while (/*condição*/ j < 100)
            {
                Console.WriteLine("Bom dia!");
                j += 10; //alteração
            }

            //Laço do ... while
            int k = 0;
            do
            {
                Console.WriteLine(":)");
                k++;
            } while (/*condiçao*/ k < 10);

            //Laço foreach
            string[] nomes = {"Karen","João","Maria"};
            foreach(string nome in nomes/*funcionamento do array*/)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();
        }
    }
}
