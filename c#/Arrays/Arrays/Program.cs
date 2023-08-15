using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array de 1 dimensão
            int[] Array1 = new int[3];
            Array1[0] = 1;
            Array1[1] = 10;
            Array1[2] = 100;

            Console.WriteLine(Array1[0]);
            Console.WriteLine(Array1[1]);
            Console.WriteLine(Array1[2]);

            //Outras maneiras de criar Array
            int[] Array2 = {1, 10, 100};
            Console.WriteLine(Array2[0]);
            Console.WriteLine(Array2[1]);
            Console.WriteLine(Array2[2]);

            int[] Array3 = new int[] {1, 10, 100};
            Console.WriteLine(Array3[0]);
            Console.WriteLine(Array3[1]);
            Console.WriteLine(Array3[2]);

            //ARRAY 2 DIMENSÕES
            string[ , ] Array4 = new string[2,3]; //1º dimensao, 2º dimensao
            Array4[0, 0] = "1";
            Array4[0, 1] = "2";
            Array4[0, 2] = "3";
            Array4[1, 0] = "11";
            Array4[1, 1] = "12";
            Array4[1, 2] = "13";

            Console.WriteLine(Array4[0, 0]);
            Console.WriteLine(Array4[0, 1]);
            Console.WriteLine(Array4[0, 2]);
            Console.WriteLine(Array4[1, 0]);
            Console.WriteLine(Array4[1, 1]);
            Console.WriteLine(Array4[1, 2]);

            //Outras maneiras de inicializar um array de duas dimensões
            string[ , ] Array5 = { {/*1º dimensão*/ "1", "2", "3" }, {/*2º dimensão*/ "11", "12", "13" } };
            Console.WriteLine(Array5[0, 0]);
            Console.WriteLine(Array5[0, 1]);
            Console.WriteLine(Array5[0, 2]);
            Console.WriteLine(Array5[1, 0]);
            Console.WriteLine(Array5[1, 1]);
            Console.WriteLine(Array5[1, 2]);

            string[,] Array6 = new string[,] { {/*1º dimensão*/ "1", "2", "3" }, {/*2º dimensão*/ "11", "12", "13" } };
            Console.WriteLine(Array6[0, 0]);
            Console.WriteLine(Array6[0, 1]);
            Console.WriteLine(Array6[0, 2]);
            Console.WriteLine(Array6[1, 0]);
            Console.WriteLine(Array6[1, 1]);
            Console.WriteLine(Array6[1, 2]);

            //Numero de elementos do array
            int tamanho1 = Array6.GetLength(0);
            int tamanho2 = Array6.GetLength(1);
            Console.WriteLine("A primeira dimensão do Array6 possui: " + tamanho1 + " elementos");
            Console.WriteLine("A segunda dimensão do Array6 possui: " + tamanho2 + " elementos");

            //Array 3 dimensões
            int[,,] Array7 = new int[2, 2, 2];
            Array7[0,0,0] = 10;

            Console.ReadKey();
        }
    }
}
