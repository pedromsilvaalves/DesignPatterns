using System;

namespace AbstractFactory
{
    public class ExecutaAbstractFactory
    {
        public static Carro montarCarro(string tipoCarro)
        {
            CarroFactory carroFactory = null;

            switch (tipoCarro)
            {
                case "luxo":
                    carroFactory = new CarroLuxoFactory();
                    break;
                case "popular":
                    carroFactory = new CarroPopularFactory();
                    break;
            }

            var novoCarro = new Carro();
            novoCarro.roda = carroFactory.montarRoda();
            novoCarro.som = carroFactory.montarSom();
            return novoCarro;
        }
    }
}
