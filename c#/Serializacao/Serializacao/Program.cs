using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;

namespace Serializacao
{   //serialização e desserialização
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro meuCachorro = new Cachorro("BILU", "Boxer", "Marrom");
            Cachorro meuCachorroDesserializado;

            DataContractSerializer serializador = new DataContractSerializer(typeof(Cachorro)); 

            //serialização
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings { Indent = true }; //indentando código
            StringBuilder construtorDeString = new StringBuilder();
            XmlWriter excritorDeXml = XmlWriter.Create(construtorDeString, xmlConfig);
            serializador.WriterObject(excritorDeXml, meuCachorro);
            excritorDeXml.Flush();
            string objetoSerializado = construtorDeString.ToString();


            //salvando o conteúdo do objeto num XML]
            string caminhoArquivo = "Cachorro.xml";
            FileStream meuArquivoXml = File.Create(caminhoArquivo);
            meuArquivoXml.Close();
            File.WriteAllText(caminhoArquivo,caminhoArquivo);

            //desserializar
            //.... 
        }
    }
}
