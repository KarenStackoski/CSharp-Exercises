using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oitavo_projeto
{
    internal class CadastroPessoa
    {
        //Atributos
        private string nome;
        private string numeroDoDocumento;
        private string nomeDaRua;
        private DateTime dataDeNascimento;
        private UInt32 numeroDaCasa;

        //Propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string NumeroDoDocumento
        {
            get { return numeroDoDocumento; }
            set { numeroDoDocumento = value; }
        }
        public string NomeDaRua
        {
            get { return nomeDaRua; }
            set { nomeDaRua = value; }
        }
        public DateTime DataDeNascimento
        {
            get { return dataDeNascimento; }
            set { dataDeNascimento = value; }
        }
        public UInt32 NumeroDaCasa
        {
            get { return numeroDaCasa; }
            set { numeroDaCasa = value; }
        }

        //Construtor
        public CadastroPessoa(string nome, string numeroDoDocumento, string nomeDaRua, DateTime dataDeNascimento, UInt32 numeroDaCasa)
        {
            this.nome = nome;
            this.numeroDoDocumento = numeroDoDocumento;
            this.dataDeNascimento = dataDeNascimento;
            this.nomeDaRua = nomeDaRua;
            this.numeroDaCasa = numeroDaCasa;

        }
    }
}
