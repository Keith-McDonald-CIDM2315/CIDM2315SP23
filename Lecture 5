namespace Question 1;
using System;

public class Largest1
{
    public static int largest(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    
    public static void Main(string[] args)
    {
        Console.Write("Enter first integer: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second));
    }
}



namespace Question2;
using System;

public class Largest2
{
    public static int largest(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    
    public static int largest(int n1, int n2, int n3, int n4)
    {
        return largest(largest(n1, n2), largest(n3, n4));
    }
    
    public static void Main(string[] args)
    {
        Console.Write("Enter first integer: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third integer: ");
        int third = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter fourth integer: ");
        int fourth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second, third, fourth));
    }
}



namespace Question3
using System;
{
    class Program
    {
        public static void Main(string[] args)
        {
            //call createAccount() method
            createAccount();
            Console.ReadKey(true);
        }
        public static bool checkAge(int birth_year)
        {
            //calculate age
            int age=2022-birth_year;
            //if age is greater than or equal to 18,then return true
            if(age>=18)
                return true;
            //otherwise return false
            else
                return false;
        }
        public static void createAccount()
        {
            //declare String variables userName,password and retypedPassword
            String userName,password,retypedPassword;
            //declare integer variable birthYear
            int birthYear;
            //prompt user to enter user name
            Console.WriteLine("Enter Your Username:");
            //read userName
            userName=Console.ReadLine();
            //prompt user to enter password
            Console.WriteLine("Enter Your Password:");
            //read password
            password=Console.ReadLine();
            //prompt user to enter password again
            Console.WriteLine("Enter Your Password Again:");
            //read retypedPassword
            retypedPassword=Console.ReadLine();
            //prompt user to enter birth year
            Console.WriteLine("Enter Your Birthyear:");
            //read birthYear
            birthYear=Convert.ToInt32(Console.ReadLine());
            //if checkAge() return true,then
            if(checkAge(birthYear))
            {
                //if password and retypedPassword are equal,then displays
                //"Account is created successfully"
                if(password==retypedPassword)
                Console.WriteLine("Account is created successfully");
                //otherwise display "Wrong password"
                else
                Console.WriteLine("Wrong password");
            }
            //otherwise display "Could not create an account."
            else
                Console.WriteLine("Could not create an account.");
        }
    }
}
