public class UserRepository : IUserRepository
{
    public List<User> Users { get; set; } = new();
    public void Add(User user)
    {
        Users.Add(user);
    }

    public void Remove(User user)
    {
        Users.Remove(user);
    }
}