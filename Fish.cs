namespace MyFirstProgram;

public class Fish : IPrey,IPredator
{
    public void Flee()
    {
        Console.WriteLine("The small fish is fleeing");
    }

    public void Chase()
    {
        Console.WriteLine("The big fish is chasing its prey");
    }
}