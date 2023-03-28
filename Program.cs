using System;

namespace Aprendizagem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Como você se chama? ");
            string nomeProprio = Console.ReadLine();
            Console.WriteLine("Bem vindo (a) {0}" , nomeProprio);
        }
    }
}