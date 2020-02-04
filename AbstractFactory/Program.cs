using AbstractFactory.Personagens.Factories.Abstract;
using AbstractFactory.Util.Enumeraveis;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var guerreiro = PersonagemFactory.CriarPersonagem(TipoPersonagens.Guerreiro);
            var ladino = PersonagemFactory.CriarPersonagem(TipoPersonagens.Ladino);
            var mago = PersonagemFactory.CriarPersonagem(TipoPersonagens.Mago);

            Console.ReadKey();
        }
    }
}
