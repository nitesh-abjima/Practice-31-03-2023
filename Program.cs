using System;

class Program
{
    public static void Main(string[] args)
    {
        int i = 0;
        int Total = 0;
        int Product = 0;
        SimpleMethod(ref i); 

        Console.WriteLine(i);

        Calculate(10, 20, out Total, out Product);
        Console.WriteLine("Sum = {0} && Product = {1}", Total,Product);
        
        Customer C1 = new Customer();
        C1.PrintFullName();

        Customer C2 = new Customer("Nitesh","Agarwal");
        C2.PrintFullName();

    }

    //Pass by value/pass by reference
    public static void SimpleMethod(ref int j)
    {
        j = 101;
    }

    // Pass OUT Parameter
    public static void Calculate(int FN, int SN, out int Sum, out int Product)
    {
        Sum =  FN + SN;
        Product = FN * SN;
    }
}

//Class constructor types
class Customer
{
    string firstName;   
    string lastName;

    public Customer(): this("No FirstName provided", "No LastName provided")
    {

    }
    public Customer(string FirstName, string LastName)
    {
        this.firstName = FirstName;
        this.lastName = LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full name = {0}", this.firstName + " " + this.lastName);
    }
}
