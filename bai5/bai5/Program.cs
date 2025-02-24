using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Point pointUpperLeft_118 = new Point(10, 25, PointColor_118.LightBlue);
            pointUpperLeft_118.PointStatus();

            Point pointBottomRight_118 = new Point(4, 11, PointColor_118.BloodRed);
            pointBottomRight_118.PointStatus();

            Rectangle rect = new Rectangle(pointUpperLeft_118,pointBottomRight_118);
            rect.RectangleStastus();
        }
    }
}
