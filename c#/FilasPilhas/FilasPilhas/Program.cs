using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilasPilhas
{   //fila segue uma ordem, não podem ser feitas operações fora de ordem
        //primeiro que entra, é o primeiro a sair
    //pilha segue outra ordem, quando remover, vai remover o ultimo, e não o primeiro
        //primeiro que entra, é o último a sair
    internal class Program
    {
        static void Main(string[] args)
        {
            //FILA:
            Queue<string> filaNomes = new Queue<string>();

            //adicionando elementos
            filaNomes.Enqueue("Karen");
            filaNomes.Enqueue("Maria");
            filaNomes.Enqueue("João");
            filaNomes.Enqueue("Vagner");

            //Removendo elementos
            string nomeRemovido = filaNomes.Dequeue();  //vai remover um nome por vez
            Console.WriteLine(nomeRemovido);
            nomeRemovido = filaNomes.Dequeue();
            Console.WriteLine(nomeRemovido);

            //Espiando elementos
            Console.WriteLine("-------------------------------");
            string nomeEspiado = filaNomes.Peek();
            Console.WriteLine(nomeEspiado); //JOÃO pois os dois primeiro foram excluídos
            Console.WriteLine("_______________________________________________");

            //PILHA:
            Stack<string> pilhaCarros = new Stack<string>();

            //adicionando elementos
            pilhaCarros.Push("Clio");
            pilhaCarros.Push("Sandero");
            pilhaCarros.Push("Logan");
            pilhaCarros.Push("Kwid");
            pilhaCarros.Push("Duster");

            //Removendo
            string carroRemovido = pilhaCarros.Pop();
            Console.WriteLine(carroRemovido);
            carroRemovido = pilhaCarros.Pop();
            Console.WriteLine(carroRemovido);

            //Espiar elementos
            string carroEspiado = pilhaCarros.Peek();
            Console.WriteLine(carroEspiado);

            //Possuem os mesmos métodos das listas
            //Count
            //Clear
            //Concat
            //Contains
            //...

            Console.ReadKey();
        }
    }
}
