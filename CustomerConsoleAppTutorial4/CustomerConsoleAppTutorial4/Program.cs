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


            // Print the details of the first customer using Console.WriteLine
            Console.WriteLine("Customer 1 Information:");
            Console.WriteLine("ID: " + Cust1.Id);
            Console.WriteLine("Name: " + Cust1.Name);
            Console.WriteLine("Email: " + Cust1.Email);
            Console.WriteLine("Age: " + Cust1.Age);
            Console.WriteLine(); // Blank line for separation

            // Print the details of the second customer using Console.WriteLine
            Console.WriteLine("Customer 2 Information:");
            Console.WriteLine("ID: " + Cust2.Id);
            Console.WriteLine("Name: " + Cust2.Name);
            Console.WriteLine("Email: " + Cust2.Email);
            Console.WriteLine("Age: " + Cust2.Age);
            Console.WriteLine(); // Blank line for separation

            // Print the details of the second customer using Console.WriteLine
            Console.WriteLine("Customer 3 Information:");
            Console.WriteLine("ID: " + Cust3.Id);
            Console.WriteLine("Name: " + Cust3.Name);
            Console.WriteLine("Email: " + Cust3.Email);
            Console.WriteLine("Age: " + Cust3.Age);
        }
    }
}

