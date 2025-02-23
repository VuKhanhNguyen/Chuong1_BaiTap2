using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    //Làm một bài tập có sử dụng optional parameter
    internal class Program
    {
        enum FootballPlayer{
            Antony,
            Lewandowski,
            Ronaldo,
            Messi,
            Haaland,
            Mbappe,
            Sane
        }

        public void OptionalParameter(string s1_118 = "Nguyễn Vũ Khanh")
        {
            Console.WriteLine("{0} là G.O.A.T của làng túc cầu", s1_118);
        }

        static void Main(string[] args)
        {
        }
    }
}
