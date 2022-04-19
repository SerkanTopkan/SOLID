/*Yanlış kullanım örneği ile başlayalım*/
// public enum SekerTipi
// {
//     Elmali,
//     Naneli
// }
// public class SekerFabrika
// {
//     public void SekerUret(SekerTipi sekerTipi)
//     {
//         switch (sekerTipi)
//         {
//             case SekerTipi.Elmali:
//                 //Elmalı üretim yapıldı
//                 Console.WriteLine($"Şeker Tipi: {SekerTipi.Elmali}");
//                 break;
//             case SekerTipi.Naneli:
//                 //Naneli üretim yapıldı
//                 Console.WriteLine($"Şeker Tipi: {SekerTipi.Naneli}");
//                 break;

//         }
//     }
// }



class Program
{

    static void Main(string[] args)
    {
        /*Hatalı kullınım*/
        // SekerFabrika fabrika = new SekerFabrika();
        // fabrika.SekerUret(SekerTipi.Elmali);
        // fabrika.SekerUret(SekerTipi.Naneli);

        //Olması gereken
        SekerFabrika fabrika = new SekerFabrika();
        fabrika.SekerUret(new Naneli());
        //fabrika.SekerUret(new Elmali());

    }
}


/*Olması gereken*/

public class SekerFabrika
{
    public void SekerUret(Seker sekerTipi)
    {
        sekerTipi.Uret();
    }
}
public abstract class Seker
{
    public abstract void Uret();
}

public class Naneli : Seker
{
    public override void Uret()
    {
        Console.WriteLine("Naneli üretildi");
    }
}

public class Elmali : Seker
{
    public override void Uret()
    {
        Console.WriteLine("Elmalı üretildi");
    }
}

public class Visneli : Seker
{
    public override void Uret()
    {
        Console.WriteLine("Vişneli üretildi");
    }
}
