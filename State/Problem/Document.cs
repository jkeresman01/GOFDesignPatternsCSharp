namespace State;

public class Document
{
    public DocumentState State { get; set; }
    public UserRoles UserRole { get; set; }

    public Document(DocumentState state, UserRoles userRole)
    {
        State = state;
        UserRole = userRole;
    }

    public override string ToString() => $"State: {State}, User: {UserRole}";

    //Violates SOLID -> Open closed principle
    public void Publish()
    {
        if (State == DocumentState.Draft)
        {
            State = DocumentState.Moderation;
        }

        if (State != DocumentState.Moderation) return;
        
        if (UserRole == UserRoles.Admin)
        {
            State = DocumentState.Published;
        }
    }
}