using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingCharacters
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
                int numberOfDeletions = FindDeletionsNeededForAlternating(testString);
                Console.WriteLine(numberOfDeletions);
            }
        }

        private static int FindDeletionsNeededForAlternating(string testString)
        {
            int numberOfDeletions = 0;
            char lastCharacter = testString[0];
            char thisCharacter;

            for (int i = 1; i < testString.Length; i++)
            {
                thisCharacter = testString[i];

                if (thisCharacter == lastCharacter)
                {
                    numberOfDeletions++;
                }
                else
                {
                    lastCharacter = thisCharacter;
                }
            }

            return numberOfDeletions;
        }
    }
}
