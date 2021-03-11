using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Console.WriteLine("-------------------------------");

            //IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            //ihtiyacKrediManager2.Hesapla();

            //IKrediManager tasitKrediManager2 = new TasitKrediManager();
            //tasitKrediManager2.Hesapla();

            //IKrediManager konutKrediManager2 = new KonutKrediManager();
            //konutKrediManager2.Hesapla();


            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> loggerServices = new List<ILoggerService>() { smsLoggerService,fileLoggerService};
            

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,loggerServices);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,esnafKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
