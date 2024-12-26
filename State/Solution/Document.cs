namespace State.Solution;

public class Document
{
    public State State { get; set; }
    public UserRoles UserRole { get; set; }

    public Document(UserRoles userRole)
    {
        UserRole = userRole;
        State = new DraftState(this);
    }
    public override string ToString() => $"Document => State: {State}, UserRole: {UserRole}";
    
    public void Publish()
    {
        State.Publish();
    }
}