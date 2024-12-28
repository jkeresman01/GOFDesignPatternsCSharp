namespace DefaultNamespace;

public class Coffee
{
    public void MakeBevarage()
    {
        BoilWater();
        PourWaterInCup();
        Brew();
        AddCondiments();
    }

    private void BoilWater() => Console.WriteLine("Boiling water");
    
    private void PourWaterInCup() => Console.WriteLine("Pouring water in cup!");
    
    private void Brew() => Console.WriteLine("Brew coffee for 5 min!");

    private void AddCondiments()
    {
        if (CustomerWantsCondiments())
        {
            Console.WriteLine("Adding cream to the tea.");
        }
    }

    private bool CustomerWantsCondiments()
    {
        Console.WriteLine("Do you want to add Condiments? (y/n)");
        string answer = Console.ReadLine();
        return answer.ToLower().Equals("y");
    }
}