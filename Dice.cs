//IS 413 - Mission 2, Dice Rolling Simulator
//By Jacob McGuire, Section 002

//Explain what classes are being used
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create the namespace
namespace IS_413___Mission__2
{
    //Create the class
    internal class Dice
    {
        //Create the method that uses input 'roll'. This is drawn from the user input in Program.cs
        public int[] DiceRoll(int roll)
        {
            //create an array to hold all values of the dice rolls
            int[] values = new int[roll];
            //Use the random class to generate random numbers
            Random randRoll = new Random();

            //Roll two dice per each roll (from the user input), then add the values of the dice together
            for (int counter = 0; counter < roll; counter++)
            {
                int dice1 = randRoll.Next(1, 7);
                int dice2 = randRoll.Next(1, 7);
                int total = dice1 + dice2;
                //Store the values of the dice rolls into an array that will be used in the Program.cs file
                values[counter] = total;
            }

            return values;
        }
    }
}