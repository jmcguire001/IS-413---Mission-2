//IS 413 - Mission #2, Dice Rolling Simulator
//By Jacob McGuire, Section 002

//Declare the namespace
using IS_413___Mission__2;

//Create the class
internal class Program
{
    //Create the main method
    private static void Main(string[] args)
    {
        do
        {
            //Create new instance of the Dice class
            Dice diceRoll = new Dice();
            //Create the variable to hold the number of rolls
            string numRollsInput = "";
            int numRolls = 0;
            //Create the array to keep track of the histogram
            string[] stats = new string[11];
            //Set the stats array so that you can see the proper histogram data
            stats[0] = " 2: ";
            stats[1] = " 3: ";
            stats[2] = " 4: ";
            stats[3] = " 5: ";
            stats[4] = " 6: ";
            stats[5] = " 7: ";
            stats[6] = " 8: ";
            stats[7] = " 9: ";
            stats[8] = "10: ";
            stats[9] = "11: ";
            stats[10] = "12: ";
            //Create an int array to hold the counts of each roll
            int[] counts = new int[11];
            counts[0] = 0;
            counts[1] = 0;
            counts[2] = 0;
            counts[3] = 0;
            counts[4] = 0;
            counts[5] = 0;
            counts[6] = 0;
            counts[7] = 0;
            counts[8] = 0;
            counts[9] = 0;
            counts[10] = 0;

            //Display the welcome message
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            //Collect user input
            numRollsInput = Console.ReadLine();

            if (int.TryParse(numRollsInput, out int number))
            {
                //Convert the user input to an integer
                numRolls = Convert.ToInt32(numRollsInput);

                if (numRolls > 0)
                {
                    //Create an int array to hold the values of the returned DiceRoll array
                    int[] diceValues = diceRoll.DiceRoll(numRolls);

                    //Calculate the counts of each roll by iterating by 1
                    foreach (int value in diceValues)
                    {
                        if (value == 2)
                        {
                            counts[0]++;
                        }
                        else if (value == 3)
                        {
                            counts[1]++;
                        }
                        else if (value == 4)
                        {
                            counts[2]++;
                        }
                        else if (value == 5)
                        {
                            counts[3]++;
                        }
                        else if (value == 6)
                        {
                            counts[4]++;
                        }
                        else if (value == 7)
                        {
                            counts[5]++;
                        }
                        else if (value == 8)
                        {
                            counts[6]++;
                        }
                        else if (value == 9)
                        {
                            counts[7]++;
                        }
                        else if (value == 10)
                        {
                            counts[8]++;
                        }
                        else if (value == 11)
                        {
                            counts[9]++;
                        }
                        else if (value == 12)
                        {
                            counts[10]++;
                        }
                    }

                    //Create a FOR loop to display percentages, rounded down (int default)
                    for (int counter = 0; counter < counts.Length; counter++)
                    {
                        //Calculate the percentage of counts of each roll
                        int percent = (counts[counter] * 100) / numRolls;
                        //Add an asterisk for each percent
                        stats[counter] += new string('*', percent);
                    }

                    //Display splash screen for explanation of histogram
                    Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
                    Console.WriteLine("Each '*' represents 1% of the total rolls");
                    Console.WriteLine("Total number of rolls: " + numRolls.ToString() + "\n");

                    //Print the histogram
                    foreach (string value in stats)
                    {
                        Console.WriteLine(value);
                    }
                }
                else
                {
                    //Display error message if user entered number of rolls less than 1
                    Console.WriteLine("Invalid input. Please enter a number greater than 0.");
                }
            }
            else
            {
                //Display error if user entered non-numeric input
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            //Create a screen to ask if user wants to roll again
            Console.WriteLine("\nWould you like to roll again? (Y/N) ");
            //Collect user input
            string answer = Console.ReadLine();

            //If user doesn't want to roll again, display message and end loop
            if (answer.ToLower() != "y")
            {
                Console.WriteLine("\nThanks for playing!");
                break;
            }

            //Add  whitespace between rolls
            Console.WriteLine();
        } while (true); //Exit if user doesn't type 'y'
    }
}