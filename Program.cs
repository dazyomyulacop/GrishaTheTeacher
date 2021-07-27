using System;

namespace Grisha_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstOperand = 0;
			int secondOperand = 0;
			int result = 0;
			int operation = 0;

			// I'm tired of leaning Fork
			Console.WriteLine("Fork's interface is uncomfortable. Maybe I'll change my mind later.");

			// Time to say that Grisha is completly lox
			Console.WriteLine("You are lox, Grisha!");

			// Greatings
			Console.WriteLine("Welcome Grisha!");

			// Description
			Console.WriteLine("This program makes adding, " +
				"subtracting, multiplieng or dividing " +
				"for two integer operands");

			// Typing the 1st operand
			Console.WriteLine("Type first operand and press Enter");
			firstOperand = Convert.ToInt32(Console.ReadLine());

			// Choosing an option
			Console.WriteLine("Choose an option from the following list:");
			Console.WriteLine("\t1 - Add");
			Console.WriteLine("\t2 - Subtract");
			Console.WriteLine("\t3 - Multiply");
			Console.WriteLine("\t4 - Divide");
			Console.Write("Your option? ");

			switch (Console.ReadLine())
            {
				case "1":
					operation = Convert.ToInt32(1);
					Console.WriteLine("You choose adding");
					break;

				case "2":
					operation = Convert.ToInt32(2);
					Console.WriteLine("You choose subtracting");
					break;

				case "3":
					operation = Convert.ToInt32(3);
					Console.WriteLine("You choose multiplieng");
					break;

				case "4":
					operation = Convert.ToInt32(4);
					Console.WriteLine("You choose dividing");
					break;
				default:
					Console.WriteLine("Wrong option");
					Console.WriteLine("Closing...");
					Environment.Exit(0);
					break;
			}

			// Typing the 2nd operand
			Console.WriteLine("Type the second operand and press Enter");
			secondOperand = Convert.ToInt32(Console.ReadLine());

			// LETS SCORE 33 POINTS FOR MATH!!!!
			Console.WriteLine("The result is ");
			if (operation == 1)
            {
				result = firstOperand + secondOperand;
				Console.WriteLine(result);
            }
			else
			if (operation == 2)
            {
				result = firstOperand - secondOperand;
				Console.WriteLine(result);
			}
			else
			if (operation == 3)
			{
				result = firstOperand * secondOperand;
				Console.WriteLine(result);
			}
			else
			if (operation == 4)
			{
				result = firstOperand / secondOperand;
				Console.WriteLine(result);
			}
		}
	}
}
