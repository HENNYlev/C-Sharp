using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInRowGame
{
    internal class Program
    {
        public static Gamer gamer()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your number");
            var number = Console.ReadLine();
            int num;
            while (!int.TryParse(number, out num))
            {
                Console.WriteLine("This is not a number!");
                number = Console.ReadLine();
            }
            return new Gamer(name,num);
        }
        static void Main(string[] args)
        
        
        {
            Gamer gamer1 = gamer();
            Gamer gamer2 =gamer();
            Bord bord = new Bord();
            Game game=new Game();
            game.NewTurn(bord,gamer1,gamer2,gamer2);
            Console.Read();
        }
    }
}
