using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mais_sobre_o_modificador_static
{
    public class pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public static void imprimeNome(pessoa pPessoa)
        {
            Console.WriteLine("O nome é: " + pPessoa.nome);
        }

        public pessoa(string pNome)
        {
            nome = pNome;
        }
    }
    //A classe calculadora possui static
    public static class calculadora
    {
        //statics adicionados aqui:
        public static double PI = 3.1415;
        public static double calculaAreaCircunferencia(double pRaio)
        {
            return PI * Math.Pow(pRaio, 2);
        }
    }

    //Palavra this - utilizado p/ se referir a aquilo que pertence a nossa classe
    public class minhaPessoa
    {
        //atributos
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void imprimeNome()
        {
            Console.WriteLine("O nome é: " + nome);
        }

        public minhaPessoa(string nome)
        {
            //se refere ao que pertence a classe
            this.nome = nome;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando objetos
            pessoa p1 = new pessoa("Karen");
            pessoa.imprimeNome(p1);          
        }
    }
}
