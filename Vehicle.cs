namespace MyFirstProgram;

 abstract public class Vehicle
{

    public String make;
    

    public void Move()
    {
        Console.WriteLine($"{make}  is moving");
    }
    public void Stop()
    {
        Console.WriteLine($"{make}  is stopped");
    }
    
}