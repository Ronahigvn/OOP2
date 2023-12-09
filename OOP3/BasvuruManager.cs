using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediBaseManager krediBaseManager,ILoggerService loggerService)
        {
            //Basvuru bilgileri degerlendirme
          krediBaseManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirilmesiYap(List<IKrediBaseManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
