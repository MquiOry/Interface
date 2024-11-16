using System;

namespace Solution
{
    class MultifunctionDevice : IPrinter, IScanner
    { 
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public string Scan()
        {
            return "Сканирование завершено";
        }
    }
}
