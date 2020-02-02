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
            var guerreiro = PersonagemAbstractFactory.CriarPersonagem(TipoPersonagens.Guerreiro);
            var ladino = PersonagemAbstractFactory.CriarPersonagem(TipoPersonagens.Ladino);
            var mago = PersonagemAbstractFactory.CriarPersonagem(TipoPersonagens.Mago);

            Console.ReadKey();
        }
    }
}
