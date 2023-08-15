using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Aviao: iVeiculo
    {
        public void Ligar()
        {
            Console.WriteLine("O avião está ligado.");
        }
        public void Desligar()
        {
            Console.WriteLine("O avião está desligado.");
        }
        public void AbrirPorta()
        {
            Console.WriteLine("As portas do avião estão abertas.");
        }
        public void FecharPorta()
        {
            Console.WriteLine("As portas do avião estão fechadas.");
        }
        public void Decolar()
        {
            Console.WriteLine("O avião decolou.");
        }
    }
}
