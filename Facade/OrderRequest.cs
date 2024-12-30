namespace Facade;

public class OrderRequest
{
    public string Name { get; set; } = "Pero";
    public string CardNumber { get; set; } = "123124244545";
    public decimal Amout { get; set; } = (decimal)20.123123;
    public string Address { get; set; } = "123 Springfiled Way, Texas";
    public string[] ItemIDs { get; set; } = ["1", "1111", "22", "22", "2344", "23", "123"];
}