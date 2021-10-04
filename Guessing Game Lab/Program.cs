using System;

namespace Guessing_Game_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num = rand.Next(0, 100);
            bool guess = false;
            int guessNum;
            int counter = 0;
            while (guess != true)
            {
                Console.WriteLine("Guess the number. The limit is 100.");
                guessNum = Convert.ToInt32(Console.ReadLine());
                counter++;
                if (guessNum == num)
                {
                    guess = true;
                } 
                else if (guessNum != num)
                {
                    Console.WriteLine("Sorry, that's not the right number. Try again.");
                }
                else if (guessNum > 100)
                {
                    Console.WriteLine("Please guess a number 100 or below.");
                    counter--;
                }
            }
            Console.WriteLine("Congratulations, you guessed the right number!");
            Console.WriteLine("It took you " + counter + " guesses to get the correct answer.");
        }
    }
}
