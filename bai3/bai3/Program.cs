using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    //Làm một bài tập có định nghĩa lớp Enum, phương thức có dùng Optional parameter, kết hợp cả hai trong bài tập.
    internal class Program
    {
        enum FootballMatchProgress_118
        {
            NotStart,
            InMatch,
            HalfTime,
            FullTime,
            Canceled,
        }

        static void FootBallMatch(string match_118, FootballMatchProgress_118 fmp_118 = FootballMatchProgress_118.NotStart)
        {
            Console.WriteLine("{0} is {1}", match_118, fmp_118);
        }

        static void Main(string[] args)
        {
        }
    }
}
