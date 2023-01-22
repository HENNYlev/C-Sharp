using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInRowGame
{
    internal class Gamer
    {
        private string name;
        private int numberInGame;
        public string Name { get { return name; } set { name = value;} }
        public int NumberInGame { get { return numberInGame; } set { numberInGame = value; } }
        public Gamer(string name,int numberInGame)
        {
            this.name = name;
            this.numberInGame = numberInGame;
        }
    }
}
