using System;

namespace Grisha_1
{
	class Program
	{
		static void Main(string[] args)
		{
            // I'm tired of leaning Fork
			Console.WriteLine("Fork's interface is uncomfortable. Maybe I'll change my mind later.");

			// Time to say that Grisha is completly lox
			Console.WriteLine("You are lox, Grisha!");

			// Greatings
			Console.WriteLine("Welcome Grisha! ");
			Console.WriteLine("Welcome Ruslan! ");

			// Description
			Console.WriteLine("This program makes adding, " +
				"subtracting, multiplying or dividing " +
				"for two integer operands");

			// Typing the 1st operand
			Console.WriteLine("Type first operand and press Enter");
			var firstOperand = Convert.ToInt32(Console.ReadLine());

			// Choosing an option
			Console.WriteLine("Choose an option from the following list:");
			Console.WriteLine("\t+ Add");
			Console.WriteLine("\t- Subtract");
			Console.WriteLine("\t* Multiply");
			Console.WriteLine("\t/ Divide");
			Console.Write("Your option? ");

            string operation = Console.ReadLine();

            // Typing the 2nd operand
			Console.WriteLine("Type the second operand and press Enter");
			var secondOperand = Convert.ToInt32(Console.ReadLine());

			// LETS SCORE 33 POINTS FOR MATH!!!!
			Console.WriteLine("The result is ");

            int result;

            switch (operation)
            {
				case "+":
                    result = firstOperand + secondOperand;
                    break;
                case "-":
                    result = firstOperand - secondOperand;
                    break;
                case "*":
                    result = firstOperand * secondOperand;
                    break;
                case "/":
                    result = firstOperand / secondOperand;
                    break;
				default:
                    throw new ArgumentOutOfRangeException();
			}

            Console.WriteLine(result);
        }
	}
}
