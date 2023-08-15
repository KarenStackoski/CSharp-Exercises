using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAbstrata
{   //abstract transforma a classe  em uma classe qu só poderá ser herdada, não pode criar objetos nela
    internal abstract class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public void MostraNome()
        {
            Console.WriteLine("O nome da pessoa é: " + nome);
        }
        public Pessoa(string pNome)
        {
            nome = pNome;
        }
    }
}
