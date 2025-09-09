class Program
{
    static void Main()
    {
        Console.Write("Write number A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Write number B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("\n");

        Rectangle Rec = new(a, b);

        Console.WriteLine($"Area is {Rec.Area}; Perimeter is {Rec.Perimeter}");


    }
}

class Rectangle
{
    double sideA, sideB;

    public Rectangle(double sideA, double sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }

    private double CalculateArea()
    {
        return sideA * sideB;
    }

    private double CalculatePerimeter()
    {
        return (sideA + sideB) * 2;
    }

    public double Area
    {
        get
        {
            return CalculateArea();
        }
    }

    public double Perimeter
    {
        get
        {
            return CalculatePerimeter();
        }
    }
}
