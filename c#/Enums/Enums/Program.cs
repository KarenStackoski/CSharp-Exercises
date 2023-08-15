using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        enum NotasDeReal_e
        {
            NotaDe2  = 2,
            NotaDe5  = 5,
            NotaDe10 = 10
        };

        enum NotaProva_e
        {
            Nota0 = 0,
            Nota1,
            Nota2,
            Nota3,
            Nota4
        };
        static void Main(string[] args)
        {
            NotasDeReal_e MinhaNota = NotasDeReal_e.NotaDe2;
            Console.WriteLine(MinhaNota + " vale " + Convert.ToUInt32(MinhaNota));
            
            NotaProva_e notaProva = NotaProva_e.Nota4;
            Console.WriteLine(notaProva + " vale " + Convert.ToUInt32(notaProva));
            Console.ReadKey();  
        }
    }
}
