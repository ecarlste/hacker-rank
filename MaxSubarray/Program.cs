using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubarray
{
    class Solution
    {
        static void Main(string[] args)
        {
            List<int[]> testArrays = BuildTestArrayListFromInput();
        }

        private static List<int[]> BuildTestArrayListFromInput()
        {
            List<int[]> testArrays = new List<int[]>();

            int testArrayCount = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < testArrayCount; i++)
            {
                Console.ReadLine();

                string[] input = Console.ReadLine().Split(' ');

                testArrays.Add(Array.ConvertAll(input, s => Int32.Parse(s)));
            }

            return testArrays;
        }
    }
}
