namespace Visitor.Solution;

public class RetailClient : Client
{
    public RetailClient(string name, string email) : base(name, email)
    {
    }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitRetail(this);
    }
}