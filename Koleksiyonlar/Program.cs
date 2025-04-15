{
    // See https://aka.ms/new-console-template for more information
    // int[] intDizisi=new int[100];
    // for(int i=0;i<100;i++) 
    // {
    //     intDizisi[i]=i+1;
    // }
    // for(int i=0;i<100;i++)
    // {
    //     Console.WriteLine(intDizisi[i]);
    // }

    // List<int> intListesi=new();
    // for(int i=0;i<100;i++) 
    // {
    //     intListesi.Add(i+1);
    // }
    // for(int i=0;i<100;i++)
    // {
    //     Console.WriteLine(intListesi[i]);
    // }
    // intListesi.Remove(50);
    // foreach (int i in intListesi)
    // {
    //     Console.WriteLine(i);
    // }
    // var indis=intListesi.IndexOf(70);

    // intListesi[indis]=150;

    // for(int i=0;i<intListesi.Count();i++)
    // {
    //     Console.WriteLine(intListesi[i]);
    // }

    // List<int> intListesi=new();
    // for(int i=0;i<100;i++) 
    // {
    //     intListesi.Add(i+1);
    // }
    // var indis=intListesi.IndexOf(70);
    //  int x=intListesi[indis];
    // Degistir(ref x);
    // Hesapla(3, out int z);
    // Console.WriteLine(z);

    // string sayi="100a";
    // if(int.TryParse (sayi, out int sonuc))
    // { 
    // Console.WriteLine(sonuc*2);
    // }
    // else
    // Console.WriteLine("Uygun bir değer giriniz");

    HashSet<int> elemanlar = new HashSet<int>();
    elemanlar.Add(12);
    elemanlar.Add(13);
    elemanlar.Add(14);
    elemanlar.Add(12);
    elemanlar.Add(15);
    elemanlar.Add(14);
    foreach (int i in elemanlar)
    {
        Console.WriteLine(i);
    }

    Dictionary<int, string> dict = new Dictionary<int, string>();
    dict.Add(1, "Ali");
    dict.Add(2, "Veli");
    dict.Add(5, "Orhan");
    Console.WriteLine(dict[5]);
    foreach (int i in dict.Keys)
    {
        Console.WriteLine(dict[i]);
    }
    IEnumerable<int> list = new List<int>();

}
void Degistir(ref int y)
{
    y = 150;
}
void Hesapla(int x, out int y)
{
    y = x * x;
}