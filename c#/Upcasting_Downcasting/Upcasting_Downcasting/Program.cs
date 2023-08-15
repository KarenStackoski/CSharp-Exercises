using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UPCASTING
            Funcionario meuFuncionario = new Funcionario("Karen", 36473);
            Pessoa minhaPessoa = meuFuncionario;
            minhaPessoa.ImprimeNome();

            //DOWNCASTING
            /*
            Pessoa minhaPessoa2 = new Pessoa("Manoel");
            Funcionario meuFuncionario2 = (Funcionario)minhaPessoa2;
            meuFuncionario2.ImprimeSalario();
            */

            Funcionario meuFuncionario2 = new Funcionario("Manoel",7833);
            Pessoa minhaPessoa2 = meuFuncionario2;
            Funcionario meuFuncionario3 = (Funcionario)minhaPessoa2;
            meuFuncionario3.ImprimeSalario();
            
            Console.ReadKey();
        }
    }
}
