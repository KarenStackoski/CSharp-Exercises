using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformismo
{
    internal class Carro: Veiculo
    {
        override public void Anda()
        {
            base.Anda(); //chamando o Anda() de veiculo
            Console.WriteLine("O carro está andando...");
        }
    }
}
