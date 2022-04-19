public abstract class Arac
{
    public abstract void Calistir()
    {
        //Çalıştı
    }
    public abstract void Durdur()
    {
        //Durdu
    }

}

public class Araba : Arac
{
    public override void Calistir()
    {
        //Araba araç çalıştı
    }
    public override void Durdur()
    {
        //Araba araç durdu
    }
}

public interface IUcanArac
{
    void FlapAc()
    {
        /* Flap Açıldı*/
    }
}
public class Ucak : Arac, IUcanArac
{

    public override void Calistir()
    {
        //Uçak çalıştı
    }
    public override void Durdur()
    {
        //Uçak durdu
    }
    public void FlapAc()
    {
        //Flap açıldı
    }
}


class Program
{

    static void Main(string[] args)
    {


    }
}