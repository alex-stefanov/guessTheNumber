using System;

namespace GuessTheNumber
{
    class guessTheNumber
    {
        static void Main(string[] args)
        {
            Random randomComputer = new Random();
            int computerMove = randomComputer.Next(1, 101);
            while (true)
            {
                Console.Write("Can you guess the number(1-100)?  ");
                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerMoveNumber);
                bool flag = false;
                string secondInput = "";
                if (isValid == true)
                {
                    if (playerMoveNumber == computerMove)
                    {
                        Console.WriteLine("Well done, you guessed the number correctly");
                        flag = true;
                    }
                    else if (playerMoveNumber > computerMove)
                    {
                        Console.WriteLine("Nice try, but your number is higher than your oppent's one");
                    }
                    else if (playerMoveNumber < computerMove)
                    {
                        Console.WriteLine("It was a good guess but your number is lower than your oppent's one");
                    }
                    if (flag == true)
                    {
                        Console.Write("Do you want to play another round? ");
                        flag = false;
                        secondInput = Console.ReadLine();
                        if(secondInput.ToLower()=="y" || secondInput.ToLower() == "yes")
                        {

                        }
                        else
                        {
                            Console.WriteLine("See you");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid imput, please try with something that is in the range of (1,100)");
                }
            }
           
        }
    }
}
