using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TicTacToe2021
{
    public struct GameResults
    {
        public void StreamResults()
        {
            string writePath = @"C:\Users\4ymad\source\repos\TicTacToe2021\Reults.txt";
            string text = "Hello World";

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(writePath, true, System.Text.Encoding.Default)) // без System.IO. НЕПОСРЕДСТВЕННО ПЕРЕД StreamWriter выдает ошибку.
                                                                                                                          // Добавление перед классом вообще ничего не меняет
            {
                sw.WriteLine(text);
            }
        }
    }
}
