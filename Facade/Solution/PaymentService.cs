namespace Facade.Solution;

public class PaymentService
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine($"PaymentService: Validating card {cardNumber[..4]}****");
        return cardNumber.Length >= 10;
    }

    public bool ProcessPayment(string cardNumber, decimal amount)
    {
        Console.WriteLine($"PaymentService: Processing payment of ${amount:F2}");
        return true;
    }
}
