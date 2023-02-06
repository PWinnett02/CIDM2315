using System;
class Pattern
{
    static void Main()
    {
        Console.WriteLine("Assign an int value to N: ");
        int n = int.Parse(Console.ReadLine());

        for(int i=0; i<n; i++);
        {
            for(int j=0; j<n; j++);
            {
                Console.WriteLine("#");
            }
            Console.WriteLine();
        }
    }
}