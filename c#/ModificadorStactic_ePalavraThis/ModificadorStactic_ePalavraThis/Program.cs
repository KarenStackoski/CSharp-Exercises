using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorStactic_ePalavraThis
{
    //Modificador static(fixo) - sempre usado após o modificador de acesso
    //Pode ser usado em atributo, propriedade, método, struct, classe,...
    //O static transforma o que está sendo transformado por ele em pertencente à classe e não mais ao objeto.
    //O static é como uma variávelglobal, que pode ser usada em todo o código.

    public class pessoa
    {
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

        public pessoa(string pNome)
        {
            nome = pNome;
        }
    }
    //A classe calculadora possui static
    public class calculadora
    {
        //statics adicionados aqui:
        public static double PI = 3.1415;
        public static double calculaAreaCircunferencia(double pRaio)
        {
            return PI*Math.Pow(pRaio, 2);
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
    //A classe calculadora possui static
    public class calculadora
    {
        //statics adicionados aqui:
        public static double PI = 3.1415;
        public static double calculaAreaCircunferencia(double pRaio)
        {
            return PI * Math.Pow(pRaio, 2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando objetos
            pessoa p1 = new pessoa("Karen");
            pessoa p2 = new pessoa("Pedro");
            p1.imprimeNome();
            p1.Nome = "Karen Stackoski";   //static transforma o que alterou em pertencente a classe e não ao objeto

            Console.WriteLine("O valor de PI é: " + calculadora.PI); //pi pode ser acessado apenas com o nome da classe graças ao static
            Console.WriteLine("A área é: " + calculadora.calculaAreaCircunferencia(2));    

            //Não podemos acessar o que é static através do nome do objeto, pois ele pertence à classe!
            calculadora calc = new calculadora();
        }
    }
}
