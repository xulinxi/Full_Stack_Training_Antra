using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NewLanguageFeatures
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

    }

    public static class Extensions
    {

        public static List<K> FilterBy<K, V>(
        this Dictionary<K, V> items,
        KeyValueFilter<K, V> filter)
            {
                var result = new List<K>();

                foreach (KeyValuePair<K, V> element in items)
                {
                    if (filter(element.Key, element.Value))
                        result.Add(element.Key);
                }
                return result;
            }


        public static List<T> Append<T>(this List<T> a, List<T> b)
        {
            var newList = new List<T>(a);
            newList.AddRange(b);
            return newList;
        }

        public static bool Compare(this Customer customer1, Customer customer2)
        {


            if (customer1.CustomerID == customer2.CustomerID &&
                customer1.Name == customer2.Name &&
                customer1.City == customer2.City)
            {
                return true;
            }

            return false;
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
                        var x = new[] { 1, 2, 3 }; // Error: array initalization expression not permitted

                    }

                    //static void Main(string[] args)
                    //{
                    //    var customers = CreateCustomers();

                    //    var addedCustomers = new List<Customer>
                    //    {
                    //        new Customer(9)  { Name = "Paolo Accorti", City = "Torino" },
                    //        new Customer(10) { Name = "Diego Roel", City = "Madrid" }
                    //    };

                    //    var updatedCustomers = customers.Append(addedCustomers);

                    //    var newCustomer = new Customer(10)
                    //    {
                    //        Name = "Diego Roel",
                    //        City = "Madrid"
                    //    };

                    static void Main(string[] args)
                    {
                        Func<int, int> addOne = n => n + 1;
                        Console.WriteLine("Result: {0}", addOne(5));


                        Expression<Func<int, int>> addOneExpression = n => n + 1;

                        var addOneFunc = addOneExpression.Compile();
                        Console.WriteLine("Result: {0}", addOneFunc(5));


                        //Expression<Func<int, bool>> filter = n => (n * 3) < 5;

                        //BinaryExpression lt = (BinaryExpression)filter.Body;
                        //BinaryExpression mult = (BinaryExpression)lt.Left;
                        //ParameterExpression en = (ParameterExpression)mult.Left;
                        //ConstantExpression three = (ConstantExpression)mult.Right;
                        //ConstantExpression five = (ConstantExpression)lt.Right;

                        //Console.WriteLine("({0} ({1} {2} {3}) {4})", lt.NodeType,
                        //         mult.NodeType, en.Name, three.Value, five.Value);

                        //var customers = CreateCustomers();
                        //var customerDictionary = new Dictionary<Customer, string>();

                        //foreach (var c in customers)
                        //    customerDictionary.Add(c, c.Name.Split(' ')[1]);

                        //var matches = customerDictionary.FilterBy(
                        //    (customer, lastName) => lastName.StartsWith("A"));
                        ////The above line runs the query  
                        //Console.WriteLine("Number of Matches: {0}", matches.Count);


                        //foreach (var c in FindCustomersByCity(customers, "London"))
                        //    Console.WriteLine(c);
                    }

                    public static List<Customer> FindCustomersByCity(
                        List<Customer> customers,
                        string city)
                    {
                        return customers.FindAll(c => c.City == city);
                        //return customers.FindAll(
                        //    delegate (Customer c) {
                        //        return c.City == city;
                        //    });
                    }


                    //foreach (var c in customers)
                    //{
                    //    if (Extensions.Compare(newCustomer, c))
                    //    {
                    //     Console.WriteLine("The new customer was already in the list");
                    //        return;
                    //    }
                    //}

                    //Console.WriteLine("The new customer was not in the list");

                    foreach (var c in updatedCustomers)
                        {

                            {

                                if (newCustomer.Compare(c))
                                {
                                    Console.WriteLine("The new customer was already in the list");
                                    return;
                                }

                            }


                        }


                    }

                }


            }
        }
    }


    

