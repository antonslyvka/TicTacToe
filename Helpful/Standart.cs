using System;

namespace Helpful
{
    public class Standart
    {
        public static string Input(string data)
        {
            Console.WriteLine(data);
            string x = Console.ReadLine();
            return x;
        }

        public static void WriteEnd(string data)
        {
            Console.WriteLine(" ");
            Console.WriteLine(data);
        }

        public static void DoStep(string data1, string data2, string[,] table, string i)
        {
            int row = int.Parse(Standart.Input(data1));
            int column = int.Parse(Standart.Input(data2));
            table[row - 1, column - 1] = i;
        }

        public static bool Win(string[,] table, string i)
        {
            return IsHorizontalWin(table, i) || IsVerticalWin(table, i) ||
                IsStraightDiagonal(table, i) || IsOppositeDiagonal(table, i);
        }

        private static bool IsStraightDiagonal(string[,] table, string symb)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                if (table[i, i] != symb)
                    return false;
            }

            return true;
        }

        private static bool IsOppositeDiagonal(string[,] table, string symb)
        {
            for (int i = 0, j = table.GetLength(1) - 1; i < table.GetLength(0) && j >= 0; i++, j--)
            {
                if (table[i, j] != symb)
                    return false;
            }

            return true;
        }

        private static bool IsVerticalWin(string[,] table, string symb)
        {
            return IsTheSameLineInArray(table, symb, false);
        }

        private static bool IsHorizontalWin(string[,] table, string symb)
        {
            return IsTheSameLineInArray(table, symb, true);
        }

        private static bool IsTheSameLineInArray(string[,] table, string symb, bool horizontal)
        {
            int firstDimension, secondDimension;
            if (horizontal)
            {
                firstDimension = 0;
                secondDimension = 1;
            }
            else
            {
                firstDimension = 1;
                secondDimension = 0;
            }


            for (int i = 0; i < table.GetLength(firstDimension); i++)
            {
                bool theSame = true;

                for (int j = 0; j < table.GetLength(secondDimension); j++)
                {
                    if (horizontal)
                    {
                        if (table[i, j] != symb)
                            theSame = false;
                    }
                    else
                    {
                        if (table[j, i] != symb)
                            theSame = false;
                    }
                }

                if (theSame)
                    return true;
            }

            return false;
        }

        public static void WriteTable(string[,] table)
        {
            Console.WriteLine("|" + table[0, 0] + "|" + table[0, 1] + "|" + table[0, 2] + "|");
            Console.WriteLine("|" + table[1, 0] + "|" + table[1, 1] + "|" + table[1, 2] + "|");
            Console.WriteLine("|" + table[2, 0] + "|" + table[2, 1] + "|" + table[2, 2] + "|");
        }
    }
}
