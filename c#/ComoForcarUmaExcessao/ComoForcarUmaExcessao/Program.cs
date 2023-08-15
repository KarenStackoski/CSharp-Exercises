using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComoForcarUmaExcessao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escreva um número positivo: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if(num<0)
                {
                    throw new Exception("Número é menor que zero!!!"); //forçando uma excessão
                }
                else
                {
                    Console.WriteLine("Você digitou: " + num);
                }
                
            }catch (Exception ex)
            {
                Console.WriteLine("Excessão: " + ex.Message);
            }
            finally 
            {
                Console.WriteLine("Pressione qualquer tecla para continuar: ");
                Console.ReadKey();
            }
        }
    }
}
