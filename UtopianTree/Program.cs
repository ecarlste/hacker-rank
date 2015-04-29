using System;
using System.Collections.Generic;
using System.IO;

namespace UtopianTree
{
    class Solution
    {
        enum Seasons
        {
            Summer,
            Spring
        };

        static void Main(string[] args)
        {
            int testCount = Int32.Parse(Console.ReadLine());
            int[] testCases = new int[testCount];

            for (int i = 0; i < testCount; i++)
            {
                testCases[i] = Int32.Parse(Console.ReadLine());
            }

            foreach (int testCase in testCases)
            {
                Console.WriteLine(FindTreeHeightAfterSeasons(testCase));
            }
        }

        private static int FindTreeHeightAfterSeasons(int numberOfSeasons)
        {
            Seasons currentSeason = Seasons.Spring;
            int treeHeight = 1;

            for (int seasonsLeft = numberOfSeasons; seasonsLeft > 0; seasonsLeft--)
            {
                if (currentSeason == Seasons.Spring)
                {
                    treeHeight *= 2;
                    currentSeason = Seasons.Summer;
                }
                else
                {
                    treeHeight += 1;
                    currentSeason = Seasons.Spring;
                }
            }

            return treeHeight;
        }
    }
}
