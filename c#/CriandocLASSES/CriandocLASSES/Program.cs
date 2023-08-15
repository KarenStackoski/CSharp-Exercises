using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fórmula p/ criar classes:
//MODIFICADOR_DE_ACESSO_A_CLASSE classe NOME_CLASSE{ }
/*
 * Modificadores de acesso:
 * internal (só pode ser acessada pelo executável, assembly)
 * public (permite o uso livre da classe)
 * private (só pode ser acessada pelo bloco de código que a criou)
 */

namespace CriandoClasses
{
    //CLASSE INTERNA:
    internal class Carro_interno
    {
        Carro_publico cpu2 = new Carro_publico();
    }

    //CLASSE PÚBLICA:
    public class Carro_publico
    {
        Carro_interno cin2 = new Carro_interno();
        
        //Não temos acesso a essa classe pois ela é privada
        //Program.Carro_privado cpr1 = new Program.Carro_privado();
    }

    internal class Program
    {
        //CLASSE PRIVADA: só pode ser criada dentro de outras classes. NUNCA no namespace
        private class Carro_privado
        {

        }
        static void Main(string[] args)
        {
            //Fórmula p/ criar objetos/instâncias
            //NOME_CLASSE NOME_OBJETO = new NOME_CLASSE(PARÂMETROS);
            Carro_interno cin1 = new Carro_interno();
            Carro_publico cpu1 = new Carro_publico();
            Carro_privado cpr1 = new Carro_privado();
            CarroExterno ce1 = new CarroExterno();
        }
    }
}
