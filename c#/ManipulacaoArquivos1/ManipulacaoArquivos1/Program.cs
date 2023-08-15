using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //PARA PODER CRIAR ARQUIVOS!!!

namespace ManipulacaoArquivos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando caminhos de arquivos
            //Primeiro método
            string caminho1 = "C:\\Users\\lab102a\\source\\repos\\ManipulacaoArquivos1\\ManipulacaoArquivos1\\bin\\Debug\\teste.txt";
            //Segunda maneira
            string caminho2 = @"C:\Users\lab102a\source\repos\ManipulacaoArquivos1\ManipulacaoArquivos1\bin\Debug\teste.txt";

            //Criando um arquivo
            FileStream meuArquivo = File.Create(caminho1);
            meuArquivo.Close();

            //verificando existencia de arquivo
            bool arquivoExiste = File.Exists(caminho1); //bool, retorna true/false
            if(arquivoExiste)
            {
                Console.WriteLine("O arquivo existe.");
            }
            else
            {
                Console.WriteLine("O arquivonão existe.");
            }

            //deletando arquivos
            File.Delete(caminho1);

            //renomeando ou movendo
            //string caminho3 = @"C:\Users\lab102a\source\repos\ManipulacaoArquivos1\ManipulacaoArquivos1\bin\Debug\teste2.txt";
            //FileStream meuArquivo2 = File.Create(caminho3);
            //meuArquivo2.Close();
            //string caminho4 = @"C:\Users\lab102a\source\repos\ManipulacaoArquivos1\ManipulacaoArquivos1\bin\Debug\teste3.txt";
            //File.Move(caminho3, caminho4);

            //File.Delete(caminho3);

            //Escrevendo um arquivo de texto
            string caminho5 = @"C:\Users\lab102a\source\repos\ManipulacaoArquivos1\ManipulacaoArquivos1\bin\Debug\nomes.txt";
            FileStream meuArquivo3 = File.Create(caminho5);
            meuArquivo3.Close();

            string conteudo = "Marcos e um cara muito legal, Pedro e um cara muito inteligente";
            File.WriteAllText(caminho5, conteudo);

            //Escrevendo Array de Strings no arquivo
            string[] conteudoArray = {"Guilherme","Karen","Pedro","Marcos","Maria"};
            File.WriteAllLines(caminho5, conteudoArray);

            //Lendo todo o conteúdo de um arquivo
            string conteudoLido = File.ReadAllText(caminho5);
            Console.WriteLine(conteudoLido);

            //Lendo o conteudo de um arquivo e gravando num array de strings
            Console.WriteLine("----------------------------------");
            string[] lidoArray = File.ReadAllLines(caminho5);
            foreach(string lido in lidoArray)
            {
                Console.WriteLine(lido);
            }

            Console.ReadKey();
        }
    }
}
