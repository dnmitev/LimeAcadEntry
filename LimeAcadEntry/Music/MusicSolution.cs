using Combinatorics.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class MusicSolution
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            long result = NumOfPlaylists(n, k, l);
            Console.WriteLine(result);
        }

        private static long NumOfPlaylists(int n, int k, int l)
        {
            var list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }
            var result = new Variations<int>(list, l);            return result.Count;
        }
    }
}
