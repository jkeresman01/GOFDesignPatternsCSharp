namespace Visitor.Solution;

public interface Visitor
{
    void VisitRetail(RetailClient retailClient);
    void VisitLaw(LawClient lawClient);
    void VisitRestaurant(ResturantClient restaurantClient);
}