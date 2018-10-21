using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneFinal
{
    public class Player
    {
        //constructor w/ 2 params or args that assign vals to props of this class
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>(); //initialize list to add to it
            Balance = beginningBalance;
            Name = name;
        }

        //properties
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        //methods
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enought to make a bet of that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public static Game operator +(Game game, Player player)//overloading operator to add player
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator -(Game game, Player player)//overloading operator to subtract player
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
