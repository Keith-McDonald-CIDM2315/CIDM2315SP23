namespace Homework3part3;
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