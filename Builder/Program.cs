using Builder;

var order1 =  OrderBuilder.Empty()
                         .WithNumber(1)
                         .WithCreatedOn(DateTime.Now)
                         .Build();

var order2 =  OrderBuilder.Empty()
                         .WithNumber(2)
                         .WithCreatedOn(DateTime.UnixEpoch)
                         .Build();

Console.WriteLine($"order1: {order1}");
Console.WriteLine($"order2: {order2}");
