namespace MyFirstProgram;

public class Car
{
    public String make;
    public String model;
    public int year;
   public static int numberOfcars;

    public  Car(String make, String model, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        numberOfcars++;
    }


    public void Move(){
        Console.WriteLine(year+ " " +make + " " +" is moving");
    }

    public void Stop()
    {
        Console.WriteLine(year+" "+ make +" "+model+" has stopped");
    }
    public static void endRace()
    {
        Console.WriteLine("The race has ended!");
    }

    public void Race()
    {
        Console.WriteLine($"{make} has won the race!");
    }
}