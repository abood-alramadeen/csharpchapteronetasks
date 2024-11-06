// See https://aka.ms/new-console-template for more information
//1. Write a program that enters the diameter of the
//circle from the keyboard and prints the circumference of the circle.

using System;

class Program
{
	static void Main()
	{
		Console.Write("Enter the diameter of the circle: ");
		double diameter = Convert.ToDouble(Console.ReadLine());

		double circumference = Math.PI * diameter;

		Console.WriteLine("The circumference of the circle is: " + circumference);






		//2. Write a program that inputs time and distance from the
		//keyboard and print the speed in meters per hour and kilometers per hour.


		Console.Write("Enter the distance in meters: ");
		double distance = Convert.ToDouble(Console.ReadLine());

		Console.Write("Enter the time in hours: ");
		double time = Convert.ToDouble(Console.ReadLine());

		double speedInMetersPerHour = distance / time;
		double speedInKilometersPerHour = speedInMetersPerHour / 1000;

		Console.WriteLine("Speed in meters per hour: " + speedInMetersPerHour);
		Console.WriteLine("Speed in kilometers per hour: " + speedInKilometersPerHour);





		//3. What are the differences between Post-Increment and Pre-Increment operators?

		int x = 5;
		int y = ++x;




		 x = 5;
		 y = x++;




		//4. Use Math.Round to round a double number to the nearest integer.

		
			double number = 7.56;
			double roundedNumber = Math.Round(number);

			Console.WriteLine("Rounded number: " + roundedNumber);



		//5. Use Math.Pow to calculate the result of baseNumber raised to the power of exponent.

		double baseNumber = 2;
		double exponent = 3;
		double result = Math.Pow(baseNumber, exponent);

		Console.WriteLine($"{baseNumber} raised to the power of {exponent} is: " + result);


		//6. Write a program to check whether a year is a leap year or not.

		Console.Write("Enter a year: ");
		int year = Convert.ToInt32(Console.ReadLine());

		if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
		{
			Console.WriteLine($"{year} is a leap year.");
		}
		else
		{
			Console.WriteLine($"{year} is not a leap year.");
		}


		//7. Write a program to check whether an alphabet is lowercase or uppercase.

		Console.Write("Enter an alphabet: ");
		char alphabet = Convert.ToChar(Console.ReadLine());

		if (char.IsLower(alphabet))
		{
			Console.WriteLine("The alphabet is lowercase.");
		}
		else if (char.IsUpper(alphabet))
		{
			Console.WriteLine("The alphabet is uppercase.");
		}
		else
		{
			Console.WriteLine("This is not an alphabet.");
		}



		//8. Write a program to create a simple calculator (*/+-) using a switch statement.

		Console.Write("Enter the first number: ");
		double num1 = Convert.ToDouble(Console.ReadLine());

		Console.Write("Enter an operator (+, -, *, /): ");
		char op = Convert.ToChar(Console.ReadLine());

		Console.Write("Enter the second number: ");
		double num2 = Convert.ToDouble(Console.ReadLine());

		switch (op)
		{
			case '+':
				Console.WriteLine("Result: " + (num1 + num2));
				break;
			case '-':
				Console.WriteLine("Result: " + (num1 - num2));
				break;
			case '*':
				Console.WriteLine("Result: " + (num1 * num2));
				break;
			case '/':
				if (num2 != 0)
				{
					Console.WriteLine("Result: " + (num1 / num2));
				}
				else
				{
					Console.WriteLine("Error: Division by zero!");
				}
				break;
			default:
				Console.WriteLine("Invalid operator.");
				break;
		}



		//9. Write a program to take 3 numbers from the keyboard and
		//find the maximum number using the ternary operator.

		Console.Write("Enter the first number: ");
		 num1 = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter the second number: ");
		 num2 = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter the third number: ");
		int num3 = Convert.ToInt32(Console.ReadLine());

	int max = (num1 > num2) ? ((num1 > num3) ? num1 : num3) : ((num2 > num3) ? num2 : num3);

		Console.WriteLine("The maximum number is: " + max);



		//10. Write a program to take a number from the keyboard and check if
		//the number is odd or even using the ternary operator.

		Console.Write("Enter a number: ");
		number = Convert.ToInt32(Console.ReadLine());

		string result = (number % 2 == 0) ? "Even" : "Odd";

		Console.WriteLine("The number is: " + result);
	}
}









	