using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var carro1 = ExecutaAbstractFactory.montarCarro("luxo");
            var carro2 = ExecutaAbstractFactory.montarCarro("popular");

            Console.ReadKey();
        }
    }
}
