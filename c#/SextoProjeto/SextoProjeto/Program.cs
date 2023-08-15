using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SextoProjeto
{
    internal class Program
    {
        //tags são para identificar
        static string delimitadorInicio;
        static string delimitadorFim;
        static string tagNome;
        static string tagNascimento;
        static string tagNomeRua;
        static string tagNumCasa;

        public struct DadosCadastrais_Struct
        {
            public string nome;
            public string nomeRua;
            public UInt32 numCasa;
            public DateTime dataNascimento;
        };

        public enum Resultado_e
        {
            Sucesso = 0,
            Sair = 1,
            Excessao = 2
        }

        public static void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Presione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        public static Resultado_e PegaString(ref string minhaString, string mensagem)
        {
            Resultado_e retorno;
            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if (temp == "s" || temp == "S")
            {
                retorno = Resultado_e.Sair;
            }
            else
            {
                minhaString = temp;
                retorno = Resultado_e.Sucesso;
            }
            Console.Clear();
            return retorno;
        }

        public static Resultado_e PegaData(ref DateTime data, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = Resultado_e.Sair;
                    }
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Excessão: " + e.Message);
                    Console.WriteLine("Pressiona qualquer tecla para continuar: ");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excessao;
                }
            } while (retorno == Resultado_e.Excessao);
            Console.Clear();
            return retorno;
        }

        public static Resultado_e PegaUInt32(ref UInt32 numero, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = Resultado_e.Sair;
                    }
                    else
                    {
                        numero = Convert.ToUInt32(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Excessão: " + e.Message);
                    Console.WriteLine("Pressiona qualquer tecla para continuar: ");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excessao;
                }
            } while (retorno == Resultado_e.Excessao);
            Console.Clear();
            return retorno;
        }

        public static Resultado_e CadastraUsuario(ref List<DadosCadastrais_Struct> ListaDeUsuarios)
        {
            DadosCadastrais_Struct cadastroUsuario;
            cadastroUsuario.nome = "";
            cadastroUsuario.nomeRua = "";
            cadastroUsuario.numCasa = 0;
            cadastroUsuario.dataNascimento = new DateTime();
            if (PegaString(ref cadastroUsuario.nome, "Digite o nome completo ou digite S para sair: ") == Resultado_e.Sair)
            {
                return Resultado_e.Sair; // vai parar
            }
            if (PegaData(ref cadastroUsuario.dataNascimento, "Digite a data de nascimento ou S para sair: ") == Resultado_e.Sair)
            {
                return Resultado_e.Sair; // vai parar
            }
            if (PegaUInt32(ref cadastroUsuario.numCasa, "Digite o número da casa ou S para sair: ") == Resultado_e.Sair)
            {
                return Resultado_e.Sair; //vai sair
            }
            if (PegaString(ref cadastroUsuario.nomeRua, "Digite o nome da rua ou S´para sair: ") == Resultado_e.Sair)
            {
                return Resultado_e.Sair; //vai sair
            }
            ListaDeUsuarios.Add(cadastroUsuario);
            return Resultado_e.Sucesso;
        }

        public static void GravaDados(string caminho, List<DadosCadastrais_Struct> ListaDeUsuarios)
        { //Gravando dados para passar para arquivo
            try
            {
                string conteudoArquivo = "";
                foreach (DadosCadastrais_Struct cadastro in ListaDeUsuarios)
                {
                    conteudoArquivo += delimitadorInicio + "\r\n";
                    conteudoArquivo += tagNome + cadastro.nome + "\r\n";
                    conteudoArquivo += tagNascimento + cadastro.dataNascimento.ToString("dd/MM/yyyy") + "\r\n";
                    conteudoArquivo += tagNomeRua + cadastro.nomeRua + "\r\n";
                    conteudoArquivo += tagNumCasa + cadastro.numCasa + "\r\n";
                    conteudoArquivo += delimitadorFim + "\r\n";
                }
                File.WriteAllText(caminho, conteudoArquivo)
            }
            catch(Exception e) 
            {
                Console.WriteLine("Excessão: " + e.Message);
            }
        }

        public static void CarregaDados(string caminho, ref List<DadosCadastrais_Struct> ListaDeUsuarios)
        {
            try
            {
                if (File.Exists(caminho))
                {
                    string[] conteudoArquivo = File.ReadAllLines(caminho);
                    DadosCadastrais_Struct dadosCadastrais;
                    dadosCadastrais.nome = "";
                    dadosCadastrais.dataNascimento = new DateTime();
                    dadosCadastrais.nomeRua = "";
                    dadosCadastrais.numCasa = 0;

                    foreach(string linha in conteudoArquivo)
                    {
                        if (linha.Contains(delimitadorInicio))
                        {
                            continue;
                        }
                        if (linha.Contains(delimitadorFim))
                        {
                            ListaDeUsuarios.Add(dadosCadastrais); //adicionando o usuário atual
                        }
                        if (linha.Contains(tagNome)) // se houver tag nome, então 
                        {
                            dadosCadastrais.nome = linha.Replace(tagNome, "");
                        }
                        if (linha.Contains(tagNascimento))
                        {
                            dadosCadastrais.dataNascimento = Convert.ToDateTime(linha.Replace(tagNascimento, ""));
                        }
                        if (linha.Contains(tagNomeRua))
                        {
                            dadosCadastrais.nomeRua = linha.Replace(tagNomeRua, "");
                        }
                        if (linha.Contains(tagNumCasa))
                        {
                            dadosCadastrais.numCasa = Convert.ToUInt32(linha.Replace(tagNumCasa, 0));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Excessão: " + e.Message);
            }
        }

        static void Main(string[] args)
        {
            List<DadosCadastrais_Struct> ListaDeUsuarios = new List<DadosCadastrais_Struct>();
            string opcao = "";
          
            delimitadorInicio = "##### INICIO #####";
            delimitadorFim = "##### FIM #####";
            tagNome = "NOME: ";
            tagNascimento = "DATA_DE_NASCIMENTO: ";
            tagNomeRua = "NOME_DA_RUA: ";
            tagNumCasa = "NUMERO_DA_CASA: ";

            string caminhoArquivo = @"baseDeDados.txt"; //vai ser o mesmo que estiver no lugar do executável

            CarregaDados(caminho, ref ListaDeUsuarios);

            do
            {
                Console.WriteLine("Digite C para cadastrar ou S para sair: ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    //cadastrar
                    if (CadastraUsuario(ref ListaDeUsuarios) == Resultado_e.Sucesso)
                    {
                        GravaDados(caminhoArquivo, ListaDeUsuarios);
                    }
                }
                else if (opcao == "s")
                {
                    //sair
                    //Console.WriteLine("Encerrando o programa...");
                    //Console.ReadKey();

                    MostraMensagem("Encerrando o programa...");
                }
                else
                {
                    //opcao desconhecida
                    //Console.WriteLine("Opção desconhecida!!");
                    MostraMensagem("Opção desconhecida");
                }
            } while (opcao != "s");
        }
    }
}
