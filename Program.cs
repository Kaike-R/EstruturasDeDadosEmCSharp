using System;
using EstruPilha;
using EstruFilaCircular;

namespace Estrutura
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha(5);
            FilaCircular filaCircular =  new FilaCircular(12);
            string[] frutas = new string[3];

            frutas[0] = "apple0";
            frutas[1] = "banana1";
            frutas[2] = "cherry2";


            foreach (var item in frutas)
            {
                pilha.Push(item);
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());

            Console.WriteLine("--------------------------------");

            foreach (var item in frutas)
            {
                filaCircular.Enqueue(item);
            }

            Console.WriteLine(filaCircular.Dequeue());
            Console.WriteLine(filaCircular.Dequeue());
            Console.WriteLine(filaCircular.Dequeue());
        }
    }
}
