using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInRowGame
{
    internal class Bord
    {
        private int[,] matBord;

        public Bord()
        {
            matBord = new int[6, 7];
        }
        // returns a copy of the matBord (instence of proprty)
        public int[,] MatBord()
        {
            int[,] helpMat = new int[6, 7];
            for (int i = 0; i < matBord.GetLength(0); i++)
            {
                for (int j = 0; j < matBord.GetLength(1); j++)
                {
                    helpMat[i, j] = matBord[i, j];
                }
            }
            return helpMat;
        }
        public void print()
        {
            for (int i = 0; i < matBord.GetLength(0); i++)
            {
                for (int j = 0; j < matBord.GetLength(1); j++)
                {
                    Console.Write("|"+matBord[i, j] );
                }
                Console.WriteLine("|");

            }
        }
        //enter the number of user in the place he choised
        public int EnterNumber(int place, int number)
        {
            for (int i = matBord.GetLength(0) - 1; i >= 0; i--)
            {
                if (matBord[i, place - 1] == 0)
                {
                    matBord[i, place - 1] = number;
                    return i;
                }
            }
            return -1;//never return this value there is already a check uf there is place in this column
        }
        //chack if all bord is full without a win
        public bool GameOver()
        {
            for (int i = 0; i < matBord.GetLength(1); i++)
            {
                if (matBord[0, i] == 0)
                    return false;
            }
            Console.WriteLine("GAME OVER!!!!");
            return true;
        }
        public bool ChakWin(int row, int column, Gamer player,Bord bord)
        {
            //check row
            for (int i = 0; i <4; i++)
            {
                if (matBord[row,i]!=0&& matBord[row, i] == matBord[row, i + 1] && matBord[row, i + 2] == matBord[row, i + 3] && matBord[row, i + 2] == matBord[row, i + 1])
                {
                    bord.print();
                    Console.WriteLine("Bravo {0} you win ",player.Name);
                    return true;
                }
            }
            //check column
            for(int i = 0; i < 3; i++)
            {
                if (matBord[i,column]!=0&& matBord[i, column] == matBord[i + 1, column] && matBord[i, column] == matBord[i + 2, column] && matBord[i, column] == matBord[i + 3, column])
                {
                    bord.print();
                    Console.WriteLine("Bravo {0} you win ", player.Name);
                    return true;
                }
            }
            //check slant left to right 
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (matBord[i, j] != 0 && matBord[i, j] == matBord[i + 1, j + 1] && matBord[i, j] == matBord[i + 2, j + 2] && matBord[i, j] == matBord[i + 3, j + 3])
                    {
                        bord.print();
                        Console.WriteLine("Bravo {0} you win ", player.Name);
                        return true;
                    }
                }
            }
            //check slant right to left
            for(int i = 0; i < 3; i++)
            {
                for(int j = 6; j > 2; j--)
                {
                    if (matBord[i, j] != 0 && matBord[i, j] == matBord[i + 1, j - 1] && matBord[i, j] == matBord[i + 2, j - 2] && matBord[i, j] == matBord[i + 3, j - 3])
                    {
                        bord.print();
                        Console.WriteLine("Bravo {0} you win ", player.Name);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
