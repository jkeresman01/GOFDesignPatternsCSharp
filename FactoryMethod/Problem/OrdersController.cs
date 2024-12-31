namespace FactoryMethod;

public class OrdersController : Controller
{
    public void ListOrders()
    {
        var orders = new Dictionary<string, object>()
        {
            { "Red socks", "$12.26" },
            { "Black socks", "$12.26" },
            { "Pink shirt", "$22.26" }
        };
        
        Render("orders.php" , orders);
    }

    public void GetOrderByID(int id)
    {
        var order = new Dictionary<string, object>() { { "Red socks", "$12.34" } };
        Render("order.php" , order);
    }
}