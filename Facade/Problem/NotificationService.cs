namespace Facade.Problem;

public class NotificationService
{
    public void SendOrderConfirmation(string customerName, string trackingNumber)
    {
        Console.WriteLine($"NotificationService: Sending confirmation to {customerName}");
        Console.WriteLine($"NotificationService: Your tracking number is {trackingNumber}");
    }
}
