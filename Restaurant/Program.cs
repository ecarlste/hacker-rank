using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class BreadLoaf
    {
        int length;
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        int breadth;
        public int Breadth
        {
            get { return breadth; }
            set { breadth = value; }
        }

        public BreadLoaf(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            BreadLoaf[] loaves = ReadBreadData();

            foreach (BreadLoaf loaf in loaves)
            {
                int maxBreadSquares = FindMaxBreadSquares(loaf);
                Console.WriteLine(maxBreadSquares);
            }
        }

        private static int FindMaxBreadSquares(BreadLoaf loaf)
        {
            BigInteger breadLength = loaf.Length;
            BigInteger breadBreadth = loaf.Breadth;

            BigInteger bigGreatestCommonDivisor = BigInteger.GreatestCommonDivisor(breadLength, breadBreadth);
            int greatestCommonDivisor;

            try
            {
                greatestCommonDivisor = (int) bigGreatestCommonDivisor;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Unable to convert {0}: \n   {1}",
                    bigGreatestCommonDivisor, e.Message);
                return -1;
            }

            return loaf.Length * loaf.Breadth / (greatestCommonDivisor * greatestCommonDivisor);
        }
        
        private static BreadLoaf[] ReadBreadData()
        {
            int testCaseCount = Int32.Parse(Console.ReadLine());
            BreadLoaf[] loaves = new BreadLoaf[testCaseCount];

            for (int i = 0; i < testCaseCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                loaves[i] = new BreadLoaf(Int32.Parse(input[0]), Int32.Parse(input[1]));
            }

            return loaves;
        }
    }
}
