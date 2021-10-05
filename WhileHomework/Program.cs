using System;

namespace WhileLoop_homework
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true) 
            { 
            Random numGen = new Random();
            int guessMe;
            guessMe = numGen.Next(1, 101);
            int userGuess = -1;
            int guessCount = 0;

           // Console.WriteLine("{0}", guessMe);
            while (userGuess != guessMe)
            {


                while (userGuess < 0 || userGuess > 100)
                {
                    Console.WriteLine("Guess the number between 1 and 100");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    if (userGuess < 0 || userGuess > 100)
                    {
                        Console.WriteLine("That input is incorrect");
                    }
                }



                if (userGuess != guessMe)
                {
                    Console.WriteLine("Sorry, try again!");
                    guessCount = guessCount + 1;
                    Console.WriteLine("You have made {0} attempts", guessCount);
                    

                        if (userGuess > guessMe)
                        {
                            Console.WriteLine("Your guess was too high, try again");
                        }

                        else
                        {
                            Console.WriteLine("Your guess was too low");
                        }
                        userGuess = -1;
                    }

                else
                {
                    guessCount = guessCount + 1;
                    Console.WriteLine("Yes that's correct!, it took you {0} attempts", guessCount);
                }






                //if (userGuess < 0 || userGuess > 100)
                //  {
                //     Console.WriteLine("Please enter between 1 and 100");
                //  }


            }

            }

        }
    }
}