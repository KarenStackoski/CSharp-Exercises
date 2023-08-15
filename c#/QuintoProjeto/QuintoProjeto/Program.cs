using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoProjeto
{   //Cadastro de usuários
    internal class Program
    {
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
            if(temp == "s" || temp == "S")
            {
                retorno = Resultado_e.Sair;
            }
            else
            {
                minhaString = temp;
                retorno= Resultado_e.Sucesso;
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
                    if(temp == "s" || temp == "S")
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

        public static void CadastraUsuario(ref List<DadosCadastrais_Struct> ListaDeUsuarios)
        {
            DadosCadastrais_Struct cadastroUsuario;
            cadastroUsuario.nome = "";
            cadastroUsuario.nomeRua = "";
            cadastroUsuario.numCasa = 0;
            cadastroUsuario.dataNascimento = new DateTime();
            if(PegaString(ref cadastroUsuario.nome, "Digite o nome completo ou digite S para sair: ") != Resultado_e.Sucesso)
            {
                return; // vai parar
            }
            if(PegaData(ref cadastroUsuario.dataNascimento, "Digite a data de nascimento ou S para sair: ") != Resultado_e.Sucesso)
            {
                return; // vai parar
            }
            if(PegaUInt32(ref cadastroUsuario.numCasa, "Digite o número da casa ou S para sair: ") != Resultado_e.Sucesso)
            {
                return; //vai sair
            }
            if(PegaString(ref cadastroUsuario.nomeRua, "Digite o nome da rua ou S´para sair: ") != Resultado_e.Sucesso)
            {
                return; //vai sair
            }
            ListaDeUsuarios.Add(cadastroUsuario);
        }
        static void Main(string[] args)
        {
            List<DadosCadastrais_Struct> ListaDeUsuarios = new List<DadosCadastrais_Struct>();
            string opcao = "";
            do
            {
                Console.WriteLine("Digite C para cadastrar ou S para sair: ");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if(opcao == "c")
                {
                    //cadastrar
                    CadastraUsuario(ref ListaDeUsuarios);
                }
                else if(opcao == "s")
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
