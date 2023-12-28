using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES
{
    class Square : Shape
    {
        private int perimeter;
        private int surface;
        public Square()
        {
            Console.WriteLine("Enter the length of the side of the square");
            widht = Convert.ToInt32(Console.ReadLine());
            lenght = widht;
        }
        public override void Surface()
        {
            surface = lenght * widht;
        }
        public override void Perimeter()
        {
            perimeter = widht * 4;
        }
        public virtual void DisplayInfo()
        {
            Surface();
            Perimeter();
            Console.WriteLine("The perimeter formula: perimeter = widht * 4");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine("Surface formula: surface = widht * lenght");
            Console.WriteLine($"Surface: {surface}");
        }
    }
}
