public class Product : BaseEntity
{
    public string ProductName { get; set; }

    public decimal UnitPrice { get; set; }

    public override void Yaz2()
    {
        System.Console.WriteLine($"Ürün Adı: {ProductName}");
        System.Console.WriteLine($"Fiyatı: {UnitPrice}");

    }
}