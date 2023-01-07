using Classes;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!\n");


        GarageClass gClass = new GarageClass();
        gClass.Print();

        CarClass cClass = new CarClass();
        cClass.Print();

        GarageClass garClass = new GarageClass("Rang", 500);
        garClass.Print();

        Console.ReadKey();
    }
}