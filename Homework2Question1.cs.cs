namespace Homework2Question1;
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
