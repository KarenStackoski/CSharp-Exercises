using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        struct DadosCadastrais
        {
            public string nome;
            public string nomeDaRua;        //são variáveis protegidas automaticamente se não classificar como publica
            public UInt32 numeroDaCasa;
            public DateTime dataNascimento;
        }
        static void Main(string[] args)
        {
            DadosCadastrais meuCadastro; // cria variável p/ chamar dados da structure
            meuCadastro.nome = "Karen";
            meuCadastro.nomeDaRua = "Rua das Flores";
            meuCadastro.numeroDaCasa = 10;
            meuCadastro.dataNascimento = Convert.ToDateTime("22/06/2004");

            Console.WriteLine(meuCadastro.nome);
            Console.WriteLine(meuCadastro.nomeDaRua);
            Console.WriteLine(meuCadastro.numeroDaCasa);
            Console.WriteLine(meuCadastro.dataNascimento.Day + "/" + meuCadastro.dataNascimento.Month + "/" + meuCadastro.dataNascimento.Year);

            Console.ReadKey();  
        }
    }
}
