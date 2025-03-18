public class User : BaseEntity
{


    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Sifre { get; set; }



    public override void Yaz2()
    {
        System.Console.WriteLine($"Ad: {Ad}");
        System.Console.WriteLine($"Soyad Ad: {Soyad}");
        System.Console.WriteLine($"Şifre: {Sifre}");

    }
}