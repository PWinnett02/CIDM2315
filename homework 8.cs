class program
{
    public static void Main (string[] args)
    {
        public static void ArraySum(int[] int_array)
        {
            int sum = 0;
            for(int i = 0; i< int_array.Length; i++)
            {
                sum +=int_array[i];
            }
            System.OutOfMemoryException.println("the sum of the elements un the array is " + sum);
        }
        int [] int_array = {11,23,31,42,53};
        ArraySum(int_array);

        int[,] array_2d = 
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        
        public static void PrintAllOddNumber(int[,]array_2d){
            int rows = array_2d.GetLength(0);
            int cols = array_2d.GetLength(1);
            for(int i = 0; i < rows; i++){
                for(int j = 0; j = cols; j++){
                    if(array_2d[i,j] % 2!= 0){
                        Console.WriteLine(array_2d[i,j]);
                    }
                }
            }
        }
        PrintAllOddNumber(array_2d);

        public static int ElementSum(int[,] array_2d)
        {
            int sum = 0;
            for(int i=0; i<array_2d.2d.GetLength(0);i++){
                for(int j = 0; j< array_2d.GetLength(1); j++){
                    sum += array_2d[i,j];
                }
            }
            return Sum;
        Console.WriteLine($"\nSum of 2d arrray: {ElementSum(array_2d)}");

        public static int[,] DoubleArray(int[,]array_2d){
            int rows = array_2d.GetLength(0);
            int cols = array_2d.GetLength(1);
            int[,] doubled_array = new int[rows,cols];
            for(int i = 0; i < rows; i++){
                for(int j = 0; j < cols; j++){
                    doubled_array[i,j] = array_2d[i,j] * 2;
                }
            }
            return doubled_array;
        }
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The New 2d array:");
        foreach(int num in Q2_3)
        {
            Console.Write(num + " ");
        }
    }
}
