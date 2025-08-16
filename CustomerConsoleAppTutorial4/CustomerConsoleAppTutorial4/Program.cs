using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsoleAppTutorial4
{
    class Customer
    {
        // Properties of the Customer class
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int Age { get; set; }

        // Constructor to initialize the properties
        public Customer(int id, string name, string email, int age)
        {
            Id = id;
            Name = name;
            Email = email;
            Age = age;
        }
    }

    class Program
    {
        static void Main()
        {
            // Create two Customer objects with different values
            Customer Cust1 = new Customer(1, "John Doe", "john.doe@example.com", 12);
            Customer Cust2 = new Customer(2, "Jane Smith", "jane.smith@example.com", 8);
            Customer Cust3 = new Customer(3, "Alex Kim", "alex.kim@example.com", 9);



            if (Cust1.Age < 10) Print(Cust1);
            if (Cust2.Age < 10) Print(Cust2);
            if (Cust3.Age < 10) Print(Cust3);
        }
        //Print is a static method that takes one parameter c of type Customer
        static void Print(Customer c)
        {
            Console.WriteLine("ID: " + c.Id);
            Console.WriteLine("Name: " + c.Name);
            Console.WriteLine("Email: " + c.Email);
            Console.WriteLine("Age: " + c.Age);
            Console.WriteLine();

        }
    }
}

