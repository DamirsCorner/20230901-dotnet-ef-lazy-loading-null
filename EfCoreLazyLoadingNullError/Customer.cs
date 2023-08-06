namespace EfCoreLazyLoadingNullError;
public class Customer
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
    public virtual User? User { get; set; }

    public Customer(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

}
