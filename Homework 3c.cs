﻿using System;
class HelloWorld
{
    static void Main()
    {
       int x, y, z, n;
       //get value of n from the user
       Console.WriteLine ("Assign an int value to N: ");
       n=Convert.ToInt32(Console.ReadLine());
       //the first for loop starts with x=1 and ends at x<=n
       for (x=1; x<=n; x++)
       {
        //second for loop starts with y=0 and ends at y=n-x-1
        for (y=0; y<n-x; y++)
        {
            //print empty spaces
            Console.Write("");
        }
        for (z=1; z<=x; z++)
        {
            //print the value of x
            Console.Write("*");
        }
        //print new line
        Console.WriteLine();
       }
    }
}