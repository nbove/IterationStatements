/*
 Author: Nick Bove
 Date: 1/21/18
 Comments: This C# Console application code demonstrates the use of
           iterative statements after getting input from users. 
*/

using System;

namespace IterationStatements
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter an integer value between 1 and 100 to execute an iterative statement:");

			try
			{
				string input = Console.ReadLine();
				int value_of_input = int.Parse(input);

				if ((value_of_input > 0) && (value_of_input <= 100))
				{
					Console.WriteLine("Executing a For Loop!");
					Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times.");




					for (int i = 0; i < value_of_input; i++)
					{
						Console.WriteLine("You have entered" + value_of_input + "This is the current integer value in the loop:" + i.ToString());
					}
					Console.WriteLine("Press any key to exit the program ...");
					Console.ReadKey(true);
				}
				
			}


			catch
			{
				Console.WriteLine("Please enter an integer value and try running the program again ...");
				Console.WriteLine("Press any key to exit the program ...");
				Console.ReadKey(true);
			} 
		} 
	} 
} 
