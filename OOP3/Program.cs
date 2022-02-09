using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacCreditManager ihtiyaccreditManager = new IhtiyacCreditManager();
            KonutCreditManager konutCreditManager = new KonutCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService>() { new DatabaseLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuru(konutCreditManager, loggerServices);

            //List<ICreditManager> credits = new List<ICreditManager>() { ihtiyaccreditManager, konutCreditManager};
            //basvuruManager.OnBilgilendirme(credits);
        }
    }
}