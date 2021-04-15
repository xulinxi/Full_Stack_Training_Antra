C#.NET Exercise
 
 
 
 
 
 
 
 
 
 
 
 
 
Contents
EXERCISE Objective	3
EXERCISE1: Creating a Sample Project	3
Task1: Creating a New Solution “Demo”	3
Task2: Creating new project “DemoTask” to “Demo” Solution	3
Task3: Create a new class to understand class, method and object (instance of a class)	4
Task4: Object Creation in Main Method	5
EXERCISE2: Program for Arithmetic Operations using with Switch Case.	6
Perform Arithmetic operations on 2 numbers and use switch case to handle particular operation	6
Task1: Creating new project “Exercise2” to “Demo” Solution	6
Task3: write a Switch case in Main method, to get the value as per user choice.	7
EXERCISE3: Create a Program to reverse a given string	7
Task1: Creating new project “Exercise3” to “Demo” Solution	7
Task2: Write a code to reverse a string	7
EXERCISE4: Write a Program to display “Armstrong Numbers” in between range of 2 numbers.	7
Task1: Creating new project “Exercise4” to “Demo” Solution	7
Task2: Code to display Armstrong number between range of given numbers	7
EXERCISE5: C# Program to print a binary triangle	8
Task1: Creating new project “Exercise5” to “Demo” Solution	8
Task2: C# code to print a binary triangle for No.of Rows	8
EXERCISE6: Write a C# Program to print a Diamond	9
Task1: Creating new project “Exercise6” to “Demo” Solution	9
Task2: code to display a diamond for user-specified rows	9
EXERCISE7: Write a C# Program to Display the ATM Transaction	9
Task1: Creating new project “Exercise6” to “Demo” Solution	9
Task2: Code for ATM Transaction opt by User	10
EXERCISE Summary	11
Appendix: Code Samples (used if not running sequentially through the lab)	11
EXERCISE1:	11
EXERCISE2:	12
EXERCISE3:	13
EXERCISE4:	14
EXERCISE5:	15
EXERCISE6:	15
EXERCISE7:	16
 
 
 
 
 
 
 
 
 
Lab Objective
Estimated time to complete this Exercise: 60 minutes
The objective of this lab is providing a clear understanding basics of c# programming and logical think of programming. In this lab you can understand of control-break statements clearly.
The Lab is structured to 7 Exercises. Each exercise contains several tasks. Each exercise presents different code.
In this lab you preformed the following exercises: 
•	Creation of sample project to understand class, method and object
•	Program for Arithmetic Operations using with Switch Case.
•	Program to reverse a given string 
•	Program to display “Armstrong Numbers” in between range of 2 numbers.
•	C# Program to print a binary triangle 
•	Write a C# Program to print a Diamond
•	C# Program to Display the ATM Transaction
 
 
EXERCISE1: Creating a Sample Project
In This sample program you will understand functionality of class, method and object
Task1: Creating a New Solution “Demo” 
1.	Click the Start | Programs | Microsoft Visual Studio 2017 | Visual Studio 2017.
2.	On the File menu, point to New, and click Project.
3.	In the New Project dialog box select the other project type.
4.	Select the Visual Studio Solution template.
5.	Provide a name for the new solution by entering “Demo” in the Name box.
6.	Click OK.
 
Task2: Creating new project “DemoTask” to “Demo” Solution
1.	Right Click on “Demo” Solution
2.	On list choose “Add” and click on “New Project”
3.	In the New Project dialog box select the Visual C# Windows project type.
4.	Select the Console Application template.
5.	Provide a name for the new project by entering “DemoTask” in the Name box.
6.	Click OK.
7.	You can able to see below structure of your project
  
Task3: Create a new class to understand class, method and object (instance of a class)
1.	In the Solution Explorer, double-click Program.cs to open the source code in the Visual C# code editor.
2.	Add new class “Student” to “DemoTask” Namespace and declare variable’s like Name, Address and Mobile
namespace DemoTask
{
    public class Student
    {
              string Name, Address;
       int Mobile;
 
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
3.	Add new method “GetData” to “Student” class
public class Student
    {
        string Name, Address;
        int Mobile;
        public void GetData()
        {
            Console.WriteLine("Enter your Name");
            Name =Console.ReadLine();
            Console.WriteLine("Enter your Address");
            Address = Console.ReadLine();
            Console.WriteLine("Enter your Mobile Number:");
            Mobile =Convert.ToInt32(Console.ReadLine());
        }
    }
4.	Add one more method to display student data like “DisplayData” in student class
public void DisplayData()
        {
            Console.WriteLine("Student Name:" + Name);
            Console.WriteLine("Student Address:" + Address);
            Console.WriteLine("Student Mobile" + Mobile);
        }
 
Task4: Object Creation in Main Method
5.	Create an object for Student class and call 2 methods in main methods with object.
class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GetData();
            s1.DisplayData();
            Console.ReadKey();
        }
    }
6.	Right click on your project “DemoTask” and click on Build (or) Press Ctrl+Shift+B to build the solution.
7.	Press Ctrl+F5 to build and run the application.  The program now compiles without any errors.  Press any key to terminate the application.
  
8.	The above Pic shows your complete code and output window.
 
 
EXERCISE2: Program for Arithmetic Operations using with Switch Case.
Perform Arithmetic operations on 2 numbers and use switch case to handle particular operation
Task1: Creating new project “Exercise2” to “Demo” Solution
1.	Right Click on “Demo” Solution
2.	On list choose “Add” and click on “New Project”
3.	In the New Project dialog box select the Visual C# Windows project type.
4.	Select the Console Application template.
5.	Provide a name for the new project by entering “Exercise2” in the Name box.
6.	Click OK.
 
Task2: Create a New Class Name “Arithmetic” 
1.	Declare variables like a and b for addition, subtraction, multiplication and division.
2.	Create a methods for Addition, subtraction, multiplication and division
 
Task3: write a Switch case in Main method, to get the value as per user choice.
 
EXERCISE3: Create a Program to reverse a given string
Task1: Creating new project “Exercise3” to “Demo” Solution
1.	Right Click on “Demo” Solution
2.	On list choose “Add” and click on “New Project”
3.	In the New Project dialog box select the Visual C# Windows project type.
4.	Select the Console Application template.
5.	Provide a name for the new project by entering “Exercise3” in the Name box.
6.	Click OK.
Task2: Write a code to reverse a string
1.	In the Solution Explorer, Exercise4 Project, double-click Program.cs to open the source code in the Visual C# code editor.
2.	Write a code to reverse a string[ program allows user to enter his own string]
3.	Display the string by reversing it.
 
EXERCISE4: Write a Program to display “Armstrong Numbers” in between range of 2 numbers.
Task1: Creating new project “Exercise4” to “Demo” Solution
1.	Right Click on “Demo” Solution
2.	On list choose “Add” and click on “New Project”
3.	In the New Project dialog box select the Visual C# Windows project type.
4.	Select the Console Application template.
5.	Provide a name for the new project by entering “Exercise4” in the Name box.
6.	Click OK.
Task2: Code to display Armstrong number between range of given numbers
1.	In the Solution Explorer, Exercise4 Project, double-click Program.cs to open the source code in the Visual C# code editor.
2.	Write a code to enter 2 values from the user.[For example first number:1 and second number: 1000]
3.	Display the Armstrong numbers in between first number and second number.
4.	Your Output sshould be like below.
  
 
EXERCISE5: C# Program to print a binary triangle
Task1: Creating new project “Exercise5” to “Demo” Solution
1.	Right Click on “Demo” Solution
2.	On list choose “Add” and click on “New Project”
3.	In the New Project dialog box select the Visual C# Windows project type.
4.	Select the Console Application template.
5.	Provide a name for the new project by entering “Exercise5” in the Name box.
6.	Click OK.
Task2: C# code to print a binary triangle for No. of Rows
1.	In the Solution Explorer, Exercise5 Project, double-click Program.cs to open the source code in the Visual C# code editor.
2.	Your C# Program need to Prints a Binary Triangle. Binary Triangle is a Triangle formed with 1′s and 0′s.Number of rows in the binary triangle is obtained from the user.
3.	Write a code to enter a no.of rows from the user.[For example No.of Rows: 5]
4.	Display the binary Triangle for user given rows.
5.	Your Output should be like below.
   Enter the Number of Rows: 5
1
01
010
1010
10101
 
EXERCISE6: Write a C# Program to print a Diamond
Task1: Creating new project “Exercise6” to “Demo” Solution
7.	Right Click on “Demo” Solution
8.	On list choose “Add” and click on “New Project”
9.	In the New Project dialog box select the Visual C# Windows project type.
10.	Select the Console Application template.
11.	Provide a name for the new project by entering “Exercise6” in the Name box.
12.	Click OK.
Task2: code to display a diamond for user-specified rows
6.	In the Solution Explorer, Exercise6 Project, double-click Program.cs to open the source code in the Visual C# code editor.
7.	Your C# Program need to Prints a Diamond with *’s .
8.	Write a code to enter a no.of rows from the user.[For example No.of Rows: 3]
9.	Display the Diamond for 3 rows.
10.	Your Output should be like below.
Enter number of rows
3
  *
 ***
*****
 ***
  *
 
EXERCISE7: Write a C# Program to Display the ATM Transaction
Task1: Creating new project “Exercise6” to “Demo” Solution
1.	Right Click on “Demo” Solution
2.	On list choose “Add” and click on “New Project”
3.	In the New Project dialog box select the Visual C# Windows project type.
4.	Select the Console Application template.
5.	Provide a name for the new project by entering “Exercise7” in the Name box.
6.	Click OK.
Task2: Code for ATM Transaction opt by User
1.	In the Solution Explorer, Exercise7 Project, double-click Program.cs to open the source code in the Visual C# code editor.
2.	This C# Program Need to Displays the ATM Transaction. Here The types of ATM transaction are
1)	Balance Checking
2)	Cash Withdrawal
3)	Cash Deposition
3.	Initially you can assign Amount for your ATM Number 1000RS.
4.	You can opt any of the above transaction according to your need of transaction.
5.	Your Output should be like below.
Enter Your Pin Number
123
********Welcome to ATM Service**************
 
1. Check Balance
 
2. Withdraw Cash
 
3. Deposit Cash
 
4. Quit
 
*********************************************
Enter your choice:
1
 YOU’RE BALANCE IN Rs: 1000
 

