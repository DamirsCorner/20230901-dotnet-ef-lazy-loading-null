namespace EfCoreLazyLoadingNullError;
public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; } = null!;

    public User(string username, string passwordHash)
    {
        this.Username = username;
        this.PasswordHash = passwordHash;
    }
}
