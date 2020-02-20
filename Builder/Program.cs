using Builder.Criaturas;
using Builder.Criaturas.Builders.Implementacoes;
using Builder.Utils.Enumeraveis;
using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var goblinBuilder = new GoblinBuilder();
            var goblin = CriaturaDiretor.CriarCriaturaLeste(goblinBuilder, TipoRaridade.Lendario);
            PrintCriatura(goblin);

            var ogroBuilder = new OgroBuilder();
            var ogro = CriaturaDiretor.CriarCriaturaLeste(ogroBuilder, TipoRaridade.Lendario);
            PrintCriatura(ogro);

            Console.ReadKey();
        }

        private static void PrintCriatura(Criatura criatura)
        {
            Console.WriteLine($"Uma nova criatura foi construída: " +
                $"\nNome: {criatura.nome}" +
                $"\nAtributos: {PrintAtributos(criatura)}" +
                $"\nRaridade: {criatura.raridade}" +
                $"\nAfiliação: {criatura.afiliacao}");
        }

        private static string PrintAtributos(Criatura criatura)
        {
            var retorno = new StringBuilder();
            foreach(var atributo in criatura.atributos)
            {
                retorno.Append($"\nTipo: {atributo.Nome}");
                retorno.Append($"\nValor: {atributo.Valor}");
            }
            return retorno.ToString();
        }
    }
}
