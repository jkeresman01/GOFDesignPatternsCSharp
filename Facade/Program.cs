// using Facade.Problem;
//
// var paymentService = new PaymentService();
// var inventoryService = new InventoryService();
// var shippingService = new ShippingService();
// var notificationService = new NotificationService();
//
// var request = new OrderRequest();
// bool isOrderPlaced = false;
//
// // Client must manage all the complexity and know the correct order
// if (!paymentService.ValidateCard(request.CardNumber))
// {
//     Console.WriteLine("Order failed: Invalid card");
// }
// else if (!inventoryService.CheckAvailability(request.ItemIDs))
// {
//     Console.WriteLine("Order failed: Items not available");
// }
// else if (!shippingService.ValidateAddress(request.Address))
// {
//     Console.WriteLine("Order failed: Invalid address");
// }
// else if (!paymentService.ProcessPayment(request.CardNumber, request.Amount))
// {
//     Console.WriteLine("Order failed: Payment declined");
// }
// else
// {
//     inventoryService.ReserveItems(request.ItemIDs);
//     var trackingNumber = shippingService.ScheduleDelivery(request.Address);
//     notificationService.SendOrderConfirmation(request.LastName, trackingNumber);
//     isOrderPlaced = true;
//     Console.WriteLine("\nOrder completed successfully");
// }
//
// if (!isOrderPlaced)
// {
//     Console.WriteLine("No can do for order, we are truly sorry");
// }

using Facade.Solution;

var orderFacade = new OrderFacade();

// One simple call handles all the complexity
bool isOrderPlaced = orderFacade.PlaceOrder(new OrderRequest());

if (!isOrderPlaced)
{
    Console.WriteLine("No can do for order, we are truly sorry");
}
