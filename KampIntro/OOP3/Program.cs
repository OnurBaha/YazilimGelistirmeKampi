using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

IKrediManager tasitKrediManager = new TasitKrediManager();

IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService(); 

BasvuruManager basvuruManager=new BasvuruManager();
basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> { new SmsLoggerService(), new DatabaseLoggerService() });



List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);