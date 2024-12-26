// GOF Iterator pattern

using Iterator.Solution;

var shoppingList = new ShoppingList();

shoppingList.Push("Milk");
shoppingList.Push("Bread");
shoppingList.Push("Steak");

var it = shoppingList.CreateIterator();

while (it.HasNext())
{
    Console.WriteLine(it.Current());
    it.Next();
}