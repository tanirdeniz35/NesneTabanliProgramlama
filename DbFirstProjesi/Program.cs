// See https://aka.ms/new-console-template for more information
using DbFirstProjesi.Contexts;
using DbFirstProjesi.Data.Entities;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");


/* using (var dbContext = new DbFirstDbContext())
{
    Department department = new()
    {
        DeptName = "YBS"
    };

    List<User> users = new();
    User user = new()
    {
        NameSurname = "Alperen İnal",
        Username = "Alperen",
        Password = "123",
        Department = department

    };
    users.Add(user);
    user = new()
    {
        NameSurname = "Vahap Unat",
        Username = "Vahap",
        Password = "456",
        Department = department

    };
    users.Add(user);

    dbContext.Users.AddRange(users);
    dbContext.SaveChanges();


}
 */

using (var dbContext = new DbFirstDbContext())
{
    var dataList = dbContext.Users.Include(x => x.Department).ToList();
    foreach (var item in dataList)
    {
        System.Console.WriteLine($"{item.Id} {item.Username} {item.NameSurname} {item.Department.DeptName}");
    }

}