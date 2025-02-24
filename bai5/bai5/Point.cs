using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{

enum PointColor_118
        {
            LightBlue,
            BloodRed,
            Gold
        }

    internal class Point
    {
        
        public int x_118 { get; set; }
        public int y_118 { get; set; }

        public PointColor_118 pc_118 { get; set; }

        public Point(int x_118, int y_118, PointColor_118 pc_118)
        {
            this.x_118 = x_118;
            this.y_118 = y_118;
            this.pc_118 = pc_118;
        }

        public void PointStatus()
        {
            Console.WriteLine("Point co toa do ({0},{1}) va co mau {3}", this.x_118, this.y_118, this.pc_118);
        }
    }
}
