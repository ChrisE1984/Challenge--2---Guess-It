
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
            Random rndEasy = new Random();

            int easyMin = 1;
            int easyMax = 11;
            int easyRandomOne = rndEasy.Next(easyMin, easyMax);//random number generator for this difficulty
            int attemptsEasy = 0;
            int easy;

            do
            {

                bool validEasyInput = false;// int validator boolean to loop until player enters a number between parameters

                do
                {
                    Console.WriteLine("Please enter a number between 1-10:");
                    string easyNumber = Console.ReadLine();

                    if (int.TryParse(easyNumber, out easy))
                    {
                        validEasyInput = true;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number. Please try again.");
                        validEasyInput = false;
                    }
                } while (validEasyInput == false);
                attemptsEasy++;

                if (easy > 10 || easy < 1)// game code to show it the user entered a number in the parameter and if right or not
                {
                    Console.WriteLine("You did not enter a number between 1-10, Please try again");
                }
                else if (easy == easyRandomOne)
                {
                    Console.WriteLine($"Congratulations, you guessed right in {attemptsEasy} tries!");

                }
                else if (easy < easyRandomOne)
                {
                    Console.WriteLine("Not quite, the true number is higher");

                }
                else
                {
                    Console.WriteLine("Not quite, the true number is lower");

                }
            } while (easy != easyRandomOne);
        }

        if (chooseDifficulty == "2")
        {
            Random rndMedium = new Random();

            int mediumMin = 1;
            int mediumMax = 51;
            int mediumRandomOne = rndMedium.Next(mediumMin, mediumMax);//random number generator for this difficulty
            int attemptsMedium = 0;
            int medium;

            do
            {


                bool validMediumInput = false;// int validator boolean to loop until player enters a number between parameters

                do
                {
                    Console.WriteLine("Please enter a number between 1-10:");
                    string mediumNumber = Console.ReadLine();

                    if (int.TryParse(mediumNumber, out medium))
                    {
                        validMediumInput = true;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number. Please try again.");
                        validMediumInput = false;
                    }
                } while (validMediumInput == false);
                attemptsMedium++;

                if (medium > 50 || medium < 1)// game code to show it the user entered a number in the parameter and if right or not
                {
                    Console.WriteLine("You did not enter a number between 1-50, Please try again");
                }

                else if (medium == mediumRandomOne)
                {
                    Console.WriteLine($"Congratulations, you guessed right in {attemptsMedium} tries!");
                }

                else if (medium < mediumRandomOne)
                {
                    Console.WriteLine("Not quite, the true number is higher");

                }
                else
                {
                    Console.WriteLine("Not quite, the true number is lower");

                }
            } while (medium != mediumRandomOne);
        }
        if (chooseDifficulty == "3")
        {

            Random rndHard = new Random();

            int hardMin = 1;
            int hardMax = 101;
            int hardRandomOne = rndHard.Next(hardMin, hardMax);//random number generator for this difficulty
            int attemptsHard = 0;
            int hard;

            do
            {
                bool validHardInput = false;// int validator boolean to loop until player enters a number between parameters

                do
                {
                    Console.Write("Please enter a Number between 1-100:");
                    string hardNumber = Console.ReadLine();
                    if (int.TryParse(hardNumber, out hard))
                    {
                        validHardInput = true;
                    }
                    else
                    {
                         Console.WriteLine("That is not a valid number. Please try again.");
                        validHardInput = false;

                    }
                } while (validHardInput == false);
                attemptsHard++;

                if (hard > 100 || hard < 1)// game code to show it the user entered a number in the parameter and if right or not
                {
                    Console.WriteLine("You did not enter a number between 1-100, Please try again");
                }

                else if (hard == hardRandomOne)
                {
                    Console.WriteLine($"Congratulations, you guessed right in {attemptsHard} tries!");

                }
                else if (hard < hardRandomOne)
                {
                    Console.WriteLine("Not quite, the true number is higher");

                }
                else
                {
                    Console.WriteLine("Not quite, the true number is lower");

                }

            } while (hard != hardRandomOne);
        }


        if (chooseDifficulty == "4")
        {
        int customNum = 0;

        bool validCustomNumber = false;
        do
            {
                Console.WriteLine("Please enter the lowest number:");
                string customNumber = Console.ReadLine();

                if (int.TryParse(customNumber, out customNum))
                {
                    validCustomNumber =true;
                }
                else
                {
                    Console.WriteLine("Please enter numbers only.");
                    
                }
            }while (validCustomNumber == false);
          
          int customNumOne = 0;

        bool validCustomNumberOne = false;
        
        do
            {
                Console.WriteLine("Please enter the highest number:");
                string customNumberOne = Console.ReadLine();

                if (int.TryParse(customNumberOne, out customNumOne))
                {
                    validCustomNumberOne =true;
                }
                else
                {
                    Console.WriteLine("Please enter numbers only.");
                    
                }
            }while (validCustomNumberOne == false);

            Random rndCustom = new Random();

            int customMin = customNum;
            int customMax = customNumOne;
            int customRandomOne = rndCustom.Next(customMin, customMax);
            int attemptsCustom = 0;
            int trueGuess;

            do
            {

                bool validCustomInput = false;// int validator boolean to loop until player enters a number between parameters
                do
                {
                    Console.Write($"You will need to guess a number between {customNum}-{customNumOne}. Please enter your guess:");
                    string customGuess = Console.ReadLine();
                    if (int.TryParse(customGuess, out trueGuess))
                    {
                        validCustomInput = true;
                    }
                    else
                    {
                         Console.WriteLine("That is not a valid number. Please try again.");
                        validCustomInput = false;

                    }
                } while (!validCustomInput);
                attemptsCustom++;

                if (trueGuess > customNumOne || trueGuess < customNum)// game code to show it the user entered a number in the parameter and if right or not
                {
                    Console.WriteLine($"You did not enter a number between {customNum}-{customNumOne}, Please try again");
                }

                else if (trueGuess == customRandomOne)
                {
                    Console.WriteLine($"Congratulations, you guessed right in {attemptsCustom} tries!");

                }
                else if (trueGuess < customRandomOne)
                {
                    Console.WriteLine("Not quite, the true number is higher");

                }
                else
                {
                    Console.WriteLine("Not quite, the true number is lower");

                }

            } while (trueGuess != customRandomOne);









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


