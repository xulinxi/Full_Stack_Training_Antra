using System;

namespace NewLanguageFeatures
{

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
            static void Main(string[] args)
            {
                Customer c = new Customer(1);
                c.Name = "Maria Anders";
                c.City = "Berlin";
                c.CustomerID = 1;

                Console.WriteLine(c);

            }
        }

        //public class Point
        //{
        //    private int x;
        //    private int y;

        //    public int X { get { return x; } set { x = value; } }
        //    public int Y { get { return y; } set { y = value; } }
        //}

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }



    }


}
