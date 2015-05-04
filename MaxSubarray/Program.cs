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

            foreach (int[] testArray in testArrays)
            {
                Tuple<int, int> maxSubarraySizes = FindMaxSubarraySizes(testArray);
                Console.WriteLine("{0} {1}", maxSubarraySizes.Item1, maxSubarraySizes.Item2);
            }
        }

        private static Tuple<int, int> FindMaxSubarraySizes(int[] testArray)
        {
            int maxEndingHere = testArray[0];
            int maxSoFar = testArray[0];
            int nonContiguousSum = (testArray[0] > 0) ? testArray[0] : 0;

            for (int i = 1; i < testArray.Length; i++)
            {
                int x = testArray[i];
                maxEndingHere = Math.Max(x, maxEndingHere + x);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);

                if (x > 0)
                {
                    nonContiguousSum += x;
                }
            }

            Tuple<int, int> maxSubarraySizes = new Tuple<int, int>
            (
                maxSoFar,
                (nonContiguousSum == 0) ? testArray[0] : nonContiguousSum
            );

            return maxSubarraySizes;
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
