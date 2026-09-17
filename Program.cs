
//Chris Estrada
//9-16-26
//Assignment Challenge 2- Guess it!
//What you did- wrote a program that asks the user to choose a difficulty setting and follow the
// game logic until the end guessing the secret number within the set difficulty's parameters. Validation checks were added to make sure
// each input is a valid number, that it was in the parameters, and kik out a message if the user tries to input anything else
// Finally the game asks if you want to play again.
//Peer Review: Valery Lot
//Review: Code works as intended. However, Medium mode still prompts users to enter a number between 1-10. Had validation on all parts and asked used to play again. 

Console.Clear();

string continuePlaying = "";
while (continuePlaying != "n")// encompasses entire game to start back here once user enters "y" to play again
{
    Console.WriteLine("Welcome to Guess it, the game where you have to guess the correct number.");
    Console.WriteLine("The difficulty modes are:");
    Console.WriteLine("1. Easy (Numbers to guess are between 1-10)");
    Console.WriteLine("2. Medium (Numbers to guess are between 1-50)");
    Console.WriteLine("3. Hard (Numbers to guess are between 1-100)");
    Console.WriteLine("4. Custom (Numbers to guess are between two numbers of your choosing)");
    Console.Write("Please choose a difficulty mode (1-4):");

    string chooseDifficulty = Console.ReadLine();

    int difficulty;

    bool success = int.TryParse(chooseDifficulty, out difficulty);// start of switch to pick between multiple difficulty settings

    if (success)
    {
        switch (difficulty)
        {
            case 1:
                Console.WriteLine("Easy Difficulty, have fun!");
                break;
            case 2:
                Console.WriteLine("Medium Difficulty, good luck!");
                break;
            case 3:
                Console.WriteLine("Hard Difficulty, you're crazy for this one");
                break;
            case 4:
                Console.WriteLine("Custom Difficulty, you do you!");
                break;
            default:

                Console.WriteLine("That was not a valid selection");

                break;

        }
    }

    else
    {
        Console.WriteLine("Please enter a number between 1-4.");

    }

    if (difficulty >= 1 && difficulty <= 4)// validation to make sure 1-4 is selected to continue
    {

        if (chooseDifficulty == "1")

        {
            GuessIt.PlayEasyGame();
        }

        if (chooseDifficulty == "2")

        {
            GuessIt.PlayMediumGame();
        }

        if (chooseDifficulty == "3")

        {
            GuessIt.PlayHardGame();
        }


        if (chooseDifficulty == "4")
        {

            GuessIt.PlayCustomGame();
        }

        do
        {
            Console.Write("Would you like to play again? (Y/N): ");// code to prompt player to continue
            continuePlaying = Console.ReadLine().ToLower();

            if (continuePlaying != "y" && continuePlaying != "n")
            {
                Console.WriteLine("That was not a valid input. Please enter Y or N.");
            }

        } while (continuePlaying != "y" && continuePlaying != "n");
    }
}


