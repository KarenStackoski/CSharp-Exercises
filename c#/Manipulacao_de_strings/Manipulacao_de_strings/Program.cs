using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulacao_de_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indexação = capturar uma letra, transformar a palavra em um array
            string nome = "Karen";
            char letra = nome[3];
            Console.WriteLine(letra);

            //Concatenar strings
            string sobrenome = " Stackoski";
            string nomeCompleto = nome + sobrenome;
            Console.WriteLine(nomeCompleto);
            
            string nomeCompleto2 = String.Concat(nome, sobrenome);
            Console.WriteLine(nomeCompleto2);

            //Substituição de strings
            string endereco = "Rua das Rosas Verdes";
            endereco = endereco.Replace("Verdes", "Vermelhas");
            Console.WriteLine(endereco);

            //Remoção de strings
            string endereco2 = "Rua das Rosas Verdes";
            endereco2 = endereco2.Replace(" Verdes", "");
            Console.WriteLine(endereco2);

            string endereco3 = "Rua das Rosas Verdes";
            endereco3 = endereco3.Remove(0,4);
            Console.WriteLine(endereco3);

            //Transformando para maiúsculas e minúsculas
            string texto = "Bom dia";
            texto = texto.ToUpper(); //capitalização
            Console.WriteLine(texto);
            texto = texto.ToLower();
            Console.WriteLine(texto);

            //Contem
            string texto2 = "Bom dia";
            bool contem = texto2.Contains("dia");
            Console.WriteLine(contem);
            bool contem2 = texto2.Contains("noite");
            Console.WriteLine(contem2);

            //Localização de strings
            string texto3 = "Boa noite";
            int indice = texto3.IndexOf("noite");
            Console.WriteLine(indice);

            //divisão de strings
            string texto4 = "Boa tarde";
            string[] divisores = {"Boa"};
            string[] resultadoDivisao = texto4.Split(divisores, StringSplitOptions.None);
            foreach(string textoo in resultadoDivisao)
            {
                Console.WriteLine(textoo);
            }

            //Número de caracteres 
            string texto5 = "Good Morning";
            int numeroCaracteres = texto5.Length;
            Console.WriteLine(numeroCaracteres);

            //Substring
            string texto6 = "Good Afternoon";
            string ultimoTexo = texto6.Substring(0, 4);
            Console.WriteLine(ultimoTexo);

            //FORMATAÇÃO COMPOSTA
            string texto7 = "Good {0} {1}";
            Console.WriteLine(texto7,"Morning","!");
            string formatacao = String.Format(texto7,"Morning","!");
            Console.WriteLine(formatacao);

            Console.ReadKey();
        }
    }
}
