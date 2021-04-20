C#.NET Exercise 2
 
 
 
 
 
 
 
 
 
 
 
 
 
 
Contents
Lab Objective	2
EXERCISE1: Creation of class to find perimeter and area of Rectangle	3
Task1: Creating a New Solution “Lab2”	3
Task2: Creating new project “Exercise1” to “Demo” Solution	3
Task3: Create a new class Name it as Rectangle	4
Task4: Object Creation in Main Method	5
EXERCISE2: Creation of a class that return most often value in list of values in array	7
Task1: Creating new project “Exercise2” to “Lab2” Solution	7
Task2: Create a New Class Name “ Solution”	7
EXERCISE3: Program to return no. of perfect squares in between given numbers.	8
Task1: Creating new project “Exercise3” to “Demo” Solution	8
Task2: Create a New Class Name “ Solution”	8
EXERCISE4: Implement a function which takes 2D array A and prints A in spiral order.	8
Task1: Creating new project “Exercise4” to “Lab2” Solution	9
Task2: write a code to display given matrix in spiral form which shown in example.	9
EXERCISE5: C# program for operator overloading	10
Task1: Creating new project “Exercise5” to “Lab2” Solution	10
Task2: C# code to create a new class name “Box” and create a method to find volume of box.	10
Lab Summary	13
Appendix: Code Samples (used if not running sequentially through the lab)	13
EXERCISE1:	13
EXERCISE2:	14
EXERCISE3:	15
EXERCISE4:	16
EXERCISE5:	17
 
 
 
 
 
 
 
 
 
 
Lab Objective
Estimated time to complete this lab: 60 minutes
The objective of this lab is providing a clear understanding basics of c# programming and logical think of programming. In this lab you can understand of control-break statements clearly.
The Lab is structured to 5 Exercises. Each exercise contains several tasks. Each exercise presents different code.
In this lab you preformed the following exercises: 
•	Creation of class to find perimeter and area of Rectangle
•	Creation of a class that return most often value in list of values in array 
•	Program to return no. of perfect squares in between given numbers. 
•	Implement a function which takes 2D array A and prints A in spiral order.
•	C# Program to perform operator overloading 
 
 
EXERCISE1: Creation of class to find perimeter and area of Rectangle
 
Create a class Rectangle with attributes length and width, each of which defaults to 1. Provide member functions that calculate the 
perimeter and the area of the rectangle. Also, provide set and get functions for the length and width attributes. The set functions
should verify that length and width are each floating-point numbers larger than 0.0 and less than 20.0
Task1: Creating a New Solution “Lab2” 
1.	Click the Start | Programs | Microsoft Visual Studio 2017 | Visual Studio 2017.
2.	On the File menu, point to New, and click Project.
3.	In the New Project dialog box select the other project type.
4.	Select the Visual Studio Solution template.
5.	Provide a name for the new solution by entering “Lab2” in the Name box.
6.	Click OK.
 
Task2: Creating new project “Exercise1” to “Lab2” Solution
1.	Right Click on “ Lab2” Solution
2.	On list choose “Add” and click on “New Project”
3.	In the New Project dialog box select the Visual C# Windows project type.
4.	Select the Console Application template.
5.	Provide a name for the new project by entering “Exercise1” in the Name box.
6.	Click OK.
7.	You can able to see below structure of your project
Task3: Create a new class Name it as Rectangle
1.	In the Solution Explorer, double-click Program.cs to open the source code in the Visual C# code editor.
2.	Add new class “Rectangle” to “Exercise1” Namespace and declare variable’s like length and width and assign value is 1 as default.
namespace Exercise1
{
    class Rectangle
    {
        // member variables
        double length=1;
        double width=1;
    }
}
            Add new method “GetData” to “Rectangle” class to enter length and width by user.
       namespace Exercise1
       {
          class Rectangle
          {
              // member variables
              double length=1;
              double width=1;
              public void GetData ()
                {
                 again:
                 Console.WriteLine("enter length:");
                 length = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("enter width:");
                 width = Convert.ToInt32(Console.ReadLine());
                 if (length < 0 || length > 20 ||width<0 ||width>20)
                    {
                     Console.WriteLine("please enter length and width between 0 and 20");
                     goto again;
                    }
                 } 
           }
          
        }
3. Add two more methods to return area and perimeter like “GetArea”  and “GetPerimeter” in Rectangle class
public double GetArea()
        {
            return length * width;
        }
        public double GetPerimeter()
        {
            return 2 * (length + width);
        }
 
Task4: Object Creation in Main Method
1.	Create an object for Student class and call 2 methods in main methods with object.
      static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.GetData();
            r.Display();
            Console.ReadLine();
        }
1.	 Right click on your project “Exercise1” and click on Build (or) Press Ctrl+Shift+B to build the solution.
2.	Press Ctrl+F5 to build and run the application.  The program now compiles without any errors.  Press any key to terminate the application. 
3.	The above Pic shows your output window.
EXERCISE2: Creation of a class that return most often value in list of values in array
 
Write a function:
       class Solution{public int solution(int[] A);}
that, given a zero-indexed array A consisting of N integers, returns the value(or one of the value) that occurs most often in array.
for example, given array A such that:
A[0] = 20
A[1] = 10
A[2] = 30
A[3] = 30
A[4] = 40
A[5] = 10
 
the function may return 10 or 30.
Assume that:
•	N is an integer within the range [1…1,000]
•	Each element of array A is an integer within the range [0…10,000]
Task1: Creating new project “Exercise2” to “Lab2” Solution
1.	Right Click on “Lab2” Solution
2.	On list choose “Add” and click on “New Project”
3.	In the New Project dialog box select the Visual C# Windows project type.
4.	Select the Console Application template.
5.	Provide a name for the new project by entering “Exercise2” in the Name box.
6.	Click OK.
 
Task2: Create a New Class Name “ Solution” 
1.	Create a method name solution
public int solution(int[] A)
{
 
}
2.	Ask user to enter array size and array values.
 
 
 

 
EXERCISE3: Program to return no. of perfect squares in between given numbers. 
 
An integer P is a whole square if it is a square of some integer Q; i.e P=Q^2.
Write a function:
 
          class Solution{ public int solution(int A, int B);}
that, given two integeres A and B, returns the number of whole square within the interval[A,B][both ends included].
for example, given A=4 and b=17, THE FUNCTION SHOULD RETURN 3, BECAUSE THERE ARE THREE SQUARES OF INTEGERS IN THE INTERVAL[4,17], NAMELY 4=2^2, 9=3^2 AND 16=4^2.
Assume that:
•	A and B are integers within the range [-10,000 to 10,000]
•	A<=B.
Task1: Creating new project “Exercise3” to “Demo” Solution
1.	Right Click on “Demo” Solution
2.	On list choose “Add” and click on “New Project”
3.	In the New Project dialog box select the Visual C# Windows project type.
4.	Select the Console Application template.
5.	Provide a name for the new project by entering “Exercise3” in the Name box.
6.	Click OK.
Task2: Create a New Class Name “ Solution” 
1.	Create a method name solution
public int solution(int A, int B)
{
 
}
2.	Ask user to enter A and B values.
 
EXERCISE4: Implement a function which takes 2D array A and prints A in spiral order.
 
 1 2 3
 4 5 6    ===> This example array should print: "1 2 3 6 9 8 7 4 5"
        7 8 9 
Task1: Creating new project “Exercise4” to “Lab2” Solution
1.	Right Click on “Lab2” Solution
2.	On list choose “Add” and click on “New Project”
3.	In the New Project dialog box select the Visual C# Windows project type.
4.	Select the Console Application template.
5.	Provide a name for the new project by entering “Exercise4” in the Name box.
6.	Click OK.
Task2: write a code to display given matrix in spiral form which shown in example.
1.	In the Solution Explorer, Exercise4 Project, double-click Program.cs to open the source code in the Visual C# code editor.
2.	Write a code to enter values or else pass it in main method
3.	Your Ouput should be like below.
 
EXERCISE5: C# program for operator overloading
Task1: Creating new project “Exercise5” to “Lab2” Solution
1.	Right Click on “Lab2” Solution
2.	On list choose “Add” and click on “New Project”
3.	In the New Project dialog box select the Visual C# Windows project type.
4.	Select the Console Application template.
5.	Provide a name for the new project by entering “Exercise5” in the Name box.
6.	Click OK.
Task2: C# code to create a new class name “Box” and create a method to find volume of box.
1.	In the Solution Explorer, Exercise5 Project, double-click Program.cs to open the source code in the Visual C# code editor.
2.	Declare fields like length, breadth and height to find volume of box.
3.	Create a methods like to find volume and to return length, breadth and height seems like below.
public double getVolume()
      {
         return length * breadth * height;
      }
      public void setLength( double len )
      {
         length = len;
      }
 
      public void setBreadth( double bre )
      {
         breadth = bre;
      }
 
      public void setHeight( double hei )
      {
         height = hei;
      }
 
4.	Create atleast 3 objects for box and pass length, breadth and height values from main method.
5.	The output should looks like below
 
Lab Summary

