using System;
class HelloWorld
{
   //function named largest that takes 2 integers a and b
   //and return largest one
   static int largest(int a, int b)
   {
    if(a>b)
    {
        return a;
    }
    else if(b>a)
    {
        return b;
    }
    else
    {
      return -1;  
    }
    }
    //main function
    static void Main()
    {
        int a=3,b=5;
        //call the largest function in main function
        int lar = largest(a,b);
        //and print it
        Console.WriteLine("\nLargest Number is:"+lar);
    }
   }
