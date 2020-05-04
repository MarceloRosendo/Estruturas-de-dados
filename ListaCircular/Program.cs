using System;
using System.Threading;

namespace ListaDuplamenteEncadeada
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor de n");
            int n = int.Parse(Console.ReadLine());
            
            Lista lista = new Lista();
            
            Console.WriteLine("Exercicio 1");
            Console.Write(lista.verifyIfListaIsEmpty());
            for (int i = 0; i < 10; i++)
            {
                lista.Insert(i);    
            }
            lista.ShowList();
            
            
        }
    }
}