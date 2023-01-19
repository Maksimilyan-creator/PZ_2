// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y");
double y = Convert.ToDouble(Console.ReadLine());
Plane plane = new(x, y);
Console.WriteLine(plane.distance());
sealed class Plane
{
    private readonly double first;
    private readonly double second;
  
    public Plane(double a, double c)
    {
        first = a;
        second = c;
    }
    public double First
    {
        get => first;
    }
    public double Second
    {
        get => second;
    }
    public double distance()
        => second - first;
}

