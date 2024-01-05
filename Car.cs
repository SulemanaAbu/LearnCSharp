namespace MyFirstProgram;

public class Car
{
  public String make;
  public String model;
  public int year;
  public String color;

  public Car(String make, String model, int year, String color)
  {
    this.make = make;
    this.model = model;
    this.year = year;
    this.color = color;
  }

  public override string ToString()
  {
    String message = "This is a " + make + " " + model;
    return message;
  }
}