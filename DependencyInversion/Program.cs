/*Örneğin bir arabanın lastiğinin patlaması sonucu aracıda değiştirdiğinizi düşünün yada bir lastik için araç üzerinde de bir takım değişiklikler olduğunu düşün. Garip bir durum olacaktır.*/

public class DbLogger
{
    public void Log()
    {
        //Loglandı
    }
}
public class FileLogger
{
    public void Log()
    {
        //Loglandı
    }
}


public class LogManager
{
    DbLogger _dbLogger;
    FileLogger _fileLogger;
    public LogManager()
    {
        /*Zaten bir sınıfı başka bir sınıfın içinde new anahtar kelimesi ile oluşturuluyor ise problem orada başlıyor.*/
        _dbLogger = new DbLogger();
        _fileLogger = new FileLogger();
    }
    public void LogWrite()
    {
        _dbLogger.Log();
        _fileLogger.Log();
    }
}
class Program
{

    static void Main(string[] args)
    {
        //Görüldüğü gibi LogManager üst sınıfı alt sınıflara sıkı sıkıya bağlı durumda.
        // LogManager logManager = new LogManager();
        // logManager.LogWrite();

        //Doğru kullanım
        LogManager logManager = new LogManager(new DbLogger());
        logManager.LogWrite();

    }
}

/*Doğru kullanım*/
public interface ILogger
{
    void Log();
}
public class DbLogger1 : ILogger
{
    public void Log()
    {
        //Loglandı
    }
}
public class FileLogger1 : ILogger
{
    public void Log()
    {
        //Loglandı
    }
}