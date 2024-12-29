namespace Visitor.Solution;

public class EmailVisitor : Visitor
{
    public void VisitRetail(RetailClient retailClient) 
        => Console.WriteLine($"Sending retail marketing tips to email {retailClient.Email}.");

    public void VisitLaw(LawClient lawClient)
        => Console.WriteLine($"Sending law tips to email {lawClient.Email}.");

    public void VisitRestaurant(ResturantClient restaurantClient)
        => Console.WriteLine($"Sending restaurant tips to email {restaurantClient.Email}.");
}