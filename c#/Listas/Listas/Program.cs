using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista é similar a Array, porém não tem um tamanho pré definido
            List<string> listaDeNomes = new List<string>();

            //Adicionando elementos
            listaDeNomes.Add("Karen");       //-> não é preciso especificar a posição como no array!
            listaDeNomes.Add("João");        //
            listaDeNomes.Add("Ana");         //
            listaDeNomes.Add("Maria");       //

            //Removendo elementos
            listaDeNomes.Remove("João");

            //Removendo elementos em posições espécíficas
            listaDeNomes.RemoveAt(0);
            listaDeNomes.RemoveAt(1);

            foreach (string nome in listaDeNomes) //busca todos os nomes dentro de listaDeNomes
            {                                    //com a variável nome               
                Console.WriteLine(nome);
            }

            Console.WriteLine("*******************************");    

            List<string> listaNumeros = new List<string>();

            listaNumeros.Add("1");
            listaNumeros.Add("2");
            listaNumeros.Add("3");
            listaNumeros.Add("4");

            //Removendo uma faixa de elementos
            listaNumeros.RemoveRange(0 /*Indice*/ , 2 /*Quantidade*/); 

            foreach(string num in listaNumeros)
            {
                Console.WriteLine(num); 
            }

            //pegando o num de elementos
            Console.WriteLine("A lista de números possui: " + listaNumeros.Count + " elementos.");

            Console.WriteLine("*************************");

            //unindo 2 listas
            List<string> listaNomes1 = new List<string>();
            List<string> listaNomes2 = new List<string>();

            listaNomes1.Add("Karen");
            listaNomes1.Add("João");
            listaNomes1.Add("Ana");
            listaNomes1.Add("Mariana");

            listaNomes2.Add("Pedro");
            listaNomes2.Add("Paulo");
            listaNomes2.Add("Maria");
            listaNomes2.Add("Luiz");

                //criar nova lista
            List<string> listaConcatenada = listaNomes1.Concat(listaNomes2).ToList();

            foreach(string nomeslista in listaConcatenada)
            {
                Console.WriteLine(nomeslista);
            }

            //verificando se a lista possui um determinado valor
            bool contem = listaConcatenada.Contains("Maria");

            Console.WriteLine("A lista possui o nome Maria?  " + contem);

            //descobrindo o índice de um elemento
            int indice = listaConcatenada.IndexOf("Pedro");

            Console.WriteLine("Indice do nome Pedro: " + indice);

            //operador WHERE
            List<string> listaWhere = listaConcatenada.Where(x => x.StartsWith("P")).ToList();

            Console.WriteLine("Nomes que começam com P: ");

            foreach (string nomeP in listaWhere)
            {
                Console.WriteLine(nomeP);   
            }

            Console.ReadKey();
        }
    }
}
