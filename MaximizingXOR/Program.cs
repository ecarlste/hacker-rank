using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static int maxXor(int l, int r)
    {
        int maxXorValueFound = 0;

        for (int firstTerm = l; firstTerm <= r; firstTerm++)
        {
            for (int secondTerm = firstTerm + 1; secondTerm <= r; secondTerm++)
            {
                int currentXorValue = firstTerm ^ secondTerm;

                if (currentXorValue > maxXorValueFound)
                {
                    maxXorValueFound = currentXorValue;
                }
            }
        }

        return maxXorValueFound;
    }

    static void Main(String[] args)
    {
        int res;
        int _l;
        _l = Convert.ToInt32(Console.ReadLine());

        int _r;
        _r = Convert.ToInt32(Console.ReadLine());

        res = maxXor(_l, _r);
        Console.WriteLine(res);

    }
}
