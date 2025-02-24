using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Rectangle
    {

        Point upper_left { get; set; }
        Point bottom_right { get; set; }

        public Rectangle(Point upper_left, Point bottom_right)
        {
            this.upper_left = upper_left;
            this.bottom_right = bottom_right;
        }
    }  
}
