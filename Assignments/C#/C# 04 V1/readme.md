



C#.NET Exercise 


Contents
LAB 1: C# 3.0 LANGUAGE ENHANCEMENTS	1
Lab Objective	1
Exercise I – Use of Automatically Implemented Properties	2
Task 1 – Creating the "NewLanguageFeatures" Project	2
Task 2 – Creating a new class utilizing Automatically Implemented Properties	2
Task 3 – Use of Accessibility Modifiers with Properties	4
Exercise 2 – Easy Initialization with Object and Collection Initializers	6
Task 1 – Using Object Initializers	6
Task 2 – Using Collection Initializers	7
Exercise 3 – Implicitly Typed Local Variables and Implicitly Typed Arrays	8
Task 1 – Declaring Simple Implicitly Typed Local Variables and Arrays	8
Task 2 – Create an Implicitly Typed Array (and understand the restrictions of Implicit Typing)	9
Task 3 – Using var to create more concise code	11
Exercise 4 – Extending Types with Extension Methods	12
Task 1 – Declaring Extension Methods	12
Task 2 – Using Extension Methods with Generic Types	14
Exercise 5 – Working with Lambda Expressions	15
Task 1 – Understanding Lambda Expressions	15
Task 2 – Calling a Complex Extension Method using Lambda Expressions [optional]	16
Exercise 6 – Using Lambda Expressions to Create Expression Trees	18
Task 1 – Creating an Expression Tree using a Lambda Expression	18
Task 2 – Relationship between functions and expressions	19
Exercise 7 – Understanding Queries and Query Expressions	19
Task 1 – Creating a new class to Query	20
Task 2 –Querying with in-Memory Collections	21
Task 3 – Additional Query Expressions	22
Exercise 8 – Anonymous Types and Advanced Query Creation	22
Task 1 – Creating Anonymous Types	22
Task 2 – Additional Query Expressions Using Anonymous Types	25
Task 3 – Overview of LINQ To SQL, LINQ To XML, and LINQ to DataSet	26
Appendix: Code Samples (used if not running sequentially through the lab)	28
Exercise 1: The first task in this exercise explains how to open Visual Studio and create a new project.	28
Exercise 2:	28
Exercise 3:	29
Exercise 4:	30
Exercise 5:	31
Exercise 6:	33
Exercise 7:	35
Exercise 8:	37

 
Lab 1: C# 3.0 Language Enhancements
The C# 3.0 language enhancements build on C# 2.0 to increase developer productivity: they make written code more concise and make working with data as easy as working with objects.  These features provide the foundation for the LINQ project, a general purpose declarative query facility that can be applied to in-memory collections and data stored in external sources such as XML files and relational databases.

The C# 3.0 language enhancements consist of:
•	Auto-implemented properties, which automate the process of creating properties with trivial implementations.  
•	Implicitly typed local variables, which permit the type of local variables to be inferred from the expressions used to initialize them.
•	Implicitly typed arrays, a form of array creation and initialization that infers the element type of the array from an array initializer.  
•	Extension methods, which make it possible to extend existing types and constructed types with additional methods.
•	Lambda expressions, an evolution of anonymous methods that concisely improves type inference and conversions to both delegate types and expression trees.
•	Expression trees, which permit lambda expressions to be represented as data (expression trees) instead of as code (delegates). 
•	Object and collection initializers, which you can use to conveniently specify values for one or more fields or properties for a newly created object, combining creation and initialization into a single step.
•	Query expressions, which provide a language-integrated syntax for queries that is similar to relational and hierarchical query languages such as SQL and XQuery.
•	Anonymous types, which are tuple types automatically inferred and created from object initializers.
Lab Objective
Estimated time to complete this lab: 60 minutes
The objective of this lab is to provide a clear understanding of the new language features in C# 3.0 and how the features work together to increase productivity and provide a rich, expressive way to work with data.  
The lab is structured into eight exercises, each containing a varying number of tasks.  Each exercise presents a new feature that utilizes features presented in preceding exercises.  To start an exercise without completing the prior exercises, see the corresponding code sample in the appendix, which provides the prerequisites.
This lab consists of the following exercises: 
•	Use of Automatically Implemented Properties
•	Easy Initialization with Object and Collection Initializers
•	Implicitly Typed Local Variables and Implicitly Typed Arrays 
•	Extending Types with Extension Methods
•	Working with Lambda Expressions
•	Using Lambda Expressions to Create Expression Trees
•	Understanding Queries and Query Expressions
•	Anonymous Types and Advanced Query Creation

Exercise I – Use of Automatically Implemented Properties
Oftentimes property accessors (get and set) have trivial implementations and follow the pattern that simply get (return) a private field and set the private field to the value passed.  Automatically Implemented Properties provide a more concise syntax for implementing this pattern, where the C# compiler  automatically generates the backing fields.  
This exercise will show you how to create properties without creating additional unused fields.  

Task 1 – Creating the "NewLanguageFeatures" Project
1.	Click the Start | Programs | Microsoft Visual Studio 2008 | Microsoft Visual Studio 2008  menu command.
2.	On the File menu, point to New, and click Project.
3.	In the New Project dialog box select the Visual C# Windows project type.
4.	Select the Console Application template.
5.	Provide a name for the new project by entering “NewLanguageFeatures” in the Name box.
6.	Click OK.

Task 2 – Creating a new class utilizing Automatically Implemented Properties
In the following example, the Point class contains two properties:
    public class Point
    {
        private int x;
        private int y;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
    }

To simplify this let the compiler generate the field and we can simply specify the property name as shown below:

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

1.	In the Solution Explorer, double-click Program.cs to open the source code in the Visual C# code editor.
2.	Add a Customer class to the NewLanguageFeatures namespace: 

namespace NewLanguageFeatures
{
    public class Customer
    {
    }
    
          class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

3.	In the Customer class, add two properties (Name and City) and override the ToString method to easily view the object.

public class Customer 
{
    public string Name { get; set; }
    public string City { get; set; }

    public override string ToString()
    {
        return Name + "\t" + City;
    }
}

4.	In the Main method, create a new instance of the Customer class.  

    static void Main(string[] args)
    {
        Customer c = new Customer();
        c.Name = "Maria Anders";
        c.City = "Berlin";

        Console.WriteLine(c);
    }
5.	Press Ctrl+F5 to build and run the application, displaying the output in a console window:
  
6.	Press any key to close the console window and terminate the program.
Creation of properties by this method require the properties to have both get and set accessors.  However, accessors can still have modifiers applied to them as shown in the next Task.   
Task 3 – Use of Accessibility Modifiers with Properties 
Imagine you want to store a property within the Customer class that could externally (outside the class)be read-only or write-only.   Auto-Implemented Properties allow the use of modifiers to specify accessibility.  
1.	Return to the Customer class.  Suppose you want to add a read-only Customer ID; to do this, add a new property CustomerID.  Add the private modifier to the set accessor.  Update the ToString() method as well to include this new property.  
public class Customer 
{
    public int CustomerID { get; private set; }
    public string Name { get; set; }
    public string City { get; set; }

    public override string ToString()
    {
        return Name + "\t" + City + "\t" + CustomerID;
    }
}


2.	In the Main method, set the CustomerID. 

 static void Main(string[] args)
    {
    Customer c = new Customer();
    c.Name = "Maria Anders";
    c.City = "Berlin";
    c.CustomerID = 1;

    Console.WriteLine(c);
 }

3.	Press Ctrl+Shift+B to build the solution.
4.	Click the Error List tab to view the compiler error output.
 
Notice that an error occurs when you attempt to set the CustomerID property directly.  This is due to the private modifier on set.  The CustomerID property now behaves as if it were read-only.

5.	Return to the Customer class and add a constructor to set the CustomerID.  

public class Customer 
{
    public string CustomerID { get; private set; }
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
}


6.	In the Main method, update the constructor call to set the CustomerID.  
   
    static void Main(string[] args)
    {
    Customer c = new Customer(1);
    c.Name = "Maria Anders";
    c.City = "Berlin";

    Console.WriteLine(c);
 }

7.	Press Ctrl+F5 to build and run the application.  The program now compiles without any errors.  Press any key to terminate the application.
Exercise 2 – Easy Initialization with Object and Collection Initializers
In C# 3.0, when declaring an object or collection, you may include an initializer that specifies the initial values of the members of the newly created object or collection. This new syntax combines object creation and initialization into a single step.
Task 1 – Using Object Initializers
An object initializer consists of a sequence of member initializers, contained in { } braces and separated by commas. Each member initializer assigns a value to a field or property of the object. For example, recall the Point class from Exercise 1:
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

An object of type Point can be initialized using an object initializer like this:
Point p = new Point { X = 3, Y = 99 };

This concise initialization syntax is semantically equivalent to invoking the instance constructor and then performing assignments for each of the properties. 

1.	Replace the code in Main with the following:
       static void Main(string[] args)
       {
    Customer c = new Customer(1) { Name = "Maria Anders", City = "Berlin" };
    Console.WriteLine(c);
       }

2.	Press Ctrl+F5 to build and run the application.  The customer is printed to the console window.   Now press any key to terminate the application.

For this object, the object initializer invokes the object’s constructor, and then initializes the named fields to the specified values. Not all fields of the object need to be specified in the list. If not specified, the fields will have their default value.  Also note if invoking the object’s parameterless constructor, the parentheses are optional.  For example you could have written Customer c = new Customer() {…} as Customer c = new Customer {…}.

Task 2 – Using Collection Initializers
With C# 3.0, any object that implements System.Collections.Generic.IEnumerable<T> and has a public Add method can have its values initialized with a collection initializer.
Using the Point class, let’s create a shape that is made up of a collection of points.
List<Point> Square = new List<Point> 
{ 
    new Point { X=0, Y=5 }, 
    new Point { X=5, Y=5 },
    new Point { X=5, Y=0 },
    new Point { X=0, Y=0 }
};

1.	For the remainder of the lab a collection of Customers will be needed.  Create a list of Customers in a new method CreateCustomers.  

static void Main(string[] args)
{
    Customer c = new Customer(1) { Name = "Maria Anders", City = "Berlin" };
    Console.WriteLine(c);
}

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
        new Customer(8) { Name = "Liz Nixon", 	     City = "Portland"  }
    };
}     	


2.	In Main,  replace the code with the following:
static void Main(string[] args)
{
    List<Customer> customers = CreateCustomers();
    
    Console.WriteLine("Customers:\n");
    foreach (Customer c in customers)
        Console.WriteLine(c);
       }

3.	Press Ctrl+F5 to build and run the application and print the list of customers.  Press any key to terminate the application.  
When calling CreateCustomers, the list is initialized empty and each object is created separately.  Each object is then added to the list using the Add method.      
Exercise 3 – Implicitly Typed Local Variables and Implicitly Typed Arrays
The implicit typing of local variables is a general language feature that relieves the programmer from having to specify the type of the variable. Instead, the type is inferred by the compiler from the type of the variable’s initialization expression.  With C# 3.0, arrays can be initialized implicitly and variables can be declared implicitly within a local scope. With implicitly typed arrays, this is achieved by initializing arrays using new[]{…} (notice the lack of type here). With implicitly typed local variables, this is done when declaring a local variable as type var (assuming no type named var is in scope).
In this exercise, you will learn to implement implicitly typed arrays as well as define implicitly typed local variables – both simple declarations and more complicated declarations (where the value of this language feature becomes apparent). 

Task 1 – Declaring Simple Implicitly Typed Local Variables and Arrays
This task starts with simple examples to enable understanding of var.

1.	Add a new method above Main called VarTest that creates a few simple objects and one slightly more complex:
static void VarTest()
{
    int i = 43;

    string s = "...This is only a test...";

    int[] numbers = new int[] { 4, 9, 16};  

    SortedDictionary<string, List<DateTime>> complex = 
        new SortedDictionary<string, List<DateTime>>();
}

static void Main(string[] args)
…

2.	Press Ctrl+Shift+B to build the solution to ensure everything compiles (the two warnings that appear are expected).   
3.	Now make the identified changes in VarTest (changing the types to var as well as removing the type, int, from the initialization of the array):
static void VarTest()
{
      var i = 43;

      var s = "...This is only a test...";

      var numbers = new [] { 4, 9, 16 };

var complex = new SortedDictionary<string, List<DateTime>>();
}

4.	Press Ctrl+Shift+B to build the solution to ensure everything compiles.   
5.	Now move the mouse over each var and notice that the type has been inferred for each.  Two examples are shown below.    
          	                   
View the quick info for the array of numbers (move the mouse over var next to numbers) to notice the type of the list created was inferred by the type of data provided in the list.  

Task 2 – Create an Implicitly Typed Array (and understand the restrictions of Implicit Typing) 
There are some restrictions on the use of implicitly typed local variables.  In particular, because the type of the variable is inferred from its initialization, an implicitly typed declaration must include an initialization.  This task works through the errors that could arise when trying to build an array of integers.  

1.	In the VarTest method, replace the body with the following code:
static void VarTest()
{
   var x;	// Error: what type is it?
   x = new int[] { 1, 2, 3 };
}

static void Main(string[] args)
…

2.	Press Ctrl+Shift+B to build the solution
3.	Click the Error List tab to view the compiler error output.
 
Because the type of the variable is inferred from its initializer, an implicitly typed declaration must include an initializer.

4.	Replace the variable declaration in the VarTest method with the following code:
static void VarTest()
{
    var x = {1, 2, 3}; // Error: array initalization expression not permitted
}

5.	Press Ctrl+Shift+B to build the solution and view the resulting compiler errors.
 
An implicit array initialization expression must specify that an array is being created and include new[].  Also important to note when using implicitly typed local variables, the initializer cannot be an object or collection initializer by itself.  It can be a new expression that includes an object or collection initializer.

6.	Fix the errors by replacing the line with:
static void VarTest()
{
  var x = new[] {1, 2, 3};
}

7.	Press Ctrl+Shift+B to build the solution.  This time the solution builds.  
Now the code compiles and the type has been inferred.  Move the mouse over var and the Quick Info shows the inferred type: Int32[].
8.	Delete the VarTest method to reduce clutter.

Implicitly typed variables shouldn’t be confused with scripting languages where a variable can hold values of different types over its lifetime in a program (the equivalent of that in C# is object). Instead, this feature affects only the declaration of variables at compile time; the compiler infers the type of the variable from the type of expression used to initialize it. From then on throughout the program, it is as if the variable was declared with that type; assigning a value of a different type into that variable will result in a compile time error.

Task 3 – Using var to create more concise code
Implicitly typed variables become very useful as the type of the initialization expression becomes more complicated; in particular, when instantiating a complex generic type. In this task, you will return to the Main method and show how var is used to create more concise code:
1.	In Main, replace the type of customers with var:
static void Main(string[] args)
{
    var customers = CreateCustomers();

    Console.WriteLine("Customers:\n");
    foreach (Customer c in customers)
        Console.WriteLine(c);
}

2.	Press Ctrl+F5 to run the application and print the customers.  After viewing the results, press any key to terminate the application.  
3.	Now replace the type in the foreach statement with var.
static void Main(string[] args)
{
    var customers = CreateCustomers();

    Console.WriteLine("Customers:\n");
    foreach (var c in customers)
        Console.WriteLine(c);
}

4.	Press Ctrl+F5 to run the application and see the same output.  Then press any key to terminate the application.

In this task the var keyword was used to infer the type of the foreach local variable is Customer in the foreach loop.  This is generally applicable for use in foreach.   var was also used to replace the types of the objects returned from the method call.  The current function of Main is to retrieve data from a method and print the data.  In this respect the type of information that is returned does not matter.  Notice no type is specified in Main.  Especially for longer and more complex types, using implicitly typed local variable declarations simplify the variable declarations, reducing the amount of code required and the associated coding errors.  This is also true when the type is unnamed or unspecified as shown in Exercises 7 (Queries) and 8 (Anonymous Types).

Exercise 4 – Extending Types with Extension Methods
Extension methods provide a way for developers to extend the functionality of existing types by defining new methods that are invoked using the normal instance method syntax. Extension methods are static methods that are declared by specifying the keyword this as a modifier on the first parameter of the methods. In this exercise, imagine the Order class was precompiled and a library was provided.  New features can still be built on top of the Order class.  To do this a new class is created to hold these extension methods.  In addition, you will extend the List<T> generic class, adding an extension method to append the list to another.

Task 1 – Declaring Extension Methods
This task begins by extending a class using C# 2.0 and then utilizes the C# 3.0 Extension Methods feature.   

1.	Add a new static class, Extensions, to the NewLanguageFeatures namespace:

 namespace NewLanguageFeatures
 {
    public static class Extensions
    { 
    }

          public class Customer
      …

2.	In this new class add a method, Compare that given two customers checks to see if all the properties of each are the same, and if so returns true.
   public static class Extensions
   {
    public static bool Compare(Customer customer1, Customer customer2)
    {
        if (customer1.CustomerID == customer2.CustomerID &&
            customer1.Name == customer2.Name &&
            customer1.City == customer2.City )
        {
            return true;
        }

        return false;
    }
}

3.	Rewrite Main to compare a new Customer with all the others in the list to see if it is present already:

static void Main(string[] args)
{
    var customers = CreateCustomers();

    var newCustomer = new Customer(10)
    {
        Name = "Diego Roel",
        City = "Madrid"
    };
    
    foreach (var c in customers)
    {
        if (Extensions.Compare(newCustomer, c))
        {
            Console.WriteLine("The new customer was already in the list");
            return;
        }
    }
    
    Console.WriteLine("The new customer was not in the list");
}

The previous code demonstrates how you might extend a type with new functionality in C# 2.0.

4.	Press Ctrl+F5 to build and run the application, which displays “The new  customer was not in the list”.  Press any key to terminate the application.
With C# 3.0, you can now define an extension method that can be invoked using instance method syntax. An extension method is declared by specifying the keyword this as a modifier on the first parameter of the method.
5.	Add the modifier this to the first parameter accepted by Compare:
public static class Extensions
{
    public static bool Compare(this Customer customer1, Customer customer2)
    {
        …

6.	In the Main method, change the invocation of Compare to use the instance method syntax, making Compare appear as a method of the Order class:
foreach (var c in customers)
{

    if (newCustomer.Compare(c))
    {
        Console.WriteLine("The new customer was already in the list");
        return;
    }
…

7.	Press Ctrl+F5 to build and run the application again and verify that it displays the same output, then press any key to close the console window and terminate the application.
Extension methods are only available if declared in a static class and are scoped by the associated namespace.  They then appear as additional methods on the types that are given by their first parameter.

Task 2 – Using Extension Methods with Generic Types
Extension methods can be added to any type, including the generic types such as List<T> and Dictionary<K, V>. 
1.	Add an extension method, Append, to the Extensions class that combines all elements of two List<T> objects into a single List<T>:
public static class Extensions
{
    public static List<T> Append<T>(this List<T> a, List<T> b)
    {
        var newList = new List<T>(a);
  newList.AddRange(b);
  return newList;
    }	
    public static bool Compare(this Customer customer1, Customer customer2)
    {
    		  …

2.	return to the Main method and use the Append method to append the addedCustomers list to the customers list.  Check this new list to see if the newCustomer is in the updated list:
static void Main(string[] args)
{
    var customers = CreateCustomers();

    var addedCustomers = new List<Customer>
    {
        new Customer(9)  { Name = "Paolo Accorti", City = "Torino" },
        new Customer(10) { Name = "Diego Roel", City = "Madrid" }
    };

    var updatedCustomers = customers.Append(addedCustomers);


    var newCustomer = new Customer(10)
    {        
        Name = "Diego Roel",
        City = "Madrid"
    };
   foreach (var c in updatedCustomers)
   {
      …

3.	Press Ctrl+F5 to build and run the application, which now displays “The new customer was already in the list”.  Press any key to terminate the application.  

Extension methods provide an elegant way to extend types with functionality you develop, making the extensions appear to be part of the original types.  Extension methods enable  new functionality to be added to an already compiled class.  This includes user created classes as well as .NET classes such as List<T>.  
Exercise 5 – Working with Lambda Expressions
C# 2.0 introduced anonymous methods, which allow code blocks to be written “inline” where delegate values are expected. For example, in the following statement, the FindAll method requires a delegate parameter:
var innerPoints = points.FindAll(delegate(Point p) { return (p.X > 0 && p.Y > 0); });
. In this case, the delegate determines if both the x and y coordinates are positive (if the point is in the first quadrant of the Cartesian plane). 
C# 3.0 introduces lambda expressions, which provide a more concise, functional programming syntax for writing anonymous methods. In this exercise, you replace a method invocation which currently takes an anonymous method with a lambda expression.  
To show this, the example above can be written as:

var innerPoints = points.FindAll(p => p.X > 0 && p.Y > 0);
Task 1 – Understanding Lambda Expressions
A lambda expression is written as a parameter list, followed by the => token, and then an expression or statement. For example: 
        (int x) => { return x + 1; }    // parameter list, statement

The parameters of a lambda expression can be explicitly or implicitly typed. 
        (int x) => x + 1;               // explicit parameter list, expression

In an implicitly typed parameter list, the types of the parameters are inferred from the context in which the lambda expression is used. In addition, if a lambda expression has a single, implicitly typed parameter, the parentheses may be omitted from the parameter list:
        x => x + 1;                     // implicit parameter list, expression
        (x,y) => x * y;                 // implicit parameter list, expression

1.	Suppose you wanted to find all the customers in a given city.  To do this use the FindAll method from the List<T> class.  First update the Main method to call this new method and then write FindCustomersByCity which will first use C# 2.0’s anonymous method syntax, delegates.
static void Main(string[] args)
{
    var customers = CreateCustomers();
            
    foreach (var c in FindCustomersByCity(customers, "London"))
        Console.WriteLine(c);
}

public static List<Customer> FindCustomersByCity(
    List<Customer> customers,
    string city)
{
    return customers.FindAll(
        delegate(Customer c){
            return c.City == city;
    });
} 

2.	Press Ctrl+F5 to build and run the program to test that only customers located in London are displayed.  Press any key to terminate the application.  
3.	Now, replace the anonymous method with an equivalent lambda expression:

public static List<Customer> FindCustomersByCity(
    List<Customer> customers,
    string city)
{
    return customers.FindAll(c => c.City == city);
} 

4.	Press Ctrl+F5 to build and run the program to again see the same output.  Press any key to terminate the application.  

Lambda expressions simplify the code required.  Notice that in this example the parameter list consisted of ‘c’ which was implicitly typed and therefore did not require the type to be explicitly stated.  If you wanted to be more explicit, the line could also have been written: 
return customers.FindAll((Customer c) => c.City == city);
Task 2 – Calling a Complex Extension Method using Lambda Expressions [optional]
In this task you extend the Dictionary class by creating a generic extension method.  You then see how to use lambda expressions when calling this new method.  

1.	First, set up the filter method that will be used to query over our data.  Add a new delegate type to the NewLanguageFeatures namespace.  
namespace NewLanguageFeatures
{
    public delegate bool KeyValueFilter<K, V>(K key, V value);

2.	Define an extension method for the Dictionary<K, V> type in the Extensions class:
public static class Extensions
{
    public static List<K> FilterBy<K,V>(
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
…
    
This extension method takes in a dictionary and a delegate.  It then iterates over all of the key value pairs in the dictionary and invokes the filter delegate for each.  If the filter method returns true, then that value is added to a list and returned.  
3.	Replace the code in Main with the following code

static void Main(string[] args)
{
    var customers = CreateCustomers();
    var customerDictionary = new Dictionary<Customer, string>(); 

    foreach (var c in customers) 
        customerDictionary.Add(c, c.Name.Split(' ')[1]); 

    var matches = customerDictionary.FilterBy(
        (customer, lastName) => lastName.StartsWith("A"));
				        //The above line runs the query  
    Console.WriteLine("Number of Matches: {0}", matches.Count);
}

This code sets up a dictionary containing customers associate with their last name.  It then calls the new extension method passing a lambda expression that accepts two arguments.  The result is to find the number of customers in the dictionary that have a last name starting with the letter A.  

4.	Press Ctrl+F5 to build and run the program and see the number of matches; there should be two..  Then press any key to close the console window and terminate the application.  

Exercise 6 – Using Lambda Expressions to Create Expression Trees
In addition to treating expressions as delegates, LINQ provides the ability to treat expressions as data at runtime. LINQ defines a new type, Expression<T>, which represents an expression tree, an in-memory representation of a lambda expression. Expression trees allow developers to treat lambda expressions as data, allowing for inspection and modification of lambda expressions in code. This feature will be used to enable an ecosystem of third-party libraries that leverage the base query abstractions that are part of LINQ.  For example, a database access implementation might leverage this facility to translate expression trees into suitable query statements for a particular kind of database.
Task 1 – Creating an Expression Tree using a Lambda Expression
In this task, you declare an expression tree and print a representation of the expression body.

1.	Add the following using directive to gain access to the types in System.Expressions (at the top of the file):
using System.Linq.Expressions;

2.	Replace the code in the body of the Main method with the following code:
static void Main(string[] args)
{
     Expression<Func<int, bool>> filter = n => (n * 3) < 5;

     BinaryExpression lt = (BinaryExpression) filter.Body;
     BinaryExpression mult = (BinaryExpression) lt.Left;            
     ParameterExpression en = (ParameterExpression) mult.Left;            
     ConstantExpression three = (ConstantExpression) mult.Right;
     ConstantExpression five = (ConstantExpression) lt.Right;
                        
     Console.WriteLine("({0} ({1} {2} {3}) {4})", lt.NodeType, 
              mult.NodeType, en.Name, three.Value, five.Value); 
}

This code creates an expression tree representation from the lambda expression. It then initializes local variables for each node of the tree. Finally, it outputs a LISP-style representation of the expression, to demonstrate a translation of the lambda expression to the expression tree.
3.	Press Ctrl+F5 to run the code and see the following output in the console window:
 (LessThan (Multiply n 3) 5)

4.	Press any key to terminate the application.  
Task 2 – Relationship between functions and expressions 
In this task, you learn how to convert an expression tree into a delegate that can be executed.

1.	Replace the code in the body of the Main method with the following code:
static void Main(string[] args)
{
    Func<int, int> addOne = n => n + 1; 
    Console.WriteLine("Result: {0}", addOne(5));
}

2.	Press Ctrl+F5 to run the code and see the result printed to the screen.  Then press any key to terminate the application.
3.	Add these lines below those:
   static void Main(string[] args)
{
    Func<int, int> addOne = n => n + 1;
    Console.WriteLine("Result: {0}", addOne(5));
    
    Expression<Func<int, int>> addOneExpression = n => n + 1;

    var addOneFunc = addOneExpression.Compile();
    Console.WriteLine("Result: {0}", addOneFunc(5));
}
4.	Run the program again and notice the same result is printed twice.  
It is very easy to create and build expressions that can be compiled dynamically and create new Func objects that pass around code as objects.  
Exercise 7 – Understanding Queries and Query Expressions
Now that you’ve been introduced to the many new language features in C# 3.0, this exercise shows how they are used together to create an expressive syntax for working with data, raising the level of abstraction over previous data access methods. Previously, developers were actually using two languages when working with data: C# and SQL, embedded in strings. This approach has its drawbacks, however, such as no compiler checking of query statements embedded in quotes, no type checking of return values, and so on. 

For example, a typical database query might look like this:
SqlConnection c = new SqlConnection(/*…*/);
c.Open();
SqlCommand cmd = new SqlCommand(	// queries in quotes
  @"SELECT c.Name, c.Phone
  FROM Customers c
  WHERE c.City = @p0"
  );
cmd.Parameters["@po"] = "London"; 	// arguments loosely bound
DataReader dr = c.Execute(cmd);
while (dr.Read())
{
    string name = r.GetString(0);
    string phone = r.GetString(1);	   // results loosely typed
    DateTime date = r.GetDateTime(2);  // compiler can’t help catch mistakes
}
r.Close();

With C# 3.0, you now have language integrated query, gaining the benefits of strong type checking, and the simplicity of using a single language. 
Task 1 – Creating a new class to Query

1.	Create a new class that represents a store.  Each store will be named and will have a location (city).
public class Store 
{
    public string Name { get; set; }
    public string City { get; set; }

    public override string ToString()
    {
        return Name + "\t" + City;
    }
}

public class Customer 
{
    …
2.	Create a list of Stores in a new method CreateStores within the Program class.  

static List<Store> CreateStores()
{
  return new List<Store>
  {
    new Store { Name = "Jim’s Hardware", 	City = "Berlin" },
    new Store { Name = "John’s Books", 	City = "London" },
    new Store { Name = "Lisa’s Flowers", 	City = "Torino" },
    new Store { Name = "Dana’s Hardware",	City = "London" },
    new Store { Name = "Tim’s Pets", 	City = "Portland" },
    new Store { Name = "Scott’s Books", 	City = "London" },
    new Store { Name = "Paula’s Cafe", 	City = "Marseille" },
  };
}     
	
static List<Customer> CreateCustomers()
{
  …

Task 2 –Querying with in-Memory Collections
The new standard query operators are in the System.Linq namespace and are provided by the System.Core.dll assembly. 

1.	Create a method that will be used to query in this task and call it in the Main method:
static void Query()
{
}

static void Main(string[] args)
{
    Query();
}

2.	Recall in Exercise 5 you wrote a simple method that prints only the customers in London.  Now build a simple query to do the same with stores.  Replace the foreach line with:
static void Query()
{
    var stores = CreateStores();
    foreach (var store in stores.Where(s => s.City=="London"))
        Console.WriteLine(store);
}
3.	Press Ctrl+F5 to build and run the code to see all the stores located in London.  Press any key to terminate the application.

This example utilizes lambda expressions as well as a basic query to only select a specific set of data in the list to be run through the loop.
4.	Notice the previous query used the Where method.  LINQ provides an easier way of writing queries.  This next piece of code provides the basic query structure provided in C# 3.0.  Make the following changes in Query to see this new structure.  

static void Query()
{
    var stores = CreateStores();
    IEnumerable<Store> results = from s in stores
 					   where s.City == "London"
                  		   select s;

    foreach (var s in results)
        Console.WriteLine(s);
}

5.	Press Ctrl+F5 to build and run the code and verify the results still show the same stores located in London.  Now press any key to terminate the application.  

The type returned from the query is explicitly stated here to show you what the type is, however this is not needed and we could have simply used var.  The upcoming tasks will use the implicity typed local variable, var.

Task 3 – Additional Query Expressions
1.	Instead of printing all the stores in London, write a query that simply prints the number of stores in London.  The Count method accepts a delegate parameter; once again use a lambda expression. 
static void Query()
{
   var stores = CreateStores();
   var numLondon = stores.Count(s => s.City == "London");
   Console.WriteLine("There are {0} stores in London. ", numLondon);
}
The Count method counts the number of elements in the list that are true for the predicate. In this case, the predicate is the lambda expression that tests for customers in London.  
2.	Press Ctrl+F5 to build and run the code to see the total number of stores in London.  Press any key to terminate the application.
Exercise 8 – Anonymous Types and Advanced Query Creation 
To facilitate the creation of classes from data values, C# 3.0 provides the ability to easily declare an anonymous type and return an instance of that type. To create an anonymous type, the new operator is used with an anonymous object initializer. For example, when presented with the following declaration, the C# compiler automatically creates a new type that has two properties: one named Name of type string, and another named Age with type int: 
var person = new { Name = “John Doe”, Age = 33 };
Each member of the anonymous type is a property inferred from the object initializer. The name of the anonymous type is automatically generated by the compiler and cannot be referenced from the user code.

Task 1 – Creating Anonymous Types

1.	Modify the Query method to loop through customers and stores to find all the stores for each customer that are located in the same city.
static void Query()
{
    foreach (var c in CreateCustomers())
    {
        var customerStores = new            //Anonymous Type Creation:
        {                                   //Mouse over the var in this
            CustomerID = c.CustomerID,      //statement to see the type
            City = c.City,
            CustomerName = c.Name,
            Stores = from s in CreateStores()
                     where s.City == c.City
                     select s
        };

        Console.WriteLine("{0}\t{1}",
      customerStores.City, customerStores.CustomerName);

      foreach (var store in customerStores.Stores)
          Console.WriteLine("\t<{0}>", store.Name);
    }
}

Notice the type of customerStores does not have a name.  If you mouse over the var it says it is of type AnonymousType 'a .  The structure is also provided; the three properties of this new type are CustomerID, CustomerName, City, and Stores.

2.	Press Ctrl+F5 to build and run the application and print the customers and their associated orders.  Now terminate the application by pressing any key.

In the previous code, the names of the anonymous type members (CustomerName, City, Stores, and CustomerID) are explicitly specified. It is also possible to omit the names, in which case, the names of the generated members are the same as the members used to initialize them. This is called a projection initializer.  

3.	Change the foreach body to omit the property names of the anonymous class:

static void Query()
{
    foreach (var c in CreateCustomers())	
    {
        var customerStores = new            //Anonymous Type Creation:
        {                                   //Mouse over the var in this
            c.CustomerID,                   //statement to see the type
            c.City,
            CustomerName = c.Name,
            Stores = from s in CreateStores()
			   where s.City == c.City
			   select s 
        }; 
       
        Console.WriteLine("{0}\t{1}", 
            customerStores.City, customerStores.CustomerName);	

        foreach (var store in customerStores.Stores)
            Console.WriteLine("\t<{0}>", store.Name);
    }
}


4.	Press Ctrl+F5 to build run the application and notice the output is the same.  Then press any key to terminate the application.
 
Task 2 – Additional Query Expressions Using Anonymous Types
1.	Combine the many features presented before to simplify the previous query.  To simplify this query, you make use of a lambda expression and another query expression.
static void Query()
{
    var results = from c in CreateCustomers()
 			select new
			{
                c.CustomerID,
                c.City,
                CustomerName = c.Name,
                Stores = CreateStores().Where(s => s.City == c.City)
        		}; 

    foreach (var result in results)   
    {
        Console.WriteLine("{0}\t{1}", result.City, result.CustomerName);	
        foreach (var store in result.Stores)
            Console.WriteLine("\t<{0}>", store.Name);
    }
}

2.	Press Ctrl+F5 to build run the application and notice the output is the same as the previous task.  Then press any key to terminate the application.
3.	Now use another approach.  Rather than finding all stores per customer, the customers are joined with the stores using the Join expression.  This creates a record for each customer store pair.  
static void Query()
{
    var results = from c in CreateCustomers()
     			join s in CreateStores() on c.City equals s.City
                  select new 
 		{ 
 		    CustomerName = c.Name, 
		    StoreName = s.Name,
		    c.City, 
		};

    foreach (var r in results)
        Console.WriteLine("{0}\t{1}\t{2}",
            r.City, r.CustomerName, r.StoreName);
}
4.	Press Ctrl+F5 to build and run the program to see that a piece of data from each object is correctly merged and printed.  Press any key to terminate the application.  
5.	Next, instead of writing each pair to the screen, create a query that counts the number of stores located in the same city as each customer and writes to the screen the customer’s name along with the number of stores located in the same city as the customer.  This can be done by using a group by expression.

static void Query()
{
    var results = from c in CreateCustomers()
     			join s in CreateStores() on c.City equals s.City
           	     	group s by c.Name into g
                  select new { CustomerName = g.Key, Count = g.Count() };

    foreach (var r in results)
        Console.WriteLine("{0}\t{1}", r.CustomerName, r.Count);
}
The group clause creates an IGrouping<string, Store> where the string is the Customer Name.  Press Ctrl+F5 to build and run the code to see how many stores are located in the same city as each customer.  Now press any key to terminate the application.
6.	You can continue working with the previous query and order the customers by the number of stores returned in the previous queries.  This can be done using the Order By expression.  Also the let expression is introduced to store the result of the Count method call so that it does not have to be called twice.  
static void Query()
{
    var results = from c in CreateCustomers()
     			join s in CreateStores() on c.City equals s.City
           	     	group s by c.Name into g
			let count = g.Count()
			orderby count ascending
                  select new { CustomerName = g.Key, Count = count };

    foreach (var r in results)
        Console.WriteLine("{0}\t{1}", r.CustomerName, r.Count);
}

7.	Press Ctrl+F5 to build and run the code to see the sorted output.  Then press any key to terminate the application. 
Here the orderby expression has selected the g.Count() property and returns an IEnumerable<Store>.  The direction can either be set to descending or ascending.  The let expression allows a variable to be stored to be further used while in scope in the query.
Task 3 – Overview of LINQ To SQL, LINQ To XML, and LINQ to DataSet
As shown here LINQ provides a language integrated query framework for .NET.  The features shown in the previous tasks can be used to query against relational databases, datasets, and data stored in XML. 
This overview demonstrated LINQ To Objects (In-Memory Collections).  For a deeper understanding of using LINQ with databases, datasets, and XML, see the LINQ Project Overview Hands On Lab.  
