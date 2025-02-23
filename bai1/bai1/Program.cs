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
       

        public void OptionalParameter(string s1_118 = "Antony")
        {
            Console.WriteLine("{0} la G.O.A.T cua lang tuc cau", s1_118);
        }
        public void OptionalParameter2(int a, int b, int c = 2)
        {
            Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, a + b + c);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.OptionalParameter("Messi");
            //OptionalParameter();
            p.OptionalParameter();

        }
    }
}
