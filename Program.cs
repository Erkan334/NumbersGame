using System.Security.Cryptography.X509Certificates;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            int lives = 4;

            Random random = new Random();
            int chosenNumber = random.Next(1, 20);            

            while (true)
            
            {
                string guess = Console.ReadLine();
                int guessNum = int.Parse(guess);

                if (lives == 0)
                {
                    Console.WriteLine("Du DOG!");
                    break;
                }
                else
                {
                    if (guessNum < chosenNumber)
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


                }


                

               
            }

            


            //if (guessNum == chosenNumber)
            //{
            //    Console.WriteLine("Rätt");
            //}
            //else 
            //{
            //    Console.WriteLine("Fel");
            //}

        }

        //public static int[] CreateNumbers()
        //{
        //    var random = new Random(5);
        //    var chosenNumber = new int[3];

        //    for (int i = 0; i < 3; i++)
        //    {
        //        chosenNumber[i] = random.Next(1, 21);
        //    }

        //    return chosenNumber;
        



    }


}
