using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factory = new FactoryMethod();

            Console.WriteLine("Escolha seu personagem");
            Console.WriteLine();
            Console.WriteLine("Liu Kang | Sub-Zero | Scorpion");
            Console.WriteLine();

            string escolha = Console.ReadLine();

            IPersonagem personagem = factory.EscolherPersonagem(escolha);

            Console.WriteLine();
            Console.Write("Voce vai jogar com ");

            personagem.Escolhido();

            Console.ReadKey();
        }
    }
}
