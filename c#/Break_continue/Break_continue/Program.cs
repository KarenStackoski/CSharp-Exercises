using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pressione C p/ continue");
                Console.WriteLine("Pressione B p/ break");
                string tecla = Console.ReadKey(true).KeyChar.ToString();
                if(tecla == "c")
                {
                    continue; //interrompe a execução atual e começa novo loop
                }else if(tecla == "b")
                {
                    break; //interrompe qualquer loop
                }
                else
                {
                    Console.WriteLine("Tecla desconhecida!");
                }
                Console.WriteLine("Pressione qualquer tecla p/ continuar");
                Console.ReadKey();
                Console.Clear(); //limpar console
            }
            Console.WriteLine("Pressione qualquer tecla p/ sair:");
            Console.ReadKey();
        }
    }
}
