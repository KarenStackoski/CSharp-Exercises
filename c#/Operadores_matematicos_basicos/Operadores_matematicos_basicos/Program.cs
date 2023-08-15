using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_matematicos_basicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soma +
            double num1 = 15.5;
            double num2 = 10;
            double resultadoSoma = num1 + num2;
            Console.WriteLine("O resultado da some entre " + num1 + " e " + num2 + " é: " + resultadoSoma);
                      
            //Subtração -
            double resultadoSub = num1 - num2;
            Console.WriteLine("O resultado da subtração entre " + num2 + " e " + num1 + " é: " + resultadoSub);

            //Multiplicação *
            double resultadoMulti = num1 * num2;
            Console.WriteLine("O resultado da multiplicação entre " + num2 + " e " + num1 + " é: " + resultadoMulti);

            //Divisão /
            double resultadoDiv = num1 / num2;
            Console.WriteLine("O resultado da divisão entre " + num2 + " e " + num1 + " é: " + resultadoDiv);

            //Resto %
            int num3 = 4;
            int num4 = 3;
            int resultadoResto = num3 % num4;
            Console.WriteLine("O resultado do resto entre " + num3 + " e " + num4 + " é: " + resultadoResto);

            //Contador:
            //-> somar
            int num5 = 10;
            num5 += 10; //num5 = num5 + 10;
            Console.WriteLine("O restutado do contador é: " + num5);

            //-> diminuir
            num5 = 10;
            num5 -= 10; //num5 = num5 - 10;
            Console.WriteLine("O restutado do contador é: " + num5);

            //-> multiplicar
            num5 = 10;
            num5 *= 10; //num5 = num5 * 10;
            Console.WriteLine("O resultado do contador é: " + num5);

            //-> dividir
            num5 = 10;
            num5 /= 10; //num5 = num5 / 10;
            Console.WriteLine("O resultado do contador é: " + num5);

            //Incremento ++
            double num6 = 10;
            // num6 = num6 + 1;
            // num6 += 1/
            num6++;
            Console.WriteLine("O resultado do incremento é: " + num6);

            //Decremento --
            double num7 = 10;
            num7--;
            Console.WriteLine("O resultado do decremento é: " + num7);

            Console.ReadKey();
        }
    }
}
