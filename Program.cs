namespace homework4Question1;
using System;
class HelloWorld {

// function named largest that takes 2 Integers a and b
// and return largest one

static int largest(int a, int b){

if(a>b){

return a;

}

else if(b>a){

return b;

}

else{



return -1;

}

}

// main function

static void Main() {

int a = 3, b=5;

// call the largest function in main function

int lar = largest( a, b);

// and print it

Console.WriteLine("\nLargest Number is : "+lar);
}
}



namespace homework4Question2
using System;  
public class HelloWorld  
{  
    static void pattern(int N,string shape){
    //patern method having parameters N and shape
    int i,j,k; //declaring variables to use
    if(shape=="left"){
    //if shape is left
       for(i=1;i<=N;i++)
       {
    	for(j=1;j<=i;j++)
    	   Console.Write("*"); //printing star
    	Console.Write("\n"); //printing new line
       }
      }
    else if(shape=="right"){
    //if shape is right
     for (i = 1; i <= N; i++)  
         {  
            for (j = 1; j <= N-i; j++)  
            {Console.Write(" ");}  //printing space
            for (k = 1; k <= i; k++)  
            {  Console.Write("*");}  //printing star
            Console.WriteLine("");  }  
        Console.ReadLine();}
    }
    public static void Main() 
{//main method
   int N; //declaring variable
   string shape; // declaring the shape
   Console.Write("Input N: ");
   N= Convert.ToInt32(Console.ReadLine()); // input the number of rows
   Console.Write("Input shape: ");
   shape= Console.ReadLine(); // input of the shape
   Console.Write("N is: "+N+"; shape is "+shape+"\n"); //displaying N and shape
   pattern(N,shape); //calling method
}}
