using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjetoConsole
{
    internal class Program //classe
    {
        static void Main(string[] args) //Método: tudo roda aqui
        {
            Console.WriteLine("Ola mundo!");

            Console.WriteLine("Digita linha por linha");
            Console.Write("\r\n"); //pula linha
            Console.Write("Digita");
            Console.Write(" na mesma ");
            Console.Write("linha");
            Console.ReadKey(); //aguarda tecla
        }
    }
}
