using System;
namespace passwordAccount
{
    class Program
    {
        public static void Main(string[] args)
        {
            //call createAccount() method
            createAccount();
            Console.ReadKey(true);
        }
        public static bool checkAge(int birthyear)
        {
            //calculate age
            int age=2022-birthyear;
            //if age is greater tha or equal to 18, then return true
            if(age>=18)
                return true;
            //otherwise return false
            else
                return false;
        }
        public static void createAccount()
        {
            //declare String variables username,password and retypedpassword
            String username,password,retypedpassword;
            //declaree integer variable birthyear
            int birthyear;
            //prompt user to enter username
            Console.WriteLine("Enter your username: ");
            //read username
            username=Console.ReadLine();
            //prompt user to enter password
            Console.WriteLine("enter your password: ");
            //read password
            password=Console.ReadLine();
            //prompt user to enter password again
            Console.WriteLine("Enter your password again: ");
            //read retyped password
            retypedpassword=Console.ReadLine();
            //prompt user to enter birth year
            Console.WriteLine("Enter your birthyear: ");
            //read birthyear
            birthyear=Convert.ToInt32(Console.ReadLine());
            //if checkAge() return true, then
            if(checkAge(birthyear))
            {
                //if password and retypedpassword are equal, then displays 
                //"Account is created sucessfully"
                if(password==retypedpassword)
                    Console.WriteLine("Account is created successfully");
                //otherwise display "wrong password"
                else 
                    Console.WriteLine("Wrong Password");
            }
            //otherwise display "Could not create an account"
            else
                Console.WriteLine("Could not create an account.");
        }
    }
}