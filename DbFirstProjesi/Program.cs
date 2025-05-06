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

/* Department department = new()
{
    DeptName = "İşletme"
};

using (var dbContext = new DbFirstDbContext())
{
    dbContext.Departments.AddRange(department);
    dbContext.SaveChanges();

} */

/* 
User user = new()
{
    NameSurname = "Mehmet Kaya",
    Username = "Mehmet",
    Password = "1234",
    DepartmentId = 3

};
using (var dbContext = new DbFirstDbContext())
{
    dbContext.Users.AddRange(user);
    dbContext.SaveChanges();

} */



using (var dbContext = new DbFirstDbContext())
{
    /* var dataList = dbContext.Users
        .Include(x => x.Department).Where(x => x.DepartmentId == 1)
        .Select(x => new
        {
            x.Id,
            x.Username,
            x.NameSurname,
            x.Department.DeptName
        })
        .ToList();

    var departments = dataList;



 */

    var departments = dbContext.Departments.Where(x => x.Id == 3)
        .SelectMany(x => x.Users)
        .ToList();
    foreach (var item in departments)
    {
        System.Console.WriteLine($"{item.Id} {item.Username} {item.NameSurname} ");
    }


    /*  foreach (var item in departments)
     {
         System.Console.WriteLine($"{item.Id} {item.DeptName}");
     } */
}