using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelloCSharp
{

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }

        public Customer(string firstName, string lastname) {
            FirstName = FirstName;
            LastName = lastname;
        }
        public void GrowOlder(int numYears = 0) {
            Age += numYears;
                
                }
    }

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        
    }

    public class Program
    {
        /// <summary>
        /// The entry point to my program
        /// </summary>
        /// <param name="args">the command line arguments</param>
        public static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            // Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));


            //DateTime cat;
            //if (DateTime.TryParse(Console.ReadLine(), out cat)) {
            //    Console.WriteLine(cat.ToString("D"));
            //}
            //else
            //{
            //    Console.WriteLine("That wasn't a date");
            //}



            //Console.Write("Email: ");
            //var email = Console.ReadLine();
            //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            //Match match = regex.Match(email);
            //if (!match.Success) {
            //    Console.WriteLine("Invalid Email!");
            //}


            //var randomNewsWithArray = new string[] {"Martians Attacks!", "Seahawks win Superbowl", "Texans sign Brock"};
            //var rand = new Random();
            //Console.WriteLine(randomNewsWithArray[rand.Next(randomNewsWithArray.Length)]);

            //for (int i = 0; i < 101; i++)
            //{
            //    if ( i % 7 == 0) {
            //        Console.WriteLine(i);
            //    };
            //}




            var Cust1 = new Customer
            {
                FirstName = "Sally",
                LastName = "Williams",
                Age = 23,
                BirthDate = new DateTime(2028, 07, 04)
            };
            var Cust2 = new Customer
            {
                FirstName = "Mike",
                LastName = "Harrison",
                Age = 10,
                BirthDate = new DateTime(2019, 08, 04)
            };
            Console.WriteLine(String.Format("{0} {1} Age: {2} Birth Date: {3}", Cust1.FirstName, Cust1.LastName, Cust1.Age, Cust1.BirthDate));
            Console.WriteLine(String.Format("{0} {1} Age: {2} Birth Date: {3}", Cust2.FirstName, Cust2.LastName, Cust2.Age, Cust2.BirthDate));
            Debug.Assert(Cust1.Age == 23, "Sally is 23.");
            Debug.Assert(Cust2.Age == 10, "Mike is 10.");

            Console.ReadLine();











            var Product1 = new Product
            {
                Name = "Toy Car",
                Price = 22.99m,
                UnitsInStock = 400,
            };
            var Product2 = new Product
            {
                Name = "Baby Bag",
                Price = 13.99m,
                UnitsInStock = 500,
            };
            Console.WriteLine(String.Format("Product Name: {0} Price: {1} Unit in Stock: {2}", Product1.Name, Product1.Price, Product1.UnitsInStock));
            Console.WriteLine(String.Format("Product Name: {0} Price: {1} Unit in Stock: {2}", Product2.Name, Product2.Price, Product2.UnitsInStock));
   

            Console.ReadLine();


        }
    }
}
