using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Serializacao
{
    [DataContract] //serializando a classe
    internal class Cachorro
    {
        [DataMember]
        public string nome { get; set; }
        [DataMember]
        public string raca;
        [DataMember]
        private string cor;

        public Cachorro(string pNome, string pRaca, string pCor)
        {
            nome = pNome;
            raca = pRaca;
            cor = pCor;
        }

        public Cachorro() //padrão
        {

        }
    }
}
