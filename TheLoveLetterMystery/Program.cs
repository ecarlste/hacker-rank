using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLoveLetterMystery
{
    class Solution
    {
        static void Main(string[] args)
        {
            int testCaseCount = Int32.Parse(Console.ReadLine());
            string[] testStrings = new string[testCaseCount];

            for (int i = 0; i < testCaseCount; i++)
            {
                testStrings[i] = Console.ReadLine();
            }

            foreach (string testString in testStrings)
            {
                int minimumChanges = DetermineMinimumChangesForPalidrome(testString);
                Console.WriteLine(minimumChanges);
            }
        }

        private static int DetermineMinimumChangesForPalidrome(string testString)
        {
            int palidromicChangeCount = 0;
            int leftIndex = 0;
            int rightIndex = testString.Length-1;

            while (leftIndex < rightIndex)
            {
                int characterValueChange = Math.Abs(testString[leftIndex] - testString[rightIndex]);
                palidromicChangeCount += characterValueChange;
                leftIndex++;
                rightIndex--;
            }

            return palidromicChangeCount;
        }
    }
}
