public class Kaplan:Kedi
{
    public override void AvYakala()
    {
         Console.WriteLine("Kaplan av yakaladı");
    }
    public Kaplan(string cins):base(cins)
    {
        AvYakala();
    }
}