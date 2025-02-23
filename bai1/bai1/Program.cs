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
        public void OptionalParameter2(int a_118, int b_118, int c_118 = 2)
        {
            Console.WriteLine("{0}+{1}+{2}={3}", a_118, b_118, c_118, a_118 + b_118 + c_118);
        }

        static void Main(string[] args)
        {
            int a_118 = 1, b_118 = 1, c_118 = 1;
            Program p = new Program();
            p.OptionalParameter("Messi");
            //OptionalParameter();
            p.OptionalParameter();
            p.OptionalParameter2(a_118, b_118, c_118);
            p.OptionalParameter2(a_118, b_118);

        }
    }
}
