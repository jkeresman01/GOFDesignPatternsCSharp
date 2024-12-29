namespace Visitor.Solution;

public class ResturantClient : Client
{
    public ResturantClient(string name, string email) : base(name, email)
    {
    }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitRestaurant(this);
    }
}