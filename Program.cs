using System.Collections.Concurrent;

Console.Clear();

string continuePlaying = "";
while (continuePlaying != "n")
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

    bool success = int.TryParse(chooseDifficulty, out difficulty);

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
                Console.WriteLine("Hard Difficulty, your crazy for this one");
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

    if (chooseDifficulty == "1")
    {
        Console.Write("Please enter a Number between 1-10:");
        string easyNumber=Console.ReadLine();
        int attemptsEasy = 0;
        int easy = int.Parse(easyNumber);
        Random rnd = new Random();

        int easyMin = 1;
        int easyMax = 10;
        int easyRandomOne = rnd.Next(easyMin, easyMax);
        
        if (easy == easyRandomOne)
        {
            Console.WriteLine($"Congratulations, you guessed right in {attemptsEasy} tries!");
            attemptsEasy += 1
        }
        if (easy < easyRandomOne)
        {
            Console.WriteLine("Not quite, the true number is higher");
            attemptsEasy += 1;
        }
        if (easy > easyRandomOne)
           {
            Console.WriteLine("Not quite, the true number is lower");
            attemptsEasy += 1;
        }
        
    if (chooseDifficulty == "2")
    {
        Console.Write("Please enter a Number between 1-50:");
        string mediumNumber=Console.ReadLine();
        int attemptsMedium = 0;
        int medium = int.Parse(mediumNumber);
        Random rnd = new Random();

        int mediumMin = 1;
        int mediumMax = 50;
        int mediumRandomOne = rnd.Next(mediumMin, mediumMax);
        
        if (medium == mediumRandomOne)
        {
            Console.WriteLine($"Congratulations, you guessed right in {attemptsMedium} tries!");
            attemptsMedium += 1
        }
        if (medium < mediumRandomOne)
        {
            Console.WriteLine("Not quite, the true number is higher");
            attemptsMedium += 1;
        }
        if (medium > mediumRandomOne)
           {
            Console.WriteLine("Not quite, the true number is lower");
            attemptsMedium += 1;
        }
    }
    if (chooseDifficulty == "3")
    {
        Console.Write("Please enter a Number between 1-100:");
        string hardNumber =Console.ReadLine();
        int attemptsHard = 0;
        int hard = int.Parse(hardNumber);
        Random rnd = new Random();

        int hardMin = 1;
        int hardMax = 100;
        int hardRandomOne = rnd.Next(hardMin, hardMax);
        
        if (hard == hardRandomOne)
        {
            Console.WriteLine($"Congratulations, you guessed right in {attemptsHard} tries!");
            attemptsHard += 1
        }
        if (hard < hardRandomOne)
        {
            Console.WriteLine("Not quite, the true number is higher");
            attemptsHard += 1;
        }
        if (hard > hardRandomOne)
           {
            Console.WriteLine("Not quite, the true number is lower");
            attemptsHard += 1;
        }

    }

    if (chooseDifficulty == "4")
    {
        Console.Write("Please enter a Number of your choice for the lowest number:");
        string customNumber =Console.ReadLine();
        int customNum = int.Parse (customNumber);

        Console.Write("Please enter a Number of your choice for the largest number:");
        string customNumberOne =Console.ReadLine();
        int customNumOne = int.Parse (customNumberOne);
        int attemptsCustom = 0;

        Console.WriteLine($"You will need to guess a number between {customNum} and {customNumOne}. Please enter your guess");
        string customGuess = Console.ReadLine();
        int trueCustomGuess = int.Parse (customGuess);
    
        Random rnd = new Random();

        int customMin = customNum;
        int customMax = customNumOne;
        int customRandomOne = rnd.Next(customMin, customMax);
        
        if (trueCustomGuess == customRandomOne)
        {
            Console.WriteLine($"Congratulations, you guessed right in {attemptsCustom} tries!");
            attemptsCustom += 1
        }
        if (trueCustomGuess < customRandomOne)
        {
            Console.WriteLine("Not quite, the true number is higher");
            attemptsCustom += 1;
        }
        if (trueCustomGuess > customRandomOne)
           {
            Console.WriteLine("Not quite, the true number is lower");
            attemptsCustom += 1;
        }

    }







    do
    {
        Console.Write("Would you like to play again? (Y/N): ");
        continuePlaying = Console.ReadLine().ToLower();

        if (continuePlaying != "y" && continuePlaying != "n")
        {
            Console.WriteLine("That was not a valid input. Please enter Y or N.");
        }

    } while (continuePlaying != "y" && continuePlaying != "n");

}
}
