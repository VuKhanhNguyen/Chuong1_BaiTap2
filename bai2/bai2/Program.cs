using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    //Làm một bài tập sử dụng Enum, có sử dụng các phương thức hỗ trợ nó để in ra màn hình
        enum FootballClub_118
        {
            Bayern = 1,
            Leverkusen,
            Frankfurt,
            Freiburg,
            Mainz05,
            Leipzig
        }
    internal class Program
    {
        

        public void rankingClub()
        {
            int i_118 = 1;
            FootballClub_118[] fc_118 = (FootballClub_118[])Enum.GetValues(typeof(FootballClub_118));
            foreach (FootballClub_118 f_118 in fc_118)
            {
                Console.WriteLine("{0}. {1}",i_118,f_118);
                i_118++;
            }
        }

        static void Main(string[] args)
        {
            Program p_118 = new Program();
            p_118.rankingClub();
        }
    }
}
