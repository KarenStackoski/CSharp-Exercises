using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_de_classes
{
    internal class ClasseMae
    {
        public string AtributoDaMae = "Atributo da Mãe";
        public string PropriedadeDaMae
        {
            set;
            get;
        }
        public void MetodoDaClasseMae()
        {
            Console.WriteLine("Método da classe mãe");
        }
        public ClasseMae()
        {
            PropriedadeDaMae = "Propriedade da Mãe";   
        }
    }
}
