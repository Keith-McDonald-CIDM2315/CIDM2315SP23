using System.Diagnostics;

namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        //Z = 4*X*X+3*Y
        double X = 2.5;
        double Y = 3.3;
        double Z = 4 * X * X + 3 * Y;
        Console.WriteLine("X = 2.5, Y = 3.3");
        Console.WriteLine("The value of Z is "+Z);
    }
}
