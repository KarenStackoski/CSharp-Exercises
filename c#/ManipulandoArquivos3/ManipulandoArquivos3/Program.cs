using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //streamwriter e streamreader usa esse system obrigatoriamente!!!

namespace ManipulandoArquivos3
{   //Streamreader - classe p/ ler arquivos
    //Streamwriter - classe p/ escrever em arquivos
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando arquivo:
            string caminho = "teste.txt";
            FileStream fs = File.Create(caminho);
            fs.Close(); //Para o arquivo não ficar travado e o FileStream poder utilizá-lo

            //para escrever no arquivo
            //##### STREAMWRITER #####
            StreamWriter sw = new StreamWriter(caminho);
            sw.Write('a'); //char
            sw.Write('-');
            sw.Write("Olá mundo! \r\n"); //string
            sw.Write("b-Olá Mundo! \r\n");

            sw.WriteLine("c-Olá Mundo!");
            sw.WriteLine("d-Olá Mundo!");

            sw.Close(); //sempre digitar isso depois de terminar de escrever o que deseja
            //########################

            //##### STREAMREADER #####
            StreamReader sr1 = new StreamReader(caminho);
            char[] buffer = new char[128]; //buffer vai os caracteres gravados
            sr1.Read(buffer, 4, 5);
            sr1.Read(buffer, 8, 7);

            sr1.Close();

            StreamReader sr2 = new StreamReader(caminho);
            string linha = sr2.ReadLine(); //linha lê uma linha por vez
            linha = sr2.ReadLine();

            sr2.Close();

            StreamReader sr3 = new StreamReader(caminho);
            string arquivo = sr3.ReadToEnd(); //lê até o final do arquivo
            
            sr3.Close();
            //########################
        }
    }
}
