namespace Facade;

public class ShippingService
{
    public bool ValidateAddress(string address)
    {
        Console.WriteLine($"ShippingService: Validating address '{address}'");
        return !string.IsNullOrWhiteSpace(address);
    }

    public string ScheduleDelivery(string address)
    {
        Console.WriteLine($"ShippingService: Scheduling delivery to '{address}'");
        return $"SHIP-{DateTime.Now:yyyyMMddHHmmss}";
    }
}
