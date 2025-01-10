namespace Builder;

public class Order
{
    public int Number { get; set; }
    public DateTime CreatedOn { get; set; }

    public override string ToString() => $"Order [ Number: {Number}, CreatedOn: {CreatedOn} ]";
}