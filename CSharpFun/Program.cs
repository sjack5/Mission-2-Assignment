using System;


namespace Mission2Assignment 
{
    public class Program   
    {
   
        public static void Main(string[] args)  
        {
            Random r = new Random();        //Allows us to use random number

            Console.WriteLine("How many times would you like to roll the dice?");

            string input = Console.ReadLine();      

            double numRolls = double.Parse(input);      //Takes user's input and casts it into a double variable so we can divide later

            double[] dice = new double[13];         //Make array of double variables
            
            for (int i = 0; i < numRolls; i++)      //Takes random number as dice roll and itterates the number of times that number is rolled in our array
            {
                int roll1 = r.Next(1, 7);
                int roll2 = r.Next(1, 7);
                int roll = roll1 + roll2;
                dice[roll] = ++dice[roll];
            }

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS \nEach * represents 1 % of the total number of rolls. \nTotal number of rolls = " + numRolls +".");

            for (int j = 2; j <= 12; j++)           //Divides number of times a number was rolled by the total number of rolls to get us 1%
            {                                       //Casts it to a whole number so we can print off full asterics
                double numChars = dice[j] / numRolls;
                int charsToPrint = (int)(numChars * 100);
                Console.WriteLine(j + ": " + new String('*', charsToPrint));
             
            }
            

        }
    }
}
