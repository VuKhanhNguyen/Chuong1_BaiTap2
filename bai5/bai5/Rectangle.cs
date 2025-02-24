using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Rectangle
    {

        Point upper_left_118 { get; set; }
        Point bottom_right_118 { get; set; }

        public Rectangle(Point upper_left_118, Point bottom_right_118)
        {
            this.upper_left_118 = upper_left_118;
            this.bottom_right_118 = bottom_right_118;
        }

        public void RectangleStastus()
        {
            Console.WriteLine("Rectangle upper left co toa do ({0},{1}) va co mau {2}", upper_left_118.x_118, upper_left_118.y_118, upper_left_118.pc_118);
            Console.WriteLine("Rectangle bottom right co toa do ({0},{1}) va co mau {2}", bottom_right_118.x_118, bottom_right_118.y_118, bottom_right_118.pc_118);
        }
    }  
}
