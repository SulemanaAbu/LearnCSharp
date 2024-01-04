namespace MyFirstProgram;

public class Car
{
    public String make;
    public String model;
    public int year;

    public Car(String make, String model, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
    }


    public void Move(){
        Console.WriteLine(year+ " " +make + " " +" is moving");
    }

    public void Stop()
    {
        Console.WriteLine(year+" "+ make +" "+model+" has stopped");
    }
}