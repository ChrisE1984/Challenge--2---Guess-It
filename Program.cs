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

    {   Random rndEasy = new Random();

        int easyMin = 1;
        int easyMax = 11;
        int easyRandomOne = rndEasy.Next(easyMin, easyMax);
        int attemptsEasy = 0;
        int easy;

       do{

        Console.Write("Please enter a Number between 1-10:");
        string easyNumber=Console.ReadLine();
        easy = int.Parse(easyNumber);
        attemptsEasy++;
        
        if (easy == easyRandomOne)
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
    }while (easy != easyRandomOne);
    }
        
    if (chooseDifficulty == "2")
    {
        Random rndMedium = new Random();

        int mediumMin = 1;
        int mediumMax = 51;
        int mediumRandomOne = rndMedium.Next(mediumMin, mediumMax);
        int attemptsMedium = 0;
        int medium;

        do{

        Console.Write("Please enter a Number between 1-50:");
        string mediumNumber=Console.ReadLine();
        medium = int.Parse(mediumNumber);
        attemptsMedium ++;

        if (medium == mediumRandomOne)
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
        }while (medium != mediumRandomOne);
    }
    if (chooseDifficulty == "3")
    {

        Random rndHard = new Random();

        int hardMin = 1;
        int hardMax = 101;
        int hardRandomOne = rndHard.Next(hardMin, hardMax);
        int attemptsHard = 0;
        int hard;

        do{

        Console.Write("Please enter a Number between 1-100:");
        string hardNumber =Console.ReadLine();
        hard = int.Parse(hardNumber);
        attemptsHard++;
        
        if (hard == hardRandomOne)
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

    }while (hard != hardRandomOne);
    }
    if (chooseDifficulty == "4")
    {
        Console.Write("Please enter a Number of your choice for the lowest number:");
        string customNumber = Console.ReadLine();
        int customNum = int.Parse (customNumber);

        Console.Write("Please enter a Number of your choice for the largest number:");
        string customNumberOne = Console.ReadLine();
        int customNumOne = int.Parse (customNumberOne);

        Random rndCustom = new Random();

        int customMin = customNum;
        int customMax = customNumOne;
        int customRandomOne = rndCustom.Next(customMin, customMax);
        int attemptsCustom = 0;
        int trueGuess;

        do
        {

        Console.WriteLine($"You will need to guess a number between {customNum} and {customNumOne}. Please enter your guess");
        string customGuess = Console.ReadLine();
        trueGuess = int.Parse (customGuess);
        attemptsCustom++;

        if (trueGuess == customRandomOne)
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

    }while (trueGuess != customRandomOne);  







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



