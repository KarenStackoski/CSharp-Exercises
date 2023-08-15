using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcessoes
{   //Excesão são erros que interrompem o programa
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int i = Convert.ToInt32(Console.ReadLine());
            
            try //obrigatório - sempre será executado
            {
                int resultado = 10 / i;
                Console.WriteLine("Resultado da divisão: " + resultado);
            }
            catch (DivideByZeroException e) //obrigatório - apenas executado em caso de excessão
            {
                Console.WriteLine("Exeção: " + e.Message);
            }
            catch (Exception e) //bloco genérico, qualquer erro
            {
                Console.WriteLine("Exceção genérica: " + e.Message);
            }
            finally //opcional - sempre será executado
            {
                Console.WriteLine("Pressione qualquer tecla para sair: ");
                Console.ReadKey();
            }
                      
        }
    }
}
