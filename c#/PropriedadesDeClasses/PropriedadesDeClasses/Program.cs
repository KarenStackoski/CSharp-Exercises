using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropriedadesDeClasses
{   //Uma PROPRIEDADE é um método especializado em manipular os atributos.
    public class carro
    {
        //CRIANDO ATRIBUTOS
        private string marca;
        private double velocidade = 0;
        private bool carroLigado;

        //PROPRIEDADES:
        //MODIFICADOR_ACESSO TIPO NOME
        //{
        //  GET { RETURN ATRIBUTO; } - utilizado para retornar o conoteúdo do nosso atributo
        //  SET { ATRIBUTO = VALUE; } - alterar o conteúdo do atributo
        //}

        public bool CarroLigado
        {
            get { return carroLigado; }
            set 
            { 
                if (velocidade == 0)
                {
                    carroLigado = value;
                }
                else
                {
                    return;
                }              
            }
        }

        public double Velocidade
        {
            get { return velocidade; }
            set
            {
                if (carroLigado)
                {
                    velocidade = value;
                }
                else
                {
                    return;
                }
            }
        }

        public uint NumeroPortas //propriedade sem atributos
        {
            get; 
            set;
        }

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
            c1.CarroLigado = true;
            c1.Velocidade = 100;
            c1.CarroLigado = false; //não consegue desligar o carro pois está em movimento
            c1.Velocidade = 0;
            c1.CarroLigado = false; //agora consegue pois está parado
            c1.NumeroPortas = 4;

            //ATRIBUTOS PRIVADOS SÓ PODEM SER ACESSADOS DENTRO DA NOSSA PRÓPRIA CLASSE!
            //c1.velocidade = 10;
        }
    }
}
