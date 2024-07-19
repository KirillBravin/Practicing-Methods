using System;

public class ExtraArrayExercises
{
	public static void ExtraArraysMain()
	{
		SumOfArrays();
		IsFirstGreaterThanSecond();
		OddOrEven();
		PositiveOrNegative();
		IsAverageEqual();
		AreArrayElementsDifferent();
		AreToElementsGreaterThanFifty();
		IsPerfectSquare();
		IsArithmeticProgression();
		IsProductEqual();
    }

	public static void SumOfArrays()
	{
		int[] arr = new int[4];
		Console.WriteLine("Enter 4 numbers.");
		arr[0] = int.Parse(Console.ReadLine());
		arr[1] = int.Parse(Console.ReadLine());
		arr[2] = int.Parse(Console.ReadLine());
		arr[3] = int.Parse(Console.ReadLine());

		int sum = arr.Sum();

		if (sum % 2 == 0)
		{
			Console.WriteLine("Number is even");
		}
		else Console.WriteLine("Number is odd");
	}

	public static void IsFirstGreaterThanSecond()
	{
		int[] arr = new int[] { 5, 4, 9 };

		if (arr[0] > arr[1] && arr[0] < arr[2])
		{
			Console.WriteLine("The first element is between the second and third.");
		}
		else Console.WriteLine("The first element is not between the second and third");
	}

	public static void OddOrEven()
	{
		int[] arr = new int[] { 1, 11, 9, 2, 4 };

		if (arr[0] % 2 != 0 && arr[4] % 2 == 0)
		{
			Console.WriteLine("First odd, last even");
		}
		else Console.WriteLine("Condition not met");
	}

	public static void PositiveOrNegative()
	{
		int[] arr = new int[] { 6, -13 };

		if (arr[0] > 0 && arr[1] < 0 || arr[0] < 0 && arr[1] > 0)
		{
			Console.WriteLine("One element is negative, the other is positive");
		}
		else Console.WriteLine("Both elements are positive or both are negative");
	}

	public static void IsAverageEqual()
	{
		int[] arr = new int[] { 3, 9, 12, 5 };

		if (arr[1] == arr[0] + arr[2])
		{
			Console.WriteLine("The second element is equal to the average of the first and third");
		}
		else
		{
			Console.WriteLine("The second element is not equal to the average of the first and third");
		}
	}

	public static void AreArrayElementsDifferent()
	{
		int[] arr = new int[] { 0, 2, 3 };

		if (arr[0] == arr[1] && arr[0] == arr[2] || arr[1] == arr[2] )
		{
			Console.WriteLine("There are at least two identical elements");
		}
		else Console.WriteLine("All elements are distinct");
	}

	public static void AreToElementsGreaterThanFifty()
	{
		int[] arr = new int[] { 55, 12, 4, 99 };

		bool firstNumber = arr[0] > 50 ? true : false;
		bool secondNumber = arr[1] > 50 ? true : false;
		bool thirdNumber = arr[2] > 50 ? true : false;
		bool fourthNumber = arr[3] > 50 ? true : false;

		if (firstNumber && secondNumber || firstNumber && thirdNumber || firstNumber && fourthNumber)
		{
			Console.WriteLine("At least two elements greater than 50");
		}
		else if (secondNumber && thirdNumber || secondNumber && fourthNumber)
		{
			Console.WriteLine("At least two elements greater than 50");
		}
		else if (thirdNumber && fourthNumber)
		{
            Console.WriteLine("At least two elements greater than 50");
        } else Console.WriteLine("Less than two elements greater than 50");
	}

	public static void IsPerfectSquare()
	{
		int[] arr = new int[] { 4, 18 };

		if (arr[0] < 0 || arr[1] < 0)
		{
			Console.WriteLine("Perfect square can't be negative numbers.");
		}

		// Some google-foo here
		int sqrt1 = (int)Math.Sqrt(arr[0]);
		int sqrt2 = (int)Math.Sqrt(arr[1]);

		if (sqrt1 * sqrt1 == arr[0] || sqrt2 * sqrt2 == arr[1])
		{
			Console.WriteLine("There is a perfect square.");
		} else Console.WriteLine("No perfect square.");
	}

	public static void IsArithmeticProgression()
	{
		int[] arr = new int[] { 2, 5, 8 };

		if (arr[1] - arr[0] == arr[2] - arr[1])
		{
			Console.WriteLine("The elements form an arithmetic progression");
		} else Console.WriteLine("The elements do not form an arithmetic progression");
	}

	public static void IsProductEqual()
	{
		int[] arr = new int[] { 16, 3, 4, 16 };

		if (arr[0] == Math.Pow(arr[2], 2) && arr[3] == Math.Pow(arr[2], 2)) {
			Console.WriteLine("The product is equal to the square");
		} else Console.WriteLine("Product not equal to square");
	}
}