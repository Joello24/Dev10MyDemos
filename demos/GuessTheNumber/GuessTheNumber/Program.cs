using System;
using System.Collections.Generic;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // I have a dog named Spot
            Dog spot = new Dog("Spot");
            Dog rover = new Dog("Rover");
            Cat fluffy = new Cat("Fluffy");
            
            List<IPet> pets = new List<IPet>();
            pets.Add(spot);
            pets.Add(rover);
            pets.Add(fluffy);

            foreach (IPet pet in pets)
            {
                pet.Speak();
            }

            /* Console.WriteLine("Welcome to Guess The Number!");
             bool playing = true;

             while (playing)
             {
                 int target = GenerateRandomNumber(100);
                 PlayGame(target);
                 playing = AskForAnotherGame();
             }*/


        }

        static bool AskForAnotherGame()
        {
            Console.Write("Play again? ");
            string resp = Console.ReadLine();
            if (resp.Trim().ToUpper() != "Y")
            {
                return false;
            } else
            {
                return true;
            }
        }

        static int GenerateRandomNumber(int maxNum) 
        {
            Random rng = new Random();
            return rng.Next(1, maxNum + 1);
        }

        static void PlayGame(int tgtNumber)
        {
            int guessCount = 0;
            bool win = false;
            while (!win)
            {
                int guess = CollectAGuess();
                guessCount = guessCount + 1;

                if (guess == tgtNumber) { 
                    win = true;
                    Console.WriteLine($"You got it! And in only {guessCount} guesses, you smarty!");
                }
                else if (guess > tgtNumber)
                {
                    Console.WriteLine("You're too high!");
                }
                else
                {
                    Console.WriteLine("You're too low!");
                }
            }
        }

        static int CollectAGuess()
        {
            int result = -1;

            Console.Write("Enter a guess: ");
            string input = Console.ReadLine();
            result = int.Parse(input);

            return result;
        }

    }
}
