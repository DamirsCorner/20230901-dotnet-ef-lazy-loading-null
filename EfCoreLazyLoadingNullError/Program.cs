using EfCoreLazyLoadingNullError;

var context = new SampleDbContext();

try
{
    var customer = await context.Customers.FindAsync(1);
    Console.WriteLine($"Customer: {customer?.FirstName} {customer?.LastName}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

try
{
    var user = await context.Users.FindAsync(1);
    var customer = user?.Customer;
    Console.WriteLine($"Customer: {customer?.FirstName} {customer?.LastName}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
