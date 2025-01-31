using System;
class NumberGuessing{
    static Random random = new Random();
    static int Guess(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    static string Feedback(int guess)
    {
        Console.WriteLine("Is your number " + guess + "? (Enter 'high', 'low', or 'correct')");
        return Console.ReadLine().ToLower();
    }

    static void PlayGame()
    {
        int min = 1, max = 100;
        int guess;
        string feedback;

        Console.WriteLine("Think of a number between 1 and 100");

        do
        {
            guess = Guess(min, max);
            feedback =  Feedback(guess);

            if (feedback == "high")
            {
                max = guess - 1;
            }
            else if (feedback == "low")
            {
                min = guess + 1;
            }

        } while (feedback != "correct");

        Console.WriteLine("Yay! I guessed your number!");
    }
    static void Main(string[] args){
        PlayGame();
    }
}