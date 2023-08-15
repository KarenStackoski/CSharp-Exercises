using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_de_classes
{
    internal class ClasseFilha: ClasseMae //como fazer a classe filha receber informações da classe mãe
    {
        public string AtributoDaFilha = "Atributo da Filha";
        public string PropriedadeDaFilha
        {
            set;
            get;
        }
        public void MetodoDaClasseFilha()
        {
            //MetodoDaClasseMae(); //assim é possível chamar este método que está na classe mãe
            Console.WriteLine("Método da classe filha");
        }
        public ClasseFilha()
        {
            PropriedadeDaFilha = "Propriedade da Filha";
        }
    }
}
