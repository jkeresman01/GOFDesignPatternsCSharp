namespace Facade;

public class InventoryService
{
    public bool CheckAvailability(string[] itemIds)
    {
        Console.WriteLine($"InventoryService: Checking availability for {itemIds.Length} items");
        return true;
    }

    public void ReserveItems(string[] itemIds)
    {
        Console.WriteLine($"InventoryService: Reserving {itemIds.Length} items");
    }
}
