using System;

namespace TicTacToe2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Salutation Welcoming = new Salutation();
            Welcoming.Greatings();
            

            // TestClass Test = new TestClass();
            // Test.Tester();

            const char emptyness = ' ';
            char[] NField = new char[9];
            int turn = 0;
            bool game = false;

            Array.Fill(NField, emptyness); // Didnt figure out what it does, just took this string from example

            GameField Start = new GameField();
            EndGame Determinator = new EndGame();
            Start.GameFieldCreator(NField);

            
            while (game == false)
            {
                game = Determinator.DeterminWinner(emptyness, NField, game, turn);
                turn += 1;
            }

            GameResults writing = new GameResults();
            writing.StreamResults();

            Console.WriteLine();
        }
    }
}
