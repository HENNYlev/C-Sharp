using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInRowGame
{
    internal class Game
    {
        public void NewTurn(Bord bord, Gamer one,Gamer two, Gamer currentPlayer)
        {
            int row = 0,place=1;
            //first time in loop the 2 function will check on an empty place
            while (!bord.ChakWin(row, place - 1, currentPlayer,bord) && !bord.GameOver())
            {
                currentPlayer = currentPlayer.NumberInGame == one.NumberInGame ? two : one;
                Console.WriteLine("hi {0} it's your turn now", currentPlayer.Name);
                bord.print();
                Console.WriteLine("enter a place");
                 place = Convert.ToInt32(Console.ReadLine());
                while (place < 1 || place > 7)
                {
                    Console.WriteLine("this place is not valid, try another place");
                    place = Convert.ToInt32(Console.ReadLine());
                }
                while (!ChackPlace(place-1, bord))
                {
                    Console.WriteLine("this place is already full, choise another place");
                    place = Convert.ToInt32(Console.ReadLine());
                }
                row = bord.EnterNumber(place, currentPlayer.NumberInGame); 
            }
        }
        //chacks if the place to enter a number is empty
        public bool ChackPlace(int place, Bord bord)
        {
            if (bord.MatBord()[0, place] == 0)
                return true;
            return false;
        }
    }
}
