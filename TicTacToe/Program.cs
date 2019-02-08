using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpful;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesTable = new string[2];
            namesTable[0] = Standart.Input("please write name of player one(x)");
            namesTable[1] = Standart.Input("please write name of player two(0)");

            string[,] playTable = new string[3, 3];
            for(int r=0; r<3;r++)
            {
                for(int c=0; c<3; c++)
                {
                    playTable[r, c] = " ";
                }
            }


            int stepsCount = 0;
            string sign ="x";
            string playerName;
            while (Standart.Win(playTable, sign) == false && stepsCount != 9)
            {               
                    if (stepsCount == 0 || stepsCount % 2 == 0)
                    {
                        playerName = namesTable[0];
                        sign = "x";
                    }
                    else
                    {
                        playerName = namesTable[1];
                        sign = "0";
                    }
                    Standart.DoStep("player " + playerName + " enter row", "player " + playerName + " enter column", playTable, sign);
                    Standart.WriteTable(playTable);
                    stepsCount++;
            }


            if (Standart.Win(playTable, sign) == true)
            {
                if (sign == "x")
                {
                    Standart.WriteEnd("THE END");
                    Console.WriteLine("player " + namesTable[0] + "  wins");
                }
                else
                {
                    Standart.WriteEnd("THE END");
                    Console.WriteLine("player " + namesTable[1] + "  wins");
                }
            }
            else
            {
                Standart.WriteEnd("A DRAW");
            }
            Console.ReadLine();


        }
    }
}
