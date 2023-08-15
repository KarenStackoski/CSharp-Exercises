using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{   //Método = reaproveitar códigos
    //é como uma procedure no progress, o método executa uma operação no qual o resultado é chamado mais tarde
    internal class Program
    {
        //tipo_metodo modificador_instancia tipo_retorno nome_metodo(parametros_metodo_entrada);

        public static double Soma(double a, double b)
        {
            double resultado = a + b;
            return resultado;
            // ou: return(a+b);
        }

        public static void ImprimeMensagens()
        {
            Console.WriteLine("Olá! Este é um método VAZIO.");
            Console.WriteLine("Ele apenas imprime mensagens. não tem parametros de entrada e nem saída");
        }

        //Modificadores de parametros de entrada
        /*
         * ref sinaliza que o parametro de entrada PODE ser modificado pelo metodo
         * out sinaliza que o paramentro DEVE ser modificado pelo método
         */

        public static void Multiplica(double a, double b, ref double resultOperacao) // no out esse ultimo parametro DEVE ser preenchido, se não da erro
        {
            double resultado = a * b;
            resultOperacao = resultado;
        }
        static void Main(string[] args)
        {
            //chamando métodos:
            double resultado1 = Soma(10, 20);
            Console.WriteLine("Resultado soma entre 10 e 20 é: " + resultado1);

            double num1 = 40;
            double num2 = 20;
            double resultado2 = Soma(num1, num2);
            Console.WriteLine("Resultado soma entre " + num1  + " e " + num2 + " é: " + resultado2);

            //é possível reutilizar o método várias vezes!!!

            ImprimeMensagens();

            double resultMulti = 0; // vai preenchida no metodo abaixo
            Multiplica(num1, num2, ref resultMulti);
            Console.WriteLine("resultado multiplicação: " + resultMulti);

            Console.ReadKey();
        }
    }
}
