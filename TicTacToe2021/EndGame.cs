using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TicTacToe2021
{
    public class EndGame
    {
        public bool DeterminWinner(char Zero, char[] Field, bool Game, int turn)
        {
            const char X = 'X';
            const char O = 'O';
            int player;
            int number;
            string s = " ";
            bool flag = true;
            player = (turn % 2) + 1;

            //int wplayer;
            //string writePath = @"Results.txt";

            Salutation Welcoming2 = new Salutation();

            do
            {
                try
                {
                    Console.Write("Игрок " + player + " выберите клетку от 0 до 8: ");
                    s = Console.ReadLine();
                    number = Convert.ToInt32(s);
                    if ((s.Length == 1) && (number >= 0) && (number <= 8))
                    {
                        if (Field[number] == Zero)
                        {
                            
                            if (player == 1)
                                Field[number] = X;
                            else Field[number] = O;
                            flag = false;
                            Console.Clear(); // Убираем старую картинку
                            Welcoming2.Greatings();
                        }
                        else Console.WriteLine("Ошибка. Выбранная клетка занята");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка. Введите номер клетки от 0 до 8");
                }
            }
            while (flag);

            Game = (Zero != Field[0]) && (Field[0] == Field[1]) && (Field[1] == Field[2]) || // Проверяем, появился ли победитель после хода игрока
                   (Zero != Field[3]) && (Field[3] == Field[4]) && (Field[4] == Field[5]) || // Спизжено! Тут почти все спизжено, Гриша! Но, полагаю, тебя это не удивит, равно как и не возмутит.
                   (Zero != Field[6]) && (Field[6] == Field[7]) && (Field[7] == Field[8]) ||
                   (Zero != Field[0]) && (Field[0] == Field[3]) && (Field[3] == Field[6]) ||
                   (Zero != Field[1]) && (Field[1] == Field[4]) && (Field[4] == Field[7]) ||
                   (Zero != Field[2]) && (Field[2] == Field[5]) && (Field[5] == Field[8]) ||
                   (Zero != Field[0]) && (Field[0] == Field[4]) && (Field[4] == Field[8]) ||
                   (Zero != Field[2]) && (Field[2] == Field[4]) && (Field[4] == Field[6]);

            GameField Filler = new GameField();
            Filler.GameFieldCreator(Field);

            //GameResults wp = new GameResults();

            if (Game)
            {
                Console.WriteLine("Победил игрок " + player);
                //using (StreamWriter sw = new StreamWriter(writePath))
                //{
                //    sw.WriteLine("Победил игрок " + player);
                //}
                //wp.StreamResults("ПРОВЕРКАПобедил игрок " + player);
            }
            else if (turn == 8)
            {
                Game = true;
                Console.WriteLine("Ничья");
            }
            return Game;
        }
    }
}
