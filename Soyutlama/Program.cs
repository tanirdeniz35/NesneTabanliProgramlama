// See https://aka.ms/new-console-template for more information


{
    UserRepository userRepository = new();

    User user = new()
    {
        Id = 1,
        CreatedDate = DateTime.Now,
        CreatedBy = "Admin",
        Ad = "Deniz",
        Soyad = "Aktaş",
        Sifre = "123"
    };
    userRepository.Add(user);


    user = new()
    {
        Id = 2,
        CreatedDate = DateTime.Now,
        CreatedBy = "Admin",
        Ad = "Ebu Talip",
        Soyad = "Cengiz",
        Sifre = "456"
    };
    userRepository.Add(user);

    foreach (var item in userRepository.Users)
    {
        item.Yaz();
        item.Yaz2();
    }

    user = userRepository.Users.Find(x => x.Id == 2);
    userRepository.Remove(user);

    System.Console.WriteLine("-------------------------Silmeden Sonraki Görünüm---------------------");
    foreach (var item in userRepository.Users)
    {
        item.Yaz();
        item.Yaz2();
    }

    IUserRepository repos = userRepository;
    repos.Yaz3();


    Product product = new()
    {
        Id = 1,
        CreatedBy = "Admin",
        CreatedDate = DateTime.Now,
        ProductName = "Mouse",
        UnitPrice = 3000
    };
    System.Console.WriteLine("------------------");
    AdYazdir(product);
    AdYazdir(user);
}

void AdYazdir(BaseEntity item)
{
    item.Yaz2();
}
