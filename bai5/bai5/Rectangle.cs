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

        public void RectangleStastus()
        {
            Console.WriteLine("Rectangle upper left co toa do ({0},{1}) va co mau {3}", upper_left.x_118, upper_left.y_118, upper_left.pc_118);
            Console.WriteLine("Rectangle bottom right co toa do ({0},{1}) va co mau {3}", bottom_right.x_118, bottom_right.y_118, bottom_right.pc_118);
        }
    }  
}
