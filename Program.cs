using System.Security.Cryptography.X509Certificates;

namespace NumbersGame
{
    internal class Program
    {

        static void Main(string[] args)
        {


            //Erik Abrahamsson NET25




            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");


            int lives = 4;



            Random random = new Random();           //genererar ett tal mellan 1-20
            int chosenNumber = random.Next(1, 20);

            while (true)

            {
                string guess = Console.ReadLine();  //användaren får välja ett tal
                int guessNum = int.Parse(guess);

                if (lives == 0)                     //kollar om användaren inte har liv kvar
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!!");

                    
                }
                else
                {
                    lives = GuessCheck(guessNum, chosenNumber, lives);

                }
            }

            static int GuessCheck(int guessNum, int chosenNumber, int lives)
            {
                if (guessNum < chosenNumber)                //jämför det gissade numret med det slumpade numret
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    lives--;

                }
                else if (guessNum > chosenNumber)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    lives--;

                }
                else
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    

                }

                return lives;
            }

        }


    }


}
