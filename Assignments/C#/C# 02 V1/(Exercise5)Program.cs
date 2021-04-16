using System;

namespace Exercise5
{
    class Program
    {

            static void Main(string[] args)
            {
                Box Box1 = new Box(); // Declare Box 1 of type Box
                Box Box2 = new Box();
                Box Box3 = new Box();
                double volume = 0.0;

                // box 1 specification
                Box1.setLength(6.0);
                Box1.setBreadth(7.0);
                Box1.setHeight(5.0);

                // box 2
                Box2.setLength(12.0);
                Box2.setBreadth(13.0);
                Box2.setHeight(10.0);

                // volume of box 1
                volume = Box1.getVolume();
                Console.WriteLine("Volume of Box1: {0}", volume);
                volume = Box2.getVolume();
                Console.WriteLine("Volume of Box2: {0}", volume);

                Box3 = Box1 + Box2;

                volume = Box3.getVolume();
                Console.WriteLine("Volume of Box2 : {0}", volume);
                Console.ReadKey();


            }
        }
    

    class Box
    {
        // variables
        double length;
        double breadth;
        double height;

        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }


        // Overload + operator to add two Box objects/
        public static Box operator+ (Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
    }
}
