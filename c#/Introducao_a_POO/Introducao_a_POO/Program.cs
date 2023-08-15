using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_a_POO
{
    public class carro
    {
        //* Atributos ou variáveis
        private string marca;
        private string modelo;
        private UInt32 velocidade;
        private bool carroLigado;

        //* Propriedades
        public string Marca //altera ou manipula marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public UInt32 Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }

        public bool CarroLigado
        {
            get { return carroLigado;}
            set { carroLigado = value;}
        }

        //* Métodos
        public void ligarCarro()
        {
            carroLigado = true;
            Console.WriteLine("Ligando o carro da marca " + marca + " modelo " + modelo);
        }

        public void desligarCarro()
        {
            carroLigado = false;
            Console.WriteLine("Desligando carro da marca " + marca + " modelo " + modelo); 
        }

        public void acelerarCarro(UInt32 velocidadeFinal)
        {
            if (carroLigado == false)
            {
                Console.WriteLine("O carro está desligado.");
            }
            else
            {
                velocidade = velocidadeFinal;
                Console.WriteLine("A velocidade do carro da marca " + marca + " modelo " + modelo + " é " + velocidadeFinal);
            }
            
        }

        public void pararCarro()
        {
            if (velocidade == 0)
            {
                Console.WriteLine("O carro já está parado");
            }
            else
            {
                velocidade = 0;
                Console.WriteLine("O carro da marca " + marca + " modelo " + modelo + " está PARADO.");
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //MATERIALIZANDO AS CLASSES:
            //Criando instâncias ou objetos
            carro c1 =  new carro();

            //acessando objeto
            // é possível acessar pois foi declarada a classe como pública
            c1.Marca = "Renault";
            c1.Modelo = "Logan";
            c1.ligarCarro();
            c1.acelerarCarro(80);
            c1.pararCarro();
            c1.desligarCarro();

            carro c2 = new carro();
            c2.Marca = "Ford";
            c2.Modelo = "Mustang Mach1";
            c2.acelerarCarro(100);
            c2.ligarCarro();
            c2.acelerarCarro(100);
            c2.pararCarro();
            c2.desligarCarro();

            carro c3 = new carro();
            c3.Marca = "Chevrolet";
            c3.Modelo = "Tracker";
            c3.ligarCarro();
            c3.acelerarCarro(60);
            c3.pararCarro();
            c3.desligarCarro();

            Console.ReadKey();
        }
    }
}
