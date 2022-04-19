//Olmaması gereken
/*public class Fabrika
   {
       public void TelefonUret() {
           //bla bla
       }
       public void TelefonSat() { 
           //bla bla
       }
   }*/

//Olması gereken
public class Fabrika
{
    public void TelefonUret()
    {
        //bla bla
    }
}
public class Satis
{
    public void TelefonSat()
    {
        //bla bla

        FaturaKes();
    }

    public void FaturaKes()
    {

    }
}

class Program
{

    static void Main(string[] args)
    {


    }
}