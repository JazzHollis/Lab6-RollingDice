using System;


namespace Lab6_RollingDice
{
    class Program
    {

        public static Random rnd = new Random();

        //Method Calling
        static void Main(string[] args)
        {
            Game();
        }

        //Method Calling
        static void Game()
        { 
           //Get response from user about beginning game
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (Y/N):");
            string play = Console.ReadLine();

            if (play.ToLower() == "n")
            {
               Console.WriteLine("Good Bye!");
               return;
            }


            //Ask user for number of sides and convert user selection to integer
            Console.WriteLine("How many sides should each die have?");
            string userInput = Console.ReadLine();
            int numSides = int.Parse(userInput);

            //Assigning and processesing dice numbers
            int diceOne = Roll(numSides + 1);
            int diceTwo = Roll(numSides + 1);

            //Results for dice
            Console.WriteLine("1st Number: " + diceOne);
            Console.WriteLine("2nd Number: " + diceTwo);
            

            if (diceOne == 1 && diceTwo == 1)
            {
                Console.WriteLine("You got snake eyes!");
            }
            else if (diceOne == 6 && diceTwo == 6)
            {
                Console.WriteLine("You got box cars!");
            }
            else if (diceOne + diceTwo == 7 || diceOne + diceTwo == 11)
            {
                Console.WriteLine("You got craps!");
            }

            //Play Again
            Console.WriteLine("Play again? (Y/N)");
            string playAgain= Console.ReadLine();

            if (playAgain.ToLower() != "y")
            {
                Console.WriteLine("Thanks for playing!");
                return;
            }
            else
            {
                Game();//continues the game
            }

        }
        //Method called to randomize numbers
        static int Roll(int numSides)
        {

            int num = rnd.Next(1, numSides);
            return num;




        }
            

    }  

}



