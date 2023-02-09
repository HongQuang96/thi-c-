using practice.Exercise_1;
using practice.Exercise_2;

public class Program
{
    public static void Main(string[] args)
    {
        // Exercise 1

        Console.WriteLine("Enter radius of cylinder:");
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter height of cylinder:");
        double height = Convert.ToDouble(Console.ReadLine());

        Cylinder cld = new Cylinder(radius, height);
        cld.Process();
        Console.WriteLine("Cylinder Result:");
        cld.Result();
        Console.WriteLine();


        // Exercise 2
        Lion lion = new Lion("Lion", 150);
        lion.Show();
        Console.WriteLine();

        Tiger tiger = new Tiger( "Tiger", 140);
        tiger.Show();
        Console.WriteLine();

    }


}
