using System;
class HelloWorld
{
    static void pattern(int N,string shape)
    {
        //pattern method having parameters N and shape
        int i,j,k;
        //declaring variables to use 
        if(shape=="left")
        {
            {
                //if shape is left
                for(i=1;i<=N;i++)
                {
                    for(j=1;j<=N;j++)
                    Console.WriteLine("*");
                    //printing star
                    Console.WriteLine("\n");
                    //printing new line
                }
            }
        else if(shape== "right")
        {
            //shape is right
            for(i=1;i<=N;i++)
            {
                for(j=1;j<=N;j++)
                {
                    Console.WriteLine(" ");
                }
                //printing space
                for(k=1;k<=N;k++)
                {
                    Console.WriteLine("*");
                }
                //printing star
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
    static void Main()
    {
        //main method
        int N;
        //declaring variable
        string shape;
        //declaring the shape
        Console.WriteLine("Input N: ");
        N= Convert.ToInt32(Console.ReadLine());
        //input the number of rows
        Console.WriteLine("Input shape: ");
        shape= Console.ReadLine();
        //input of the shape
        Console.WriteLine("N is: "+N+"; shape is "+shape+"\n");
        //displaying N and shape pattern(N,shape);
        //calling method
    }
}
}

