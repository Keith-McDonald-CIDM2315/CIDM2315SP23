namespace Homework2part1;
class Program
{

    static void Main(string[] args)
   {
    int a = 4, b = 3, c = 2, d = 1, f = 0;

    if(a == 4)
{
        Console.WriteLine("Please input letter grade: ");
        Console.WriteLine("A");
        Console.WriteLine("GPA point: 4");
    // code block to be executed when if condition1 evaluates to true
}
else if(b == 3)
{
        Console.WriteLine("Please input letter grade: ");
        Console.WriteLine("B");
        Console.WriteLine("GPA point: 3");
    // code block to be executed when 
    //      condition1 evaluates to false
    //      condition2 evaluates to true
}
else if(c == 2)
{
        Console.WriteLine("Please input letter grade: ");
        Console.WriteLine("C");
        Console.WriteLine("GPA point: 2");
    // code block to be executed when 
    //      condition1 evaluates to false
    //      condition2 evaluates to false
    //      condition3 evaluates to true
}
else if(d == 1)
{
        Console.WriteLine("Please input letter grade: ");
        Console.WriteLine("D");
        Console.WriteLine("GPA point: 1");
    // code block to be executed when 
    //      condition1 evaluates to false
    //      condition2 evaluates to false
    //      condition3 evaluates to false
    //      condition4 evaluates to true
}
else if(f == 0)
{
        Console.WriteLine("Please input letter grade: ");
        Console.WriteLine("F");
        Console.WriteLine("GPA point: 0");
    // code block to be executed when 
    //      condition1 evaluates to false
    //      condition2 evaluates to false
    //      condition3 evaluates to false
    //      condition4 evaluates to false
    //      condition5 evaluates to true
}
else
{
        Console.WriteLine("E");
        Console.WriteLine("Wrong Letter Grade!");
    // code block to be executed when 
    //      condition1 evaluates to false
    //      condition2 evaluates to false
    //      condition3 evaluates to false
    //      condition4 evaluates to false
    //      condition5 evaluates to false
}
   }
}




﻿namespace Homework2part2;

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
