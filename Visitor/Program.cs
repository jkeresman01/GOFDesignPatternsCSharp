// See https://aka.ms/new-console-template for more information

using Visitor.Solution;

var restaurant = new ResturantClient("Restaurant", "restaurant@gmail.com");
var retail = new RetailClient("Retail", "retail@gmail.com");
var law = new LawClient("Law", "law@gmail.com");

var clients = new List<Client>() { restaurant, retail, law };

clients.ForEach(client =>
{
    client.Accept(new EmailVisitor());
    client.Accept(new ExportJsonVisitor());
});