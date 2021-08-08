using System.IO;

namespace TicTacToe2021
{
    public class GameResults
    {
        public void StreamResults()
        {
            string writePath = @"Results.txt";
            string text = "Hello World";

            using (StreamWriter sw = new StreamWriter(writePath))
            {
                sw.WriteLine(text);
            }
        }
    }
}
