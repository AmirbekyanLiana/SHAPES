using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES
{
    class Rectangle : Shape
    {
        private int perimeter;
        private int surface;
        public Rectangle()
        {
            Console.WriteLine("Enter the length of the side of the rectangle");
            lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the widht of the side of the rectangle");
            widht = Convert.ToInt32(Console.ReadLine());
        }
        public override void Surface()
        {
            surface = lenght * widht;
        }
        public override void Perimeter()
        {
            perimeter = widht * 2 + lenght * 2;
        }
        public virtual void DisplayInfo()
        {
            Surface();
            Perimeter();
            Console.WriteLine("The perimeter formula: perimeter = widht * 2 + lenght * 2");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine("Surface formula: surface = widht * lenght");
            Console.WriteLine($"Surface: {surface}");
        }
    }
}
