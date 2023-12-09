using System;

namespace OOP3
{
    class FilebaselLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandi.");
        }
    }
}
