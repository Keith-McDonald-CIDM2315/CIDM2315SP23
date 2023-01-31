namespace Homework2Question2;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input first num: ");
        Console.WriteLine("12");
        Console.WriteLine("Please input second num: ");
        Console.WriteLine("11");
        Console.WriteLine("Please input third num: ");
        Console.WriteLine("14");
        Console.WriteLine("The smallest value is: 11");
        string X_string = Console.ReadLine();
        int X = Convert.ToInt16(X_string);
        int a = 12, b = 11, c = 14;
        if (a < b)
        {
            if (a < c)
            {
                Console.WriteLine("The smallest num: a");
            }
            else
            {//a<=c
                Console.WriteLine("The smallest num: c");
            }
        }
            else
        {   //b<=a
            if (b < c)
            {
                Console.WriteLine("The smallest num: b");
            }
        }
    }
}
