using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{   //é como uma variável, mas armazena métodos, referencia eles
    internal class Program
    {
        public delegate double MeuDelegateOperacoes(double a, double b); // executa no main o que os métodos fazem
        public static double Soma(double a, double b)
        {
            double resultadoSoma = a + b;
            Console.WriteLine("Soma: " + resultadoSoma);
            return resultadoSoma;
        }

        public static double Multiplicacao(double a, double b)
        {
            double resultadoMultiplicacao = a * b;
            Console.WriteLine("Multiplicacao: " + resultadoMultiplicacao);
            return resultadoMultiplicacao;
        }

        public static double Divisao(double a, double b)
        {
            double resultadoDivisao = a / b;
            Console.WriteLine("Multiplicacao: " + resultadoDivisao);
            return resultadoDivisao;
        }

        public static void ExecutaOperacao(MeuDelegateOperacoes minhasOperacoes)
        {
            Console.WriteLine("Executando o método passado como parâmetro de entrada...");
            minhasOperacoes(50, 20);
        }
        static void Main(string[] args)
        {
            MeuDelegateOperacoes minhasOperacoes; //atribuindo o delegate a uma variável
            minhasOperacoes = Soma;
            double resultadoDel1 = minhasOperacoes(10, 2);
            Console.WriteLine("Resultado: " + resultadoDel1);
            //minhasOperacoes = Multiplicacao;
            //double resultadoDel2 = minhasOperacoes(10, 2);
            //Console.WriteLine("Resultado: " + resultadoDel2);
            //minhasOperacoes = Divisao;
            //double resultadoDel3 = minhasOperacoes(10, 2);
            //Console.WriteLine("Resultado: " + resultadoDel3);

            minhasOperacoes += Multiplicacao;
            minhasOperacoes += Divisao;
            Console.WriteLine("-------------------------");
            resultadoDel1 = minhasOperacoes(30, 5);
            Console.WriteLine("Resultado é: " + resultadoDel1);
            Console.WriteLine("-------------------------");
            ExecutaOperacao(Multiplicacao);

            Console.ReadKey();
        }
    }
}
