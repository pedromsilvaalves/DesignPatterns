using System;

namespace Singleton
{
    public sealed class Logger
    {
        private static readonly Logger instancia = new Logger();
        static Logger() {
            Console.WriteLine("Datetime: {0} - Static - Logger Criado", DateTime.Now);
        }
        private Logger() {
            Console.WriteLine("Datetime: {0} - Private - Logger Criado", DateTime.Now);
        }

        public static Logger GetLogger
        {
            get
            {
                return instancia;
            }
        }

        public void Logar(string mensagem)
        {
            Console.WriteLine("Datetime: {0} - Mensagem: {1}", DateTime.Now, mensagem);
        }
    }
}
