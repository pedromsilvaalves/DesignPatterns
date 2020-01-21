using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] eventosPartida =
            {
                "Jogador 1: A bola esta comigo no meio do campo, passei a bola",
                "Jogador 2: Recebeu a bola, fiz o lancamento",
                "Jogador 3: Recebeu o lancamento na linha de fundo",
                "Jogador 3: Tenta passar para dentro da área",
                "Jogador 1: Cheguei correndo no meio da área e recebe a bola",
                "Jogador 1: Chuta para o gol e tenta a finalização",
                "Goleiro 1: Agarra a bola e mata o lançe"
            };
            
            Logger logger1 = Logger.GetLogger;
            logger1.Logar("Sincrono");
            logger1.Logar(eventosPartida[0]);
            
            Logger logger2 = Logger.GetLogger;
            logger2.Logar(eventosPartida[1]);

            Logger logger3 = Logger.GetLogger;
            logger3.Logar(eventosPartida[2]);
            Console.ReadKey();

            logger1.Logar("Assincrono");
            Logger logger4 = Logger.GetLogger;
            Parallel.ForEach(eventosPartida, eventoPartida =>
            {
                logger4.Logar(eventoPartida);
            });

            Console.ReadKey();
        }
    }
}
