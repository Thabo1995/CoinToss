using System;

public class CoinTossing
{

        // initialize variables in declarations
        int result;
        Random randomNumbers; // random number generator
        const int NUMBER_OF_SIDES = 2; // constant number of Card
        string[] coinfaces = { "Heads", "Tails" };
    

        public void CoinTossCalculate() 
        {
        int coinHead = 0;
        int coinTails = 0;
        randomNumbers = new Random(); // create random number generator

        // prompt user for input to toss coin or not
        Console.Write("Toss coin? (1 = yes, 2 = no): ");
        result = Convert.ToInt32(Console.ReadLine());

        // if...else nested in while 
        while (result == 1) // if result 1,
        {
            int second = randomNumbers.Next(NUMBER_OF_SIDES);
            if (second == 1)
            {
                Console.WriteLine("HEADS it is!\n");
                coinHead += 1;
                Console.WriteLine("Heads\ttotal count: {0}", coinHead);
                Console.WriteLine("Tails\ttotal count: {0}", coinTails);
            }
            else
            {
                Console.WriteLine("TAILS it is!\n");
                coinTails += 1;
                Console.WriteLine("Heads\ttotal count: {0}", coinHead);
                Console.WriteLine("Tails\ttotal count: {0}", coinTails);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Toss coin? (1 = yess, 2 = no): ");
            result = Convert.ToInt32(Console.ReadLine());
        }

        // result is not 1, so
        Console.WriteLine("Game Over!");

        } //end of CoinTossCalculate
    

}