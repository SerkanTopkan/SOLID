//Senaryomuz: Kamera ile hedef izlenir, yer tespiti yapılır, ana kumandaya bilgi gönderilir, ana kumanda dan gelen yanıta göre de ateşleme yapılır.

interface IHucum
{
    string KameraIzle();
    bool AnaKumandayaBildir(string bilgi);
    void Ates();
}

public class AnkaHucum : IHucum
{
    public bool AnaKumandayaBildir(string bilgi)
    {
        //durum tespiti yapıldı ne yapalım
        //füze ateşleyin emri dönüyor.
        return true;
    }
    public void Ates()
    {
        //Ateşleme sistemi çalıştı
    }
    public string KameraIzle()
    {
        //İzleme başladı ve koordinat bilgisi verildi
        return "10 kişilk unsur tespit edildi";
    }
}
/*Yazdığımız kod sayesinde sisteme her eklenen insansız hava aracına bu interface yolu ile ilgili işlemleri yaptırabiliriz.
Ama bir sorun var, envantere giren bir araç kamera ile izleme yapabiliyor ama füze sistemi yok. Yazdığımız interface bu araç için geçersiz olacaktır. Çünkü*/

/*void Ates();
Metodunun içini boş geçmek zorunda kalacağız yeni araç da ve genel de;
throw new NotImplementedException();
Bu şekilde yazılan bir kod her yönden eksik ve kullanışsız olacaktır.*/

interface IIzleme
{
    string KameraIzle();
    bool AnaKumandayaBildir(string bilgi);
}
interface IHucum2
{
    void Ates();
}

public class AnkaHucum2 : IIzleme2, IHucum
{
    public bool AnaKumandayaBildir(string bilgi)
    {
        //durum tespiti yapıldı ne yapalım
        //füze ateşleyin emri dönüyor.
        return true;
    }
    public void Ates()
    {
        //Ateşleme sistemi çalıştı
    }
    public string KameraIzle()
    {
        //İzleme başladı ve koordinat bilgisi verildi
        return "10 kişilk unsur tespit edildi";
    }
}

public class Bayraktar : IIzleme2
{
    public bool AnaKumandayaBildir(string bilgi)
    {
        //durum tespiti yapıldı.
        return true;
    }
    public string KameraIzle()
    {
        return "10 kişilk unsur tespit edildi";
    }
}
class Program
{

    static void Main(string[] args)
    {
        // AnkaHucum ankaHucum = new AnkaHucum();
        // string bilgi = ankaHucum.KameraIzle();
        // bool durum = ankaHucum.AnaKumandayaBildir(bilgi);
        // if (durum)
        // {
        //     ankaHucum.Ates();
        // }

        //Doğru kullanım
        AnkaHucum ankaHucum = new AnkaHucum();
        string bilgi = ankaHucum.KameraIzle();
        bool durum = ankaHucum.AnaKumandayaBildir(bilgi);
        if (durum)
        {
            ankaHucum.Ates();
        }
        Bayraktar bayraktar = new Bayraktar();
        string bilgi = bayraktar.KameraIzle();
        bayraktar.AnaKumandayaBildir(bilgi);

    }
}