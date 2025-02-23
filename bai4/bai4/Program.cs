using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        //Làm một bài tập sử dụng array, sử dụng foreach
        static void BayernPlayer(string[] arr_118)
        {
            int index_118 = 1;
            foreach (string a_118 in arr_118)
            {
                Console.WriteLine("{0}. {1}",index_118, a_118);
                index_118++;
            }
        }

        static void BayernSplitCharacters(char[] arr2_118)
        {
            int index_118 = 1;
            foreach (char a2_118 in arr2_118)
            { 
                Console.WriteLine("{0}. {1}",index_118,a2_118);
                index_118++;   
            }
        }

        static void Main(string[] args)
        {
            string[] arr_118 = { "Kane", "Olise", "Musiala", "Muller", "Sane", "Gnabry", "Coman" };
            BayernPlayer(arr_118);

            char[] arr2_118 = "Bayern".ToCharArray();
            BayernSplitCharacters(arr2_118);
        }
    }
}
