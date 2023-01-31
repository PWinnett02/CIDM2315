using System;
class HelloWorld
{
    static void Main()
    {
       //get three inputs from the user
       Console.WriteLine("Please input the first num:");
       int a=Convert.ToInt16(Console.ReadLine());
       Console.WriteLine("Please input the second num:");
       int b=Convert.ToInt16(Console.ReadLine());
       Console.WriteLine("Please input the third num:");
       int c=Convert.ToInt16(Console.ReadLine());
       //declare a variable smallest
       int smallest=0;
       //check if a is the smallest 
       if (a<b)
       {
        if (a<c) 
        {
            smallest=a;
        }
       }
       //check if b is the smallest
       if (b<a)
       {
        if (b<c)
        {
            smallest=b;
        }
       }
       //check if c is the smallest
       if (c<a)
       {
        if (c<b)
        {
            smallest=c;
        }
       }
        //print the smallest
        Console.WriteLine("The smallest Value is {0}",smallest);
    }
}

        