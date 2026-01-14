namespace Facade.Solution;

public class OrderFacade
{
    private readonly PaymentService _paymentService = new();
    private readonly InventoryService _inventoryService = new();
    private readonly ShippingService _shippingService = new();
    private readonly NotificationService _notificationService = new();

    public bool PlaceOrder(OrderRequest request)
    {
        Console.WriteLine("OrderFacade: Starting order processing");

        if (!_paymentService.ValidateCard(request.CardNumber))
        {
            Console.WriteLine("Order failed: Invalid card");
            return false;
        }

        if (!_inventoryService.CheckAvailability(request.ItemIDs))
        {
            Console.WriteLine("Order failed: Items not available");
            return false;
        }

        if (!_shippingService.ValidateAddress(request.Address))
        {
            Console.WriteLine("Order failed: Invalid address");
            return false;
        }

        if (!_paymentService.ProcessPayment(request.CardNumber, request.Amount))
        {
            Console.WriteLine("Order failed: Payment declined");
            return false;
        }

        _inventoryService.ReserveItems(request.ItemIDs);

        var trackingNumber = _shippingService.ScheduleDelivery(request.Address);

        _notificationService.SendOrderConfirmation(request.LastName, trackingNumber);

        Console.WriteLine("\nOrderFacade: Order completed successfully");
        return true;
    }
}
