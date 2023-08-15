using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            //atribuição
            idade = 18;
            Console.WriteLine(idade);

            idade = 20;
            Console.WriteLine(idade);

            string NomeCompleto = "Karen Stackoski";
            Console.WriteLine(NomeCompleto);

            NomeCompleto = "Karen Bialescki";
            Console.WriteLine(NomeCompleto);

            //byte b = 1000; O valor 1000 é muito grande para o tipo byte. ERRO!!!

            var Salario = 10000; //adivinha qual o tipo da variável. nesse caso ele considera como int.
            var NomeDaMae = "Joana"; //string
            // não é possível atribuir dados de outro tipo de variavel em uma var pois o compilador já atribuiu um tipo
            //não é possível mudar o tipo

            DateTime DataDeNascimento = new DateTime(2004, 06, 22, 10, 15, 20); //ano, mês, dia, hora, minuto, segundo
            Console.WriteLine(DataDeNascimento.Year); // PARA TER ACESSO AO ANO
            Console.WriteLine(DataDeNascimento.Month); // PARA TER ACESSO AO MÊS
            Console.WriteLine(DataDeNascimento.Day); // DIA
            Console.WriteLine(DataDeNascimento.Hour); // HORA
            Console.WriteLine(DataDeNascimento.Minute);  //MINUTO
            Console.WriteLine(DataDeNascimento.Second); // SEGUNDOS

            /*
                CONVERSÃO DE VARIÁVEIS
             */

            // conversão de string p/ int
            string NumeroDaCasa = "65";
            int NumeroDaCasaInt = Convert.ToInt32(NumeroDaCasa);

            Console.WriteLine(NumeroDaCasaInt);

            // conversão de int p/ string
            string NumeroDaCasa2 = Convert.ToString(NumeroDaCasaInt);

            Console.WriteLine(NumeroDaCasa2);

            // conversão de byte p/ char
            byte b = 50;
            char c = Convert.ToChar(b); // utiliza a tabela ASCII. 35 corresponde ao #. 50 corresponde a 2.

            Console.WriteLine(c);

            // conversão de char p/ int
            int charC = Convert.ToInt32(c);

            Console.WriteLine(charC);

            // conversão de double p/ int
            double d = 1.6;

            Console.WriteLine(d);

            int ConversaoDouble = Convert.ToInt32(d);

            Console.WriteLine(ConversaoDouble);

            Console.ReadKey();
        }
    }
}
