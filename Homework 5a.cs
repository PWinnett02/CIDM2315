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
    public static int largest(int n1, int n2)
    {
    return largest(largest(n1,n2), largest(n3,n4));
    }
    public static void Main(string[] args)
    {
        
    }
}

