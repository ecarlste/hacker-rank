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
                Console.WriteLine(testString);
            }
        }

        private static int DetermineMinimumChangesForPalidrome(string testString)
        {
            return 0;
        }
    }
}
