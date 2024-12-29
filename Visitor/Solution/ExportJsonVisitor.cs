namespace Visitor.Solution;

public class ExportJsonVisitor : Visitor
{
    public void VisitRetail(RetailClient retailClient)
        => Console.WriteLine($"Exporting retail client info in JSON format {retailClient}.");
    
    public void VisitLaw(LawClient lawClient)
        => Console.WriteLine($"Exporting law client info in JSON format {lawClient}.");

    public void VisitRestaurant(ResturantClient restaurantClient)
        => Console.WriteLine($"Exporting law client info in JSON format {restaurantClient}.");
}