using System;
class Program{
    //Area of  circle
    static double Circle(double radius)
    {
        return Math.PI * radius *radius;
    }

    //Area of a triangle
    static double Triangle(double base, double height)
    {
        return 0.5 * base * height;
    }

    //Area of a square
    static double Square (double length)
    {
        return length * length
    }

    //Area of a rectangle
    static double Rectangle (double length, double breadth)
    {
        return length * breadth;
    }

    //Quadratic Formula
    static void QuadraticFormula(double a, double b, double c)
    {
        double discriminant = (b * b) - (4 * a * c);
        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Roots are real and different. Root1: {root1}, Root2: {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"Roots are real and same. Root: {root}");
        }
        else
        {
            Console.WriteLine("Roots are complex and different.");
        }
    }

}