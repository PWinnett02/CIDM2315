using System;
class Customer
{
    //variable to store the customer id 
    private int cus_id;
    //variable to store the customer name
    public string cus_name;
    //variable to store the customer age
    public int cus_age;
    //constructor used to assign id, name and age to the custom when an object is created. 
    public Customer(int id, string name, int age)
    {
        //setting the customer id
        cus_id = id;
        //setting the customer name
        cus_name = name;
        //setting the customer age
        cus_age = age;
    }
    //method used to change customer id 
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }
    //method used to print customer information(id, name, age)
    public void PrintCusInfo()
    {
        //Printing the values of corresponding customer
        Console.WriteLine("Customer: " + cus_id + ",name: " + cus_name + ",age: " + cus_age);

    }
}
//main class to run the program
class HelloWorld
{
    //main method
    static void Main()
    {
        //Intializing the object of customer1 values
        Customer cust1 = new Customer(110, "Alice", 28);
        //Printing the values of customer1
        cust1.PrintCusInfo();
        //Intializing the object of customer 2 values
        Customer cus2 = new Customer(111, "Bob" ,30);
        //Printing the values of customer2
        cus2.PrintCusInfo();
        //setting the new id for customer 1
        cust1.ChangeID(220);
        //setting the new id for customer 2
        cust2.ChangeID(221);
        //Printing the values of the customers with changed ids
        cust1.PrintCusInfo();
        cust2.PrintCusInfo();
        Console.WriteLine(Cust2 + "is older.")
    }
    
}