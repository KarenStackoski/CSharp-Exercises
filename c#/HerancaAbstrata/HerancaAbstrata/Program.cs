using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Classe abstrata não pode ser instanciada!!!
            //Pessoa minhaPessoa = new Pessoa("Karen");

            Funcionario meuFuncionario = new Funcionario("Karen", 2233);
            meuFuncionario.MostraNome();
            meuFuncionario.MostraSalario();
            Console.ReadKey();
        }
    }
}
