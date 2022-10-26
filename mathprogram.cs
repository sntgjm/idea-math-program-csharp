using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathprogram_csharp_github
{
    internal class mathprogram
    {
        static void Main(string[] args)
        {

            int j = 35;
            int m = 36;
            int z = 93;
            int s = 25;
            int t = -70;

            int jm = j - m / z + s - t; 
            int sn = t - s + z / m - j; 
            int tg = z / m - j - s / t; 

            Console.WriteLine(Math.Max(j, m));
            Console.WriteLine(Math.Min(s, t));
            Console.WriteLine(jm);
            Console.WriteLine(sn);
            Console.WriteLine(tg);

        }
    }
}
