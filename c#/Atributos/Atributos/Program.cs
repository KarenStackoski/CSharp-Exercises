using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    public class carro
    {
        //ADICIONANDO ATRIBUTOS: modificador_de_acesso tipo_do_atributo
        /* Tipos:
         * public - todos podem acessar;
         * private - somente a própria classe pode acessar;
         */

        //CRIANDO ATRIBUTOS
        public string marca;
        private double velocidade;

        public void configuraVelocidade(double velocidadeFinal)
        {
            //aqui é possível acessar o atributo!
            velocidade = velocidadeFinal;
            marca = "Ford";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRIANDO OBJETO:
            carro c1 = new carro();
            c1.marca = "Ford";
            
            //ATRIBUTOS PRIVADOS SÓ PODEM SER ACESSADOS DENTRO DA NOSSA PRÓPRIA CLASSE!
            //c1.velocidade = 10;
        }
    }
}
