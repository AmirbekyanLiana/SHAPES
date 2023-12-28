using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES
{
    class Triangle : Shape
    {
        private int perimeter;
        private int surface;
        private int height;
        private int[] arr = new int[3];
        public Triangle()
        {
            Console.WriteLine("Enter the height of the side of the triangle");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the widht of the side of the triangle");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (arr[0] > arr[1] + arr[2] || arr[1] > arr[0] + arr[2] || arr[2] > arr[1] + arr[0])
            {
                Console.WriteLine("Sorry, no triangle with this size, try again");
                Triangle triangle = new Triangle();
                triangle.DisplayInfo();
            }
        }
        public override void Surface()
        {
            surface = (arr[0] / 2) * height;
        }
        public override void Perimeter()
        {
            for (int i = 0; i < 3; i++)
            {
                perimeter += arr[i];
            }
        }
        public virtual void DisplayInfo()
        {
            Surface();
            Perimeter();
            Console.WriteLine("The perimeter formula: perimeter = widht of the side + widht of the side + widht of the side");
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine("Surface formula: surface = widht / 2 * height");
            Console.WriteLine($"Surface: {surface}");
        }
    }
}
