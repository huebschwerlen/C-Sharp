using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneFinal
{
    public class TwentyOneRules
    {//naming convention to use a '_' before name of Private methods
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };


        private static int[] GetAllPossibleValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]); //lambda
            result[0] = value;
            if (result.Length == 1) return result; //if it's one line we dont need curly braces on if statement
            for (int i = 1 ; i < result.Length; i++)
            {
                value += (i * 10); //same as, value = value + (i * 10);
                result[i] = value;
            }
            return result;
        }


        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValue = GetAllPossibleValues(Hand);
            foreach(int value in possibleHandValue)
            {
                if(value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleValues(PlayerHand);
            int[] dealerResults = GetAllPossibleValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();//filter values for anything under 22 and give us the Max or highest value
            int dealerScore = playerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
