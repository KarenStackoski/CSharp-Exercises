using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting
{
    internal class Funcionario: Pessoa
    {
        private uint salario;
        public void ImprimeSalario()
        {
            Console.WriteLine("O salario é: " + salario);
        }
        public Funcionario(string pNome, uint pSalario): base(pNome)
        {
            salario = pSalario;
        }
    }
}
