public class Kedi
{
    public int AyakSayisi { get; set; }


    public Kedi()
    {
        Console.WriteLine("Kedi sınıfının yapıcı metodu çalıştı");
    }
    private readonly string _cins;
    public Kedi(string cins)
    {
        _cins = cins;
        Console.WriteLine($"{_cins} cinsi kedi avı yakaladı.");
    }

    public virtual void AvYakala()
    {
        Console.WriteLine($"{_cins} cinsi kedi avı yakaladı.");
    }
}