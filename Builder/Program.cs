using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var fabricante = new Fabricante();
            ICelular celularBuilder;

            celularBuilder = new AndroidBuilder();
            fabricante.Construtor(celularBuilder);
            PrintCelular(celularBuilder);

            celularBuilder = new IphoneBuilder();
            fabricante.Construtor(celularBuilder);
            PrintCelular(celularBuilder);

            Console.ReadKey();
        }

        private static void PrintCelular(ICelular celularBuilder)
        {
            Console.WriteLine($"Um novo Celular foi construído: {celularBuilder.Celular.Nome}");
        }
    }
}
