using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLane
{
    class LaneRange
    {
        int enterIndex;
        public int EnterIndex
        {
            get { return enterIndex; }
            set { enterIndex = value; }
        }

        int exitIndex;
        public int ExitIndex
        {
            get { return exitIndex; }
            set { exitIndex = value; }
        }

        public LaneRange(int enterIndex, int exitIndex)
        {
            this.enterIndex = enterIndex;
            this.exitIndex = exitIndex;
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split(' ');
            int laneRangeCount = Int32.Parse(input[1]);

            input = Console.ReadLine().Split(' ');
            int[] serviceLaneWidths = Array.ConvertAll(input, s => Int32.Parse(s));

            LaneRange[] laneRanges = new LaneRange[laneRangeCount];
            for (int i = 0; i < laneRanges.Length; i++)
            {
                input = Console.ReadLine().Split(' ');
                laneRanges[i] = new LaneRange(Int32.Parse(input[0]), Int32.Parse(input[1]));
            }

            foreach (LaneRange laneRange in laneRanges)
            {
                int maxWidth = FindMinWidthInRange(laneRange, serviceLaneWidths);
                Console.WriteLine(maxWidth);
            }
        }

        private static int FindMinWidthInRange(LaneRange laneRange, int[] laneWidths)
        {
            int laneWidthsInRangeCount = laneRange.ExitIndex - laneRange.EnterIndex + 1;
            int[] laneWidthsInRange = new int[laneWidthsInRangeCount];
            
            Array.Copy(laneWidths, laneRange.EnterIndex, laneWidthsInRange, 0, laneWidthsInRangeCount);

            return laneWidthsInRange.Min();
        }
    }
}
