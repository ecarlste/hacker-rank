using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyString
{
    class Program
    {
        static bool IsFunnyString(string testString)
        {
            bool isFunny = true;

            int leftIndex = 1;
            int rightIndex = testString.Length - 2;

            while (isFunny && leftIndex <= rightIndex)
            {
                int leftChange = testString[leftIndex] - testString[leftIndex - 1];
                int rightChange = testString[rightIndex] - testString[rightIndex + 1];

                if (Math.Abs(leftChange) != Math.Abs(rightChange))
                {
                    isFunny = false;
                }
                else
                {
                    leftIndex++;
                    rightIndex--;
                }
            }

            return isFunny;
        }

        static void Main(string[] args)
        {
            int numberOfTestStrings = Int32.Parse(Console.ReadLine());
            string[] testStrings = new string[numberOfTestStrings];

            for (int i = 0; i < numberOfTestStrings; i++)
            {
                testStrings[i] = Console.ReadLine();
            }

            foreach (string testString in testStrings)
            {
                if (IsFunnyString(testString))
                {
                    Console.WriteLine("Funny");
                }
                else
                {
                    Console.WriteLine("Not Funny");
                }
            }
        }
    }
}
