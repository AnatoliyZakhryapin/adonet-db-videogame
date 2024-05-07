﻿namespace adonet_db_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine();
                Console.WriteLine("1. Inserire un nuovo videogioco.");
                Console.WriteLine("2. Ricercare un videogioco per ID.");
                Console.WriteLine("3. Ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input.");
                Console.WriteLine("4. Cancellare un videogioco.");
                Console.WriteLine("5. Chiudere il programma.");

                Console.WriteLine();
                string inputChoice = Console.ReadLine();

                try
                {
                    if (!int.TryParse(inputChoice, out int userChoice))
                        throw new Exception("Devi inserire solo il numero compreso tra 1 e 5! Riprova.");

                    int choice = Convert.ToInt32(inputChoice);

                    switch (choice)
                    {
                        case 1:
                            CreateNewGame();
                            break;
                        case 2:
                            SearchGameById();
                            break;
                        case 3:
                            SearchGameByName();
                            break;
                        case 4:
                            DeleteGame();
                            break;
                        case 5:
                            return;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }
        }

        static void CreateNewGame()
        {

        }

        static void SearchGameById ()
        {

        }

        static void SearchGameByName()
        {

        }

        static void DeleteGame()
        {

        }

    }


}
