using System;

namespace NewLanguageFeatures
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }


    }


    public class Customer
    {
        public int CustomerID { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Customer(int ID)
        {
            CustomerID = ID;
        }

        public override string ToString()
        {
            return Name + "\t" + City + "\t" + CustomerID;
        }

        class Program
        {
            List<Point> Square = new List<Point>
            {
                new Point { X=0, Y=5 },
                new Point { X=5, Y=5 },
                new Point { X=5, Y=0 },
                new Point { X=0, Y=0 }
            };


            static List<Customer> CreateCustomers()
            {
                return new List<Customer>
                {
                    new Customer(1) { Name = "Maria Anders",     City = "Berlin"    },
                    new Customer(2) { Name = "Laurence Lebihan", City = "Marseille" },
                    new Customer(3) { Name = "Elizabeth Brown",  City = "London"    },
                    new Customer(4) { Name = "Ann Devon",        City = "London"    },
                    new Customer(5) { Name = "Paolo Accorti",    City = "Torino"    },
                    new Customer(6) { Name = "Fran Wilson",      City = "Portland"  },
                    new Customer(7) { Name = "Simon Crowther",   City = "London"    },
                    new Customer(8) { Name = "Liz Nixon",        City = "Portland"  }
                };

                static void VarTest()
                {
                    var x = new [] { 1, 2, 3 }; // Error: array initalization expression not permitted

                }


                static void Main(string[] args)
                {
                    var customers = CreateCustomers();

                    Console.WriteLine("Customers:\n");
                    foreach (var c in customers)
                        Console.WriteLine(c);
                }

            }




        }

        //public class Point
        //{
        //    private int x;
        //    private int y;

        //    public int X { get { return x; } set { x = value; } }
        //    public int Y { get { return y; } set { y = value; } }
        //}

        



    }


}
