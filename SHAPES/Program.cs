using System;

namespace SHAPES
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("HELLO!");
            Select_Geometry();
        }
        static void Select_Geometry()
        {
            int shape;
            Console.WriteLine("Select the geometry");
            Console.WriteLine("Square: 1" + "\n" + "Rectangle: 2" + "\n" + "Triangle: 3");
            shape = Convert.ToInt32(Console.ReadLine());
            if (shape == 1)
            {
                Square square = new Square();
                square.DisplayInfo();
            }
            else if (shape == 2)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.DisplayInfo();
            }
            else if (shape == 3)
            {
                Triangle triangle = new Triangle();
                triangle.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Sorry, wrong number was entered, please try again");
                Select_Geometry();
            }
        }
    }
}
