namespace Facade.Solution;

public class OrderRequest
{
    public string FirstName { get; set; } = "Robert";
    public string LastName { get; set; } = "MeDiro";
    public string CardNumber { get; set; } = "123124244545";
    public decimal Amount { get; set; } = (decimal)20.123123;
    public string Address { get; set; } = "100 Charming Avenue";
    public string[] ItemIDs { get; set; } = ["1", "1111", "22", "22", "2344", "23", "123"];
}
