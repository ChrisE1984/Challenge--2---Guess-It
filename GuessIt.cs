
public static class GuessIt
{
    public static void PlayEasyGame()
    {
        int minimumNumber = 1;
        int maximumNumber = 10;

        Random rnd = new Random();
        int targetNumber = rnd.Next(minimumNumber, maximumNumber + 1);
        int attempts = 0;
        int guess;

        Console.WriteLine("Guess a number between 1 and 10.");

        do
        {
            Console.Write("Enter your guess: ");
            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out guess))
            {
                Console.WriteLine("That is not a valid number. Please enter a whole number.");
                continue;
            }

            if (guess < minimumNumber || guess > maximumNumber)
            {
                Console.WriteLine("Please enter a number between 1 and 10.");
                continue;
            }

            attempts++;

            if (guess == targetNumber)
            {
                Console.WriteLine($"Congratulations! You guessed correctly in {attempts} attempt(s).");
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Not quite. The correct number is higher.");
            }
            else
            {
                Console.WriteLine("Not quite. The correct number is lower.");
            }

        } while (guess != targetNumber);
    }
    public static void PlayMediumGame()
    {
        int minimumNumber = 1;
        int maximumNumber = 50;

        Random rnd = new Random();
        int targetNumber = rnd.Next(minimumNumber, maximumNumber + 1);
        int attempts = 0;
        int guess;

        Console.WriteLine("Guess a number between 1 and 50.");

        do
        {
            Console.Write("Enter your guess: ");
            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out guess))
            {
                Console.WriteLine("That is not a valid number. Please enter a whole number.");
                continue;
            }

            if (guess < minimumNumber || guess > maximumNumber)
            {
                Console.WriteLine("Please enter a number between 1 and 50.");
                continue;
            }

            attempts++;

            if (guess == targetNumber)
            {
                Console.WriteLine($"Congratulations! You guessed correctly in {attempts} attempt(s).");
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Not quite. The correct number is higher.");
            }
            else
            {
                Console.WriteLine("Not quite. The correct number is lower.");
            }

        } while (guess != targetNumber);
    }
        public static void PlayHardGame()
    {
        int minimumNumber = 1;
        int maximumNumber = 100;

        Random rnd = new Random();
        int targetNumber = rnd.Next(minimumNumber, maximumNumber + 1);
        int attempts = 0;
        int guess;

        Console.WriteLine("Guess a number between 1 and 100.");

        do
        {
            Console.Write("Enter your guess: ");
            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out guess))
            {
                Console.WriteLine("That is not a valid number. Please enter a whole number.");
                continue;
            }

            if (guess < minimumNumber || guess > maximumNumber)
            {
                Console.WriteLine("Please enter a number between 1 and 50.");
                continue;
            }

            attempts++;

            if (guess == targetNumber)
            {
                Console.WriteLine($"Congratulations! You guessed correctly in {attempts} attempt(s).");
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Not quite. The correct number is higher.");
            }
            else
            {
                Console.WriteLine("Not quite. The correct number is lower.");
            }

        } while (guess != targetNumber);
    }

         public static void PlayCustomGame()
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
        int minimumNumber = customNum;
        int maximumNumber = customNumOne;

        Random rnd = new Random();
        int targetNumber = rnd.Next(minimumNumber, maximumNumber + 1);
        int attempts = 0;
        int guess;

        Console.WriteLine($"Guess a number between {customNum} and {customNumOne}.");

        do
        {
            Console.Write("Enter your guess: ");
            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out guess))
            {
                Console.WriteLine("That is not a valid number. Please enter a whole number.");
                continue;
            }

            if (guess < minimumNumber || guess > maximumNumber)
            {
                 Console.WriteLine($"Please enter a number between {customNum} and {customNumOne}.");
                continue;
            }

            attempts++;

            if (guess == targetNumber)
            {
                Console.WriteLine($"Congratulations! You guessed correctly in {attempts} attempt(s).");
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Not quite. The correct number is higher.");
            }
            else
            {
                Console.WriteLine("Not quite. The correct number is lower.");
            }

        } while (guess != targetNumber);
    }
}