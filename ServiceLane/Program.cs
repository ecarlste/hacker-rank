using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLane
{
    class Solution
    {
        static void Main(string[] args)
        {
            String[] input = Console.ReadLine().Split(' ');
            int testCaseCount = Int32.Parse(input[1]);

            input = Console.ReadLine().Split(' ');
            int[] serviceLaneWidths = Array.ConvertAll(input, s => Int32.Parse(s));
        }
    }
}
