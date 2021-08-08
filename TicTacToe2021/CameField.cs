using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2021
{
    public class GameField
    {

        public void GameFieldCreator(char[] Field)
        {
            const string line = "-+-+-";
            const string vert = "|";
            Console.WriteLine($"{Field[0]}{vert}{Field[1]}{vert}{Field[2]}");
            Console.WriteLine(line);
            Console.WriteLine($"{Field[3]}{vert}{Field[4]}{vert}{Field[5]}");
            Console.WriteLine(line);
            Console.WriteLine($"{Field[6]}{vert}{Field[7]}{vert}{Field[8]}");
        }
    }
}
