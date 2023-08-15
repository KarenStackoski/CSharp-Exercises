using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oitavo_projeto
{
    internal class InterfaceGrafica
    {
        public enum Resultado_e
        {
            Sucesso = 0,
            Sair = 1,
            Excessao = 2
        }

        //MÉTODOS ANTIGOS
        public void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Presione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        public Resultado_e PegaString(ref string minhaString, string mensagem)
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

        public Resultado_e PegaData(ref DateTime data, string mensagem)
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
                    MostraMensagem("EXCECAO: " + e.Message);
                    retorno = Resultado_e.Excessao;
                }
            } while (retorno == Resultado_e.Excessao);
            Console.Clear();
            return retorno;
        }

        public Resultado_e PegaUInt32(ref UInt32 numero, string mensagem)
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
                    MostraMensagem("EXCECAO: " + e.Message);
                    retorno = Resultado_e.Excessao;
                }
            } while (retorno == Resultado_e.Excessao);
            Console.Clear();
            return retorno;
        }

        //ATRIBUTO
        BaseDeDados baseDeDados;

        //CONSTRUTOR
        public InterfaceGrafica(BaseDeDados pBaseDeDados)
        {
            baseDeDados = pBaseDeDados;
        }

        //MÉTODOS NOVOS
        public void ImprimeDadosNaTela(CadastroPessoa pPessoa)
        {
            Console.WriteLine("Nome: " + pPessoa.Nome);
            Console.WriteLine("Nº do documento: " + pPessoa.NumeroDoDocumento);
            Console.WriteLine("Data de Nascimento: " + pPessoa.DataDeNascimento);
            Console.WriteLine("Nome da Rua: " + pPessoa.NomeDaRua);
            Console.WriteLine("Nº Casa: " + pPessoa.NumeroDaCasa);
        }

        public void ImprimeDadosNaTela(List<CadastroPessoa> pListaDePessoas)
        {
            foreach(CadastroPessoa pessoa in pListaDePessoas)
            {
                ImprimeDadosNaTela(pessoa);
            }
        }

        public Resultado_e CadastraUsuario()
        {
            Console.Clear();
            string Nome = "";
            DateTime DataDeNascimento = new DateTime();
            string NomeDaRua = "";
            string NumeroDoDocumento = "";
            UInt32 NumeroDaCasa = 0;

            if (PegaString(ref Nome, "Digite o nome completo ou digite S para sair: ") == Resultado_e.Sair)
            {
                return Resultado_e.Sair; // vai parar
            }
            if (PegaData(ref DataDeNascimento, "Digite a data de nascimento ou S para sair: ") == Resultado_e.Sair)
            {
                return Resultado_e.Sair; // vai parar
            }
            if (PegaUInt32(ref NumeroDaCasa, "Digite o número da casa ou S para sair: ") == Resultado_e.Sair)
            {
                return Resultado_e.Sair; //vai sair
            }
            if (PegaString(ref NomeDaRua, "Digite o nome da rua ou S para sair: ") == Resultado_e.Sair)
            {
                return Resultado_e.Sair; //vai sair
            }
            if (PegaString(ref NumeroDoDocumento, "Digite o número do Documento ou S para sair") == Resultado_e.Sair)
            {
                return Resultado_e.Sair; //vai sair
            }

            CadastroPessoa cadastroUsuario = new CadastroPessoa(Nome, NumeroDoDocumento, NomeDaRua, DataDeNascimento, NumeroDaCasa);
            baseDeDados.AdicionarPessoa(cadastroUsuario);

            Console.Clear();
            Console.WriteLine("Adicionando usuário: ");
            ImprimeDadosNaTela(cadastroUsuario); //Imprimeindo os dados do usuário que acabou de ser cadastrado
            MostraMensagem("");
            return Resultado_e.Sucesso;
        }

        public void BuscaUsuario()
        {
            Console.Clear();
            Console.WriteLine("Digite o nº do documento para buscar usuário ou S para sair.");
            string temp = Console.ReadLine();
            if (temp.ToLower() == "s")
            {
                return; //skip
            }

            List<CadastroPessoa> listaDePessoaTemp = baseDeDados.PesquisaPesssoaPorDoc(temp);
            Console.Clear();
            if (listaDePessoaTemp != null)
            {
                Console.WriteLine("Usuário com documento " + temp + " encontrado.");
                ImprimeDadosNaTela(listaDePessoaTemp);
            }
            else
            {
                Console.WriteLine("Nenhum usuário encontrado.");
                MostraMensagem("");
            }
        }

        /*
        public void RemoveUsuario()
        {
            Console.Clear();
            Console.WriteLine("Digite o nº do documento para remover usuário ou S para sair.");
            string temp = Console.ReadLine();
            if (temp.ToLower() == "s")
            {
                return; //skip
            }

            List<CadastroPessoa> listaDePessoaTemp = baseDeDados.RemoverPesssoaPorDoc(temp);
            Console.Clear();
            if (listaDePessoaTemp != null)
            {
                Console.WriteLine("Usuário com documento " + temp + " removido.");
                ImprimeDadosNaTela(listaDePessoaTemp);
            }
            else
            {
                Console.WriteLine("Nenhum usuário encontrado.");
                MostraMensagem("");
            }
        }
        */

        public void Sair()
        {
            Console.Clear();
            MostraMensagem("Encerrando...");
        }

        public void OpcaoDesconhecida()
        {
            MostraMensagem("Opção Desconhecida");
        }

        public void IniciaInterface()
        {
            string temp;
            do
            {
                Console.WriteLine("Digite C para cadastrar um usuário.");
                Console.WriteLine("Digite B para buscar um usuário pelo documento.");
                Console.WriteLine("Digite R para remover um usuário pelo documento.");
                Console.WriteLine("Digite S para sair.");
                temp = Console.ReadKey(true).KeyChar.ToString().ToLower();
                switch (temp)
                {
                    case "c":
                        CadastraUsuario();
                        break;
                    case "b":
                        BuscaUsuario();
                        break;
                    /*
                    case "r":
                        break;
                    */
                    case "s":
                        Sair();
                        break;
                    default:
                        OpcaoDesconhecida();
                        break;
                }
            } while (temp != "s");
        }
    }
}
