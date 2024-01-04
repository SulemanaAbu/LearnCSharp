namespace MyFirstProgram;

public class Human
{
   public String name;
   public int age;
   public Human(String name , int age)
   {
      this.name = name;
      this.age = age;
   }

   public void eat()
   {
      Console.WriteLine(name+" is eating");
   }

   public void speak()
   {
      Console.WriteLine(name +" is speaking");
   }
    
}