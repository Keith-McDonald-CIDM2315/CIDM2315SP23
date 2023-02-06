namespace Homework3part1;
using System;
class HelloWorld {
  static void Main() 
  {
    bool flag = true;
    Console.WriteLine("Input an integer: ");//Prompt User to enter integer
    string? input = Console.ReadLine();
    int number = Convert.ToInt32(input);//Converting input of string to integer type
    for(int i=2;i<number/2;i++)//For loop for checking prime number
    {
        if(number%i==0)
        {
               flag = false;
               break;
        }
    }
    if(flag)//If flag is true then input is prime else number is non-prime
    {
        Console.WriteLine( input +" is Prime ");
    }
    else{
        Console.WriteLine(input+" is non-prime ");
    }
    
  }
}


﻿namespace Homework3part3;
using System;
public class Program {
	public static void Main() {
		// get N from user
		Console.WriteLine("Assign an int value to N:");
		int N=Convert.ToInt16(Console.ReadLine());
		// i will run from 0 to N-1, i represent row number
		for(int i=0;i<N;i++) {
			// j will run from 0 to N-1, j represent column number
			for(int j=0;j<N;j++) {
				// if row number is less than column number print space else print *
				if(i<j)
					Console.Write(" ");
				else
					Console.Write("*");

			}
			Console.Write("\n");
		}
	}
}
