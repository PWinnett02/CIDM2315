using System;
public class Largest2
{
    public static int largest(int n1, int n2)
    {
        if (n1>n2)
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
        return largest(largest(n1,n2), largest(n3,n4));
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first integer: ");
        int first = 
        Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second integer: ");
        int second =
        Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third integer: ");
        int third =
        Conver6t.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter fourth integer: ")
        int fourth=
        Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second, third, fourth));
    }
}

