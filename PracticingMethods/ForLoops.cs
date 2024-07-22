using System;

public class ForLoops
{
	public static void ForLoopsMain()
	{
		//SumOfEvenNumbers();
		//ArePrimeNumbers();
		//IsDivisibleNumbers();
		//FindLargestNumberInArray();
		//CalculatingAverageNumberInArray();
		//FindingNegativeNumbers();
		//CheckIfNumberInArray();
		//ReverseArray();
		//FindingDuplicates();
		//FindingFirstNegativeNumber();
		//FindingOddOrEven();
    }

	public static void SumOfEvenNumbers()
	{
		int sum = 0;
		for (int i = 0; i <= 100; i++)
		{
			if (i % 2 == 0)
			{
				sum += i;
            }
		}
		Console.WriteLine(sum);
	}

	public static void ArePrimeNumbers()
	{
		for (int i = 1; i <= 50; i++)
		{

			bool isPrime = true;

			if (i == 1)
			{
				continue;
			}

			for (int j = 2; j <= Math.Sqrt(i); j++)
			{
				if (i % j == 0)
				{
					isPrime = false;
					break;
				}
			}

			if (isPrime) 
			{ 
				Console.Write($"{i}, "); 
			}
		}
	}

	public static void IsDivisibleNumbers()
	{
		for (int i = 1; i <= 100; i++)
		{
			if (i % 3 == 0 && i % 5 == 0)
			{
				Console.WriteLine(i);
			}
		}
	}

	public static void FindLargestNumberInArray()
	{
		int[] array = new int[] { 3, 5, 7, 2, 8 };
		int largestNumber = 0;

		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] > largestNumber)
			{
				largestNumber = array[i];
			}
		}
		Console.WriteLine($"Largest number in array is: {largestNumber}");
	}

	public static void CalculatingAverageNumberInArray()
	{
		int[] array = {	10, 20, 30, 40, 50 };
		int sum = 0;

		for (int i = 0; i < array.Length; i++)
		{
			sum += array[i];
		}

		int avgNum = sum / array.Length;
		Console.WriteLine(avgNum);
	}

	public static void FindingNegativeNumbers()
	{
		int[] array = {-1, 2, -3, 4, -5};
		int sum = 0;

		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] < 0)
			{
				sum++;
			}
		}
		Console.WriteLine($"Sum of negative numbers: {sum}");
	}

	public static void CheckIfNumberInArray()
	{
		int[] array = { 1, 2, 3, 4, 5 };
		Console.Write($"Enter a number you would like to check in array: ");
		int input = int.Parse(Console.ReadLine());
		int number = 0;

		for (int i = 0; i < array.Length; i++)
		{
			if (input == array[i])
			{
				Console.Write($"{input} is in the array");
				number = input;
			}
		}

		if ( number == 0)
		{
            Console.Write($"{input} is not in the array");
        }
	}

	public static void ReverseArray()
	{
		int[] array = {1, 2, 3, 4, 5};
		int[] array2 = new int[array.Length];

		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = array[array.Length - 1 - i];
		}

		Console.WriteLine($"Original array: {string.Join(", ", array)}");
		Console.WriteLine($"Reversed array: {string.Join(", ", array2)}");
	}

	public static void FindingDuplicates()
	{
		int[] array = { 1, 2, 2, 3, 4, 4, 5 };

		Console.Write("Dublicates are: ");
		for (int i = 0; i < array.Length; i++) 
		{
			for (int j = i+1; j < array.Length; j++) 
			{
				if (array[i] == array[j])
				{
					Console.Write($"{array[i]}, ");
				}
			}
		}
	}

	public static void FindingFirstNegativeNumber()
	{
		int[] array = { 1, 2, -3, 4, -5 };

		for (int i = 0;i < array.Length; i++)
		{
			if (array[i] < 0)
			{
				Console.WriteLine($"First negative number is: {array[i]}");
				break;
			}
		}
	}

	public static void FindingOddOrEven()
	{
		int[] array = { 1, 2, 3, 4, 5, 6};
		int even = 0;
		int odd = 0;

		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] % 2 == 0)
			{
				even++;
			} else
			{
				odd++;
			}
		}

		Console.WriteLine($"Even numbers: {even}");
		Console.WriteLine($"Odd numbers: {odd}");
	}
}
