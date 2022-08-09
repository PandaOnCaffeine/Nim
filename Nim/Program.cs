namespace Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //alot of different data types for later use in the code
            int Matches = 7;
            bool gameDone = false;
            Random rng = new Random();
            int input = 0;
            int turn = 0;
            bool validPlay = false;
            string outputText = "";

            //a while loop to keep the game running
            while (gameDone != true)
            {
                //resets the bool valid play so it can run again
                validPlay = false;
                Console.WriteLine($"Der er {Matches} tændstikker tilbage\r\n");
                //uses modulus to check whos turn it is
                if (turn %2 == 0)
                {
                    //players turn
                    //a lot of ifs to check the input and check that it an allowed play
                    Console.WriteLine("Skriv hvor mange tænderstikker du vil samle op (som et tal)");
                    input = int.Parse(Console.ReadLine());
                    if (Matches >= 3)
                    {
                        if (input == 1)
                        {
                            Matches -= input;
                            outputText = $"Du tog {input} tændstikker";
                            validPlay = true;
                        }
                        else if (input == 2)
                        {
                            Matches -= input;
                            outputText = $"Du tog {input} tændstikker";
                            validPlay = true;
                        }
                        else if (input == 3)
                        {
                            Matches -= input;
                            outputText = $"Du tog {input} tændstikker";
                            validPlay = true;
                        }
                        else
                        {
                            outputText = $"Indtast et gyldigt tal";
                        }
                    }
                    else if (Matches >=2)
                    {
                        if (input == 1)
                        {
                            Matches -= input;
                            outputText = $"Du tog {input} tændstikker";
                            validPlay = true;
                        }
                        else if (input == 2)
                        {
                            Matches -= input;
                            outputText = $"Du tog {input} tændstikker";
                            validPlay = true;
                        }
                        else
                        {
                            outputText = $"Indtast et gyldigt tal";
                        }
                    }
                    else
                    {
                        if (input == 1)
                        {
                            Matches -= input;
                            outputText = $"Du tog {input} tændstikker";
                            validPlay = true;
                        }
                        else
                        {
                            outputText = $"Indtast et gyldigt tal";
                        }
                    }
                }
                else
                {
                    //computers turn
                    //it chooses a random number from 1-3 or less depending on how many matches are left
                    if (Matches >= 3)
                    {
                        input = rng.Next(1,4);
                        if (input == 1)
                        {
                            Matches -= input;
                            outputText = $"Computeren tog {input} tændstikker";
                            validPlay = true;
                        }
                        else if (input == 2)
                        {
                            Matches -= input;
                            outputText = $"Computeren tog {input} tændstikker";
                            validPlay = true;
                        }
                        else
                        {
                            Matches -= input;
                            outputText = $"Computeren tog {input} tændstikker";
                            validPlay = true;
                        }
                    }
                    else if (Matches >= 2)
                    {
                        input = rng.Next(1, 3);
                        if (input == 1)
                        {
                            Matches -= input;
                            outputText = $"Computeren tog {input} tændstikker";
                            validPlay = true;
                        }
                        else
                        {
                            Matches -= input;
                            outputText = $"Computeren tog {input} tændstikker";
                            validPlay = true;
                        }
                    }
                    else
                    {
                        input = 1;
                        if (input == 1)
                        {
                            Matches -= input;
                            outputText = $"Computeren tog {input} tændstikker";
                            validPlay = true;
                        }
                    }
                }
                //writes output text and checks if the game is done
                Console.WriteLine(outputText);
                gameDone = checkIfGameDone(Matches);

                //uses a if to check if it was a vaild play
                if (validPlay == true)
                {
                    turn++;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{whoWins(turn)}");
            }


            //a function to check if the game is done
            static bool checkIfGameDone(int matchesleft)
            {
                if (matchesleft == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //a function to check who won the game
            static string whoWins(int turn)
            {
                if (turn %2 == 0)
                {
                    return "Player wins";
                }
                else
                {
                    return "Computer wins";
                }
                

            }


            Console.Read();
        }
    }
}