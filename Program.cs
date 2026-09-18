
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



GuessingGame game = new GuessingGame(); 
string continuePlaying= "";
while (continuePlaying != "n"){
game.StartGame();

if (game.difficulty >= 1 && game.difficulty <= 4)
{
            if (game.difficulty == 1)

        {
           GuessingGame.PlayEasyGame();
        }

        if (game.difficulty == 2)
        
        {
            GuessingGame.PlayMediumGame();
        }

        if (game.difficulty == 3)
        
        {
            GuessingGame.PlayHardGame();
        }


        if (game.difficulty == 4)
        {
         
         GuessingGame.PlayCustomGame();
}

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