using FactoryMethod.Equipamentos.Factories;
using FactoryMethod.Util.Enumeraveis;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha seu equipamento");
            Console.WriteLine();
            Console.WriteLine("0 - Armadura" +
                "\n1 - Bota" +
                "\n2 - Capacete");
            Console.WriteLine();

            var escolha = int.Parse(Console.ReadLine());

            var equipamento = EquipamentoFactory.ObterEquipamento((TipoEquipamento)escolha, RaridadeEquipamento.Comum);

            Console.WriteLine();
            Console.Write("Valor do equipamento encontrado ");

            Console.Write(equipamento.ObterValorEquipamento());

            Console.ReadKey();
        }
    }
}
