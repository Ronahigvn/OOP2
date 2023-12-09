using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediBaseManager ihtiyacKrediManager=new IhtiyacKrediManager();
            IKrediBaseManager tasitKredi = new TasitKredi();
            IKrediBaseManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaselLoggerService = new DatabaselLoggerService();
            //ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager= new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,new DatabaselLoggerService());

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() { ihtiyacKrediManager,tasitKredi};
            //basvuruManager.KrediOnBilgilendirilmesiYap(krediler);
            Console.ReadLine();
        }
    }
}
