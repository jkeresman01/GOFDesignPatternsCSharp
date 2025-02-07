namespace TemplateMethod.Problem;

public class Tea
{
    public void MakeBevarage()
    {
        BoilWater();
        PourWaterInCup();
        Brew();
        AddCondiments();
    }
    
    override string ToString() => $"Beverage: {GetType().Name}";

    private void BoilWater() => Console.WriteLine("Boiling water");
    
    private void PourWaterInCup() => Console.WriteLine("Pouring water in cup!");
    
    private void Brew() => Console.WriteLine("Brew!");

    private void AddCondiments()
    {
        if (CustomerWantsCondiments())
        {
            Console.WriteLine("Adding lemon to the tea.");
        }
    }

    private bool CustomerWantsCondiments()
    {
        Console.WriteLine("Do you want to add Condiments? (y/n)");
        string answer = Console.ReadLine();
        return answer.ToLower().Equals("y");
    }
}