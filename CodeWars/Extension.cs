using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class Extension
    {
        public static List<int> ArrayTolist(this int[,] grid)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    list.Add(grid[i, j]);
                }
            }
            return list;
        }
    }
}
