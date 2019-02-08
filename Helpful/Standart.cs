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
            if
                (
            //gorizontal
            (object.Equals(table[0, 0], table[0, 1]) && object.Equals(table[0, 0], table[0, 2]) && object.Equals(table[0, 0], i)) ||
            (object.Equals(table[1, 0], table[0, 1]) && object.Equals(table[1, 0], table[0, 2]) && object.Equals(table[1, 0], i)) ||
            (object.Equals(table[2, 0], table[0, 1]) && object.Equals(table[2, 0], table[0, 2]) && object.Equals(table[2, 0], i)) ||
            //vertical
            (object.Equals(table[0, 0], table[1, 0]) && object.Equals(table[0, 0], table[2, 0]) && object.Equals(table[0, 0], i)) || 
            (object.Equals(table[0, 1], table[1, 1]) && object.Equals(table[0, 1], table[2, 1]) && object.Equals(table[0, 1], i)) || 
            (object.Equals(table[0, 2], table[1, 2]) && object.Equals(table[0, 2], table[2, 2]) && object.Equals(table[0, 2], i)) || 
            //krest
            (object.Equals(table[0, 0], table[1, 1]) && object.Equals(table[0, 0], table[2, 2]) && object.Equals(table[0, 0], i)) || 
            (object.Equals(table[0, 2], table[1, 1]) && object.Equals(table[0, 0], table[2, 0]) && object.Equals(table[0, 2], i))
            )
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static void WriteTable(string[,] table)
        {
            Console.WriteLine("|" + table[0, 0] + "|" + table[0, 1] + "|" + table[0, 2] + "|");
            Console.WriteLine("|" + table[1, 0] + "|" + table[1, 1] + "|" + table[1, 2] + "|");
            Console.WriteLine("|" + table[2, 0] + "|" + table[2, 1] + "|" + table[2, 2] + "|");
        }


    }
}
