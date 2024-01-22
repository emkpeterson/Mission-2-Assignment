using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    internal class DiceRoll
    {
        // generate random numbers
        private Random random; 

        // create diceroll method
        public DiceRoll()
        {
            // initialize random field
            random = new Random();
        }

        public int[] SimulateRolls(int numRolls)
        {
            // 2 through 12 as possible outcomes
            int[] results = new int[13];

            for (int i = 0; i < numRolls; i++) 
            {
                //simulate the dice roll for 2 separate die, 1-6
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                // gather the sum of the dice roll 
                int sum = dice1 + dice2;

                // add the result to the array results
                results[sum]++;
            }

            // add return statement
            return results;
        }
    }

}
