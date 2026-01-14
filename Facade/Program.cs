using Facade;

// The client only needs to interact with the facade
// instead of dealing with multiple complex subsystems
var orderFacade = new OrderFacade();

// One simple call handles all the complexity
bool isOrderPlaced = orderFacade.PlaceOrder(new OrderRequest());

if (!isOrderPlaced)
{
    Console.WriteLine("No can do for order, we are truly sorry");
}