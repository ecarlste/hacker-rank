using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LonelyInteger
{
    class Solution
    {
        static int lonelyinteger(int[] a)
        {
            Dictionary<int, int> valueCounts = BuildDictionaryOfValueCounts(a);

            int lonelyInteger = FindLonelyInteger(valueCounts);

            return lonelyInteger;
        }

        private static int FindLonelyInteger(Dictionary<int, int> valueCounts)
        {
            IEnumerable<int> item = from pair in valueCounts where pair.Value == 1 select pair.Key;

            return item.Single();
        }

        private static Dictionary<int, int> BuildDictionaryOfValueCounts(int[] a)
        {
            Dictionary<int, int> valueCounts = new Dictionary<int, int>();

            foreach (int key in a)
            {
                if (valueCounts.ContainsKey(key))
                {
                    valueCounts[key]++;
                }
                else
                {
                    valueCounts[key] = 1;
                }
            }

            return valueCounts;
        }

        static void Main(String[] args)
        {
            int res;

            int _a_size = Convert.ToInt32(Console.ReadLine());
            int[] _a = new int[_a_size];
            int _a_item;
            String move = Console.ReadLine();
            String[] move_split = move.Split(' ');
            for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
            {
                _a_item = Convert.ToInt32(move_split[_a_i]);
                _a[_a_i] = _a_item;
            }

            res = lonelyinteger(_a);
            Console.WriteLine(res);
        }
    }
}
