using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Carro: iVeiculo
    {
        public void Ligar()
        {
            Console.WriteLine("O carro está ligado.");
        }
        public void Desligar()
        {
            Console.WriteLine("O carro está desligado.");
        }
        public void AbrirPorta()
        {
            Console.WriteLine("As portas do carro estão abertas.");
        }
        public void FecharPorta()
        {
            Console.WriteLine("As portas do carro estão fechadas.");
        }
        public void Acelerar()
        {
            Console.WriteLine("O carro acelerou.");
        }
    }
}
