// See https://aka.ms/new-console-template for more information
using LinqQueryProjesi;

List<int> sayilar = new List<int>()
            {
                10, 99, 6, 7, 104, 1, 75, 64, 2, 5,8, 9, 21
            };

/* var ciftsayilar = from sayi in sayilar
                  where sayi % 2 == 0
                  orderby sayi descending
                  select sayi; */

/* var ciftsayilar = sayilar.Where(sayi => sayi % 2 == 0)
                  .OrderByDescending(sayi => sayi)
                  .ToList(); */

/* foreach (var sayi in ciftsayilar)
{
    Console.WriteLine(sayi);
} */

List<Urun> urunler = new List<Urun>() {
            new Urun(){ KategoriId= 1, Marka ="Arçelik", Model ="Arçelik1", SatisFiyati=8000},
            new Urun(){ KategoriId= 2, Marka ="Samsung",Model ="Samsung1", SatisFiyati=8400},
            new Urun(){ KategoriId= 2, Marka ="Samsung",Model ="Samsung2", SatisFiyati=7400},
            new Urun(){ KategoriId= 2, Marka ="Samsung",Model ="Samsung3", SatisFiyati=9000},
            new Urun(){ KategoriId= 1, Marka ="Arçelik",Model ="Arçelik2", SatisFiyati=10000},
            new Urun(){ KategoriId= 1, Marka ="Arçelik",Model ="Arçelik3", SatisFiyati=6000}
            };
/* var ceptelefonlari = from ct in urunler
                     where ct.KategoriId == 2 && ct.SatisFiyati > 8000
                     orderby ct.SatisFiyati
                     select new
                     {
                         KategoriId = ct.KategoriId,
                         Model = ct.Model,
                         SatisFiyati = ct.SatisFiyati
                     }; */
/* var ceptelefonlari = urunler.Where(ct => ct.KategoriId == 2 && ct.SatisFiyati > 8000).OrderBy(ct => ct.SatisFiyati)
    .Select(ct => new
    {
        KategoriId = ct.KategoriId,
        Model = ct.Model,
        SatisFiyati = ct.SatisFiyati
    }).ToList();
foreach (var ct in ceptelefonlari)
{
    Console.WriteLine($"KategoriId: {ct.KategoriId}, Model: {ct.Model}, SatisFiyati: {ct.SatisFiyati}");
} */

/* bool varMi = urunler.Where(x => x.Marka.Contains("Arçelik") && x.SatisFiyati > 8000)
                    .Any();

Console.WriteLine(varMi ? "Arçelik markalı ürün var" : "Arçelik markalı ürün yok"); */
/* var enpahaliurun = urunler.OrderByDescending(x => x.SatisFiyati).FirstOrDefault();
System.Console.WriteLine($"En pahalı ürün: {enpahaliurun.Marka} {enpahaliurun.Model}, Fiyat: {enpahaliurun.SatisFiyati}"); */
/* var seciliUrunler = urunler.First(x => x.Marka.Contains("Arçelik"));
if (seciliUrunler != null)
{
    Console.WriteLine($"Seçili ürün: {seciliUrunler.Marka} {seciliUrunler.Model}, Fiyat: {seciliUrunler.SatisFiyati}");
}
else
{
    Console.WriteLine("Seçili ürün bulunamadı.");
} */
List<Kategoriler> kategoriler = new List<Kategoriler>() {
            new Kategoriler(){ KategoriAdi="Beyaz Eşya", KategoriId=1},
            new Kategoriler(){ KategoriAdi="Cep Telefonları", KategoriId=2}
            };
foreach (var itemkat in kategoriler)
{
    foreach (var itemurun in urunler.Where(x => x.KategoriId == itemkat.KategoriId))
    {
        itemkat.Urunler.Add(itemurun);
    }
}
/* var samsungolmayan = from kat in kategoriler
                     where kat.Urunler.Any(x => x.Marka != "Samsung")
                     select kat; */
/* var samsungolmayan = kategoriler.Where(kat => kat.Urunler.Any(x => x.Marka != "Samsung")).ToList();
foreach (var kat in samsungolmayan)
{
    Console.WriteLine($"Kategori: {kat.KategoriAdi}");
    foreach (var urun in kat.Urunler)
    {
        Console.WriteLine($"Ürün: {urun.Marka} {urun.Model}, Fiyat: {urun.SatisFiyati}");
    }
} */
/* var seciliUrun = urunler.FirstOrDefault(x => x.Marka == "Arçelik");
bool varmi = urunler.Contains(seciliUrun);

Console.WriteLine(varmi ? "Arçelik markalı ürün var" : "Arçelik markalı ürün yok"); */
/* var kategoriurunler = from urun in urunler
                      join kategori in kategoriler on urun.KategoriId equals kategori.KategoriId
                      select new
                      {
                          kategori.KategoriId,
                          kategori.KategoriAdi,
                          urun.Marka,
                          urun.Model,
                          urun.SatisFiyati
                      }; */
var kategoriurunler = urunler.Join(kategoriler,
    urun => urun.KategoriId,
    kategori => kategori.KategoriId,
    (urun, kategori) => new
    {
        kategori.KategoriId,
        kategori.KategoriAdi,
        urun.Marka,
        urun.Model,
        urun.SatisFiyati
    }).ToList();
foreach (var item in kategoriurunler)
{
    Console.WriteLine($"Kategori: {item.KategoriAdi}, Ürün: {item.Marka} {item.Model}, Fiyat: {item.SatisFiyati}");
}