using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Please input a letter grade:");
        //get grade from user
        char grade=Console.ReadLine()[0];
        //switch block
        switch (grade)
        {
            //Check if grade is A
            //if A then print 4
            case 'A': Console.WriteLine("GPA Point: 4");
            break;
            //check if grade is B
            //if B then print 3
            case 'B': Console.WriteLine("GPA Point: 3");
            break;
            //check if grade is C
            //if C then print 2
            case 'C': Console.WriteLine("GPA Point: 2");
            break;
            //check if grade is D
            //if D then print 1
            case 'D': Console.WriteLine("GPA Point: 1");
            break;
            //check if grade is F
            //if F then print 0
            case 'F': Console.WriteLine("GPA Point: 0");
            break;
            //if any other letter then A,B,C,D,F
            default: Console.WriteLine("Wrong Letter Grade!")
            break;
        }
    }
}

        