using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape1 r = new Shape1();
            r.calculateRecArea();
            r.calculateRecCircumferences();
        }
    }

    abstract class Shape1
    {
        protected float R, L, B;

        // Abstract methods can have only declarations
        public abstract float Area();
        public abstract float Circumference();

    }

    abstract class Rectangle
    {
        public float L { get; set; }
        public float B { get; set; }

        public void AddRectange()
        {
            Console.Write("Enter length： ");
            L = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter breadth： ");
            B = Convert.ToInt32(Console.ReadLine());
        }


        public void calculateRecArea()
        {
            float recArea = L * B;
            Console.WriteLine($"Rectangele area is: {recArea}");

        }

        public void calculateRecCircumferences()
        {
            float recCir = 2 * (L + B);
            Console.WriteLine($"Rectangele circumference is: {recCir}");

        }
    }



    abstract class Circle
    {
        public float R { get; set; }

        public void AddCircle()
        {
            Console.Write("Enter radius： ");
            R = Convert.ToInt32(Console.ReadLine());
        }

        public void calculateCirArea()
        {
            float cirArea = Convert.ToInt32(3.14) * R * R;
            Console.WriteLine($"Circle area is: {cirArea}");

        }

        public void calculateCirCircumferences()
        {
            float recCir = 2 * Convert.ToInt32(3.14) * R;
            Console.WriteLine($"Rectangele circumference is: {recCir}");

        }



    }
}
