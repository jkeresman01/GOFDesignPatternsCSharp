namespace Builder;

public class OrderBuilder
{
    private int _number;
    private DateTime _createdOn;
    
    private OrderBuilder(){}

    public static OrderBuilder Empty() => new();

    public OrderBuilder WithNumber(int number)
    {
        _number = number;
        return this;
    }

    public OrderBuilder WithCreatedOn(DateTime createdOn)
    {
        _createdOn = createdOn;
        return this;
    }

    public Order Build() => new Order(){Number = _number, CreatedOn = _createdOn};
}