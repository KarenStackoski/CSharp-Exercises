using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_matematicos_avancados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Potenciação
            double potenciacao = Math.Pow(4, 2);
            Console.WriteLine("O resultado da potenciação é: " + potenciacao);

            //Radiciação
            double raiz = 3;
            double radiciacao = Math.Pow(27, 1/raiz);
            Console.WriteLine("O resultado da radiciação é: " + radiciacao);

            //MAXIMO E MINIMO DE DOIS NUMEROS
            double maximo = Math.Max(4, 8);
            Console.WriteLine(maximo);
            double minimo = Math.Min(4, 8);
            Console.WriteLine(minimo);

            //Módulo = (+) -> (+); (-) -> (+)
            double modulo = Math.Abs(-30);
            Console.WriteLine(modulo);

            /******************************************************************/
            //Operações Trigonométricas
            // - Seno     -> Sin
            // - Cosseno  -> Cos
            // - Tangente -> Tan
            double angulo = 30 * (2 * Math.PI) / 360;
            double seno = Math.Sin(angulo);
            Console.WriteLine(seno);

            // - Arcseno     -> Asin
            // - Arccosseno  -> Acos
            // - Arctangente -> Atan
            double arcsin = Math.Asin(seno);
            Console.WriteLine(arcsin); // transformando eu radianos
            double arcsinGraus = arcsin * 360 / (2 * Math.PI); // transformando para graus
            Console.WriteLine(arcsinGraus);
            /******************************************************************/

            //Arredondando
            double numero = 3.33;
            double arredondandoCima = Math.Ceiling(numero);
            Console.WriteLine(arredondandoCima);
            double arredondandoBaixo = Math.Floor(numero);
            Console.WriteLine(arredondandoBaixo);

            //LOGARÍTIMO
            double base10 = Math.Log10(100);
            Console.WriteLine(base10);

            double baseE = Math.Log(Math.E * Math.E * Math.E);
            Console.WriteLine(baseE);

            Console.ReadKey();
        }
    }
}
