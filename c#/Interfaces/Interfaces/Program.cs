using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Interface é um protótipo de uma classe (esqueleto/contrato)
//Ela define os métodos que serão implementados pela classe.

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.AbrirPorta();
            carro1.FecharPorta();
            carro1.Ligar();
            carro1.Desligar();
            carro1.Acelerar();

            Aviao aviao1 = new Aviao();
            aviao1.AbrirPorta();
            aviao1.FecharPorta();
            aviao1.Ligar();
            aviao1.Desligar();
            aviao1.Decolar();

            iVeiculo veiculoCarro = new Carro();
            veiculoCarro.AbrirPorta();
            veiculoCarro.FecharPorta();
            veiculoCarro.Ligar();
            veiculoCarro.Desligar();

            iVeiculo veiculoAviao = new Aviao();
            veiculoAviao.AbrirPorta();
            veiculoAviao.FecharPorta();
            veiculoAviao.Ligar();
            veiculoAviao.Desligar();
        }
    }
}
