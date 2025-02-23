using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    //Làm một bài tập sử dụng Enum, có sử dụng các phương thức hỗ trợ nó để in ra màn hình
        enum FootballClub
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
            int i;
            FootballClub[] fc = (FootballClub[])Enum.GetValues(typeof(FootballClub));
            for(i=1; i <= fc.Length; i++)
            {
                Console.WriteLine("{0}. {1}",i,fc);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
