using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {


        static void Main(string[] args)
        {
 
            Console.WriteLine();
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine();
            Console.WriteLine("Please enter your name");

            User user = new User("");

            Rockman rockman = new Rockman("Rockman");
            RandoCalrissian rando = new RandoCalrissian("Rando Calrissian");

            Console.WriteLine($"Hello {user}");
            Console.WriteLine($"Which opponent would you like to challenge {rockman} or {rando}?");
            Console.WriteLine("For Rockman type rockman , for Rando Calrissian type Rando");
            string Opponent = Console.ReadLine().ToLower();

            if (Opponent == "rockman")
            {
                bool PlayRPS = true;
                bool PlayAgain = true;
                while(PlayAgain)
                {
                    while (PlayRPS)
                    {
                        Console.WriteLine("Please choose Rock,Paper, or Scissor");
                        Console.Write($"{user} chooses: ");
                        user.GenerateRoshambo();

                        try
                        {
                            if (user.GenerateRoshambo() == Roshambo.rock && rockman.GenerateRoshambo() == Roshambo.rock)
                            {
                                Console.WriteLine($"{rockman}: rock");
                                Console.WriteLine("It was a tie");
                                PlayRPS = false;
                            }
                            else if (user.GenerateRoshambo() == Roshambo.paper)
                            {
                                Console.WriteLine("You win!");
                                PlayRPS = false;
                            }
                            else if (user.GenerateRoshambo() == Roshambo.scissor)
                            {
                                Console.WriteLine("You lose!");
                                PlayRPS = false;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("That is not a choice");
                            PlayRPS = true;
                        }
                    }
                    bool Invalid = true;
                    while (Invalid)
                    {
                        Console.WriteLine("Would you like to play again? (y/n)");
                        string GoAgain = Console.ReadLine().ToLower();
                        if (GoAgain == "y")
                        {
                            PlayAgain = true;
                            Invalid = false;
                           
                        }
                        else if (GoAgain == "n")
                        {
                            Invalid = false;
                            PlayAgain = false;
                        }
                        else
                        {
                            Console.WriteLine("That was not a choice");
                            Invalid = true;
                        }
                    }
                }
            }
            else if (Opponent == "rando")
            {
                
                bool PlayRPS = true;
                bool PlayAgain = true;
                while (PlayAgain)
                {
                    while (PlayRPS)
                    {
                        Console.WriteLine("Please choose Rock,Paper, or Scissor");
                        Console.Write($"{user} chooses: ");
                        user.GenerateRoshambo();
                        Console.WriteLine(rando.GenerateRoshambo());
                        try
                        {
                            if (user.GenerateRoshambo() == Roshambo.rock && rando.GenerateRoshambo() == Roshambo.rock)
                            {
                                Console.WriteLine($"{rando}: rock");
                                Console.WriteLine("It was a tie");
                                PlayRPS = false;
                            }
                            else if (user.GenerateRoshambo() == Roshambo.paper && rando.GenerateRoshambo() == Roshambo.paper)
                            {
                                Console.WriteLine("It was a tie!");
                                PlayRPS = false;
                            }
                            else if (user.GenerateRoshambo() == Roshambo.rock && rando.GenerateRoshambo() == Roshambo.scissor)
                            {
                                Console.WriteLine("You win!");
                                PlayRPS = false;
                            }
                            else if (user.GenerateRoshambo() == Roshambo.paper && rando.GenerateRoshambo() == Roshambo.rock)
                            {
                                Console.WriteLine("You win!");
                                PlayRPS = false;
                            }
                            else if (user.GenerateRoshambo() == Roshambo.scissor && rando.GenerateRoshambo() == Roshambo.paper)
                            {
                                Console.WriteLine("You win!");
                                PlayRPS = false;
                            }
                            else if (user.GenerateRoshambo() == Roshambo.scissor && rando.GenerateRoshambo() == Roshambo.rock)
                            {
                                Console.WriteLine("You win!");
                                PlayRPS = false;
                            }
                            else if (user.GenerateRoshambo() == Roshambo.rock && rando.GenerateRoshambo() == Roshambo.paper)
                            {
                                Console.WriteLine("You win!");
                                PlayRPS = false;
                            }
                            else if (user.GenerateRoshambo() == Roshambo.paper && rando.GenerateRoshambo() == Roshambo.scissor)
                            {
                                Console.WriteLine("You win!");
                                PlayRPS = false;
                            }
                        }
                        catch (Exception)
                        {

                            PlayRPS = true;
                        }
                    }
                        bool Invalid = true;
                        while (Invalid)
                        {
                            Console.WriteLine("Would you like to play again? (y/n)");
                            string GoAgain = Console.ReadLine().ToLower();
                            if (GoAgain == "y")
                            {
                                Invalid = false;
                                PlayAgain = true;
                            }
                            else if (GoAgain == "n")
                            {
                                Invalid = false;
                                PlayAgain = false;
                            }
                            else
                            {
                                Console.WriteLine("That was not a choice");
                                Invalid = true;
                            } 
                        }
                    }

                }
            
            Console.WriteLine("Thanks for playing!");
        }
    }
}



    


    

    

