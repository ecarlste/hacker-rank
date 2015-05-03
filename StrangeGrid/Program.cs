using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeGrid
{
    class Solution
    {
        static void Main(string[] args)
        {
            Tuple<int, int> rowAndColumn = ReadRowAndColumnInput();

            long value = FindSequenceValueByRowColumn(rowAndColumn.Item1, rowAndColumn.Item2);

            Console.WriteLine(value);
        }

        private static long FindSequenceValueByRowColumn(int row, int column)
        {
            int valueFromColumn = 2 * (column - 1);
            int valueFromOddOrEvenRow = (row % 2 == 0) ? 1 : 0;
            long valueFromRow = 10 * (long) ((row + 1) / 2 - 1) + valueFromOddOrEvenRow;

            return valueFromColumn + valueFromRow;
        }

        private static Tuple<int, int> ReadRowAndColumnInput()
        {
            string[] input = Console.ReadLine().Split(' ');

            return new Tuple<int, int>(Int32.Parse(input[0]), Int32.Parse(input[1]));
        }
    }
}
