using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliformismo
{
    internal class Bicicleta: Veiculo
    {
        override public void Anda()
        {
            Console.WriteLine("A bicicleta está andando...");
        }
    }
}
