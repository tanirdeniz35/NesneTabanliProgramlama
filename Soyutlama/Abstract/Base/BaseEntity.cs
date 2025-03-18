public abstract class BaseEntity
{

    public int Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; }

    public virtual void Yaz()
    {
        System.Console.WriteLine($"Id:{Id}");
        System.Console.WriteLine($"Created Date: {CreatedDate}");
        System.Console.WriteLine($"Created By: {CreatedBy}");
    }

    public abstract void Yaz2();

}