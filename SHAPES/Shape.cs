using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES
{
    abstract class Shape
    {
        protected int lenght;
        protected int widht;
        public abstract void Perimeter();
        public abstract void Surface();
        public virtual void DisplayInfo()
        {
            Console.WriteLine();
        }        
    }
}
