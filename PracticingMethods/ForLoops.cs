using System;

public class Loops
{
	public static void LoopsMain()
	{
		//For loops exercises

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

		// While loops exercises
		//FindingLargestNumber();
		//FindingValueBetweenNumbers();
		//FindingLongestSequence();
		//IsSumOfPairsEven();
		//ReversePartOfAnArray();
		//FindingSecondSmallestNumber();
		//FindMostRepeatedElement();
		FindUniqueElements();

    }

	// For loops
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
		int[] array = { 10, 20, 30, 40, 50 };
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
		int[] array = { -1, 2, -3, 4, -5 };
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

		if (number == 0)
		{
			Console.Write($"{input} is not in the array");
		}
	}

	public static void ReverseArray()
	{
		int[] array = { 1, 2, 3, 4, 5 };
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
			for (int j = i + 1; j < array.Length; j++)
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

		for (int i = 0; i < array.Length; i++)
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
		int[] array = { 1, 2, 3, 4, 5, 6 };
		int even = 0;
		int odd = 0;

		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] % 2 == 0)
			{
				even++;
			}
			else
			{
				odd++;
			}
		}

		Console.WriteLine($"Even numbers: {even}");
		Console.WriteLine($"Odd numbers: {odd}");
	}

	// While loops

	public static void FindingLargestNumber()
	{
		int[] array = { 3, 5, 7, 2, 8, -1, 4 };
		int largestNumber = array[0];
		int smallestNumber = array[0];

		int i = 0;

		while (i < array.Length)
		{
			if (array[i] > largestNumber)
			{
				largestNumber = array[i];
			}

			if (array[i] < smallestNumber)
			{
				smallestNumber = array[i];
			}

			i++;
		}

		Console.WriteLine($"Largest number is: {largestNumber}");
		Console.WriteLine($"Smallest number is: {smallestNumber}");
	}

	public static void FindingValueBetweenNumbers()
	{
		int[] array = { 1, 3, 5, 7, 8, 11 };
		int firstNumber;
		int secondNumber;
		int sum = 0;

		Console.WriteLine("Please enter first number: ");
		while (!int.TryParse(Console.ReadLine(), out firstNumber))
		{
			Console.WriteLine("Invalid input.");
		};

		Console.WriteLine("Please enter first number: ");
		while (!int.TryParse(Console.ReadLine(), out secondNumber))
		{
			Console.WriteLine("Invalid input.");
		};

		if (firstNumber > secondNumber)
		{
			Console.WriteLine("The first number should be less than or equal to second number.");
		}

		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] >= firstNumber && array[i] <= secondNumber)
			{
				sum += array[i];
			}
		}

		Console.WriteLine($"Sum of numbers between {firstNumber} and {secondNumber} is {sum}");
	}

	public static void FindingLongestSequence()
	{
		int[] array = { 1, 2, 2, 3, 4, 1, 5, 6 };
		int maxLength = 0;
		int currentLength = 1;
		int startIndex = 0;
		int LongestStartIndex = 0;

		int i = 1;

		while (i < array.Length)
		{
			if (array[i] > array[i - 1])
			{
				currentLength++;
			}
			else
			{
				if (currentLength > maxLength)
				{
					maxLength = currentLength;
					LongestStartIndex = startIndex;
				}
				currentLength = 1;
				startIndex = i;
			}
			i++;
		}

		if (currentLength > maxLength)
		{
			maxLength = currentLength;
			LongestStartIndex = startIndex;
		}

		int[] longestSequence = new int[maxLength];
		for (i = 0; i < maxLength; i++)
		{
			longestSequence[i] = array[LongestStartIndex + i];
		}

		Console.WriteLine("Longest increasing sequence is: ");
		Console.WriteLine(string.Join(", ", longestSequence));
	}

	public static void IsSumOfPairsEven()
	{
		int[] array = { 1, 2, 3, 4, 5 };

		for (int i = 0; i < array.Length; i++)
		{
			for (int j = i + 1; j < array.Length; j++)
			{
				if ((array[i] + array[j]) % 2 == 0)
				{
					Console.WriteLine($"{array[i]} {array[j]}");
				}
			}
		}
	}

	// I am not sure if I did this correctly, as the task gives example that it should return
	// [1, 2, 7, 6, 5, 4, 4, 3, 8, 9], but I have [1, 2, 7, 6, 5, 4, 3, 8, 9].
	public static void ReversePartOfAnArray()
	{
		int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		int[] reversedArray = new int[array.Length];
		int firstNumber;
		int secondNumber;

		int i = 0;

		Console.WriteLine("Please enter first number: ");
		while (!int.TryParse(Console.ReadLine(), out firstNumber))
		{
			Console.WriteLine("Invalid input.");
		};

		Console.WriteLine("Please enter first number: ");
		while (!int.TryParse(Console.ReadLine(), out secondNumber))
		{
			Console.WriteLine("Invalid input.");
		};

		int maxReverse = secondNumber;

		if (firstNumber > secondNumber)
		{
			Console.WriteLine("The first number should be less than or equal to second number.");
		}

		while (i < array.Length)
		{
			if (i >= firstNumber && i <= secondNumber)
			{
				reversedArray[i] = array[maxReverse];
				maxReverse--;
				if (maxReverse == 0)
				{
					break;
				}
			}
			else
			{
				reversedArray[i] = array[i];

			}
			i++;
		}

		Console.WriteLine(string.Join(", ", reversedArray));
	}

	// Extra exercises
	public static void FindingSecondSmallestNumber()
	{
		int[] array = { 3, 5, 7, 2, 8, 1 };
		int smallestNumber = array[0];
        int smallestNumber2 = array[0];


        for (int i = 0; i < array.Length; i++)
		{
			if (smallestNumber > array[i])
			{
				smallestNumber = array[i];
			}
		}

        for (int i = 0; i < array.Length; i++)
		{
			if (smallestNumber2 > array[i] && array[i] != smallestNumber )
			{
				smallestNumber2 = array[i];
			}
		}

		Console.WriteLine($"The second smallest number is: {smallestNumber2}");
    }

	public static void FindMostRepeatedElement()
	{
		int[] array = {1, 2, 2, 3, 4, 4, 4, 5};
		int currentTimer = 0;
		int overallTimer = 0;
		int currentElement = 0;
		int overallElement = 0;
		int i = 0;

		while (i < array.Length - 1) {
			if (array[i] == array[i + 1])
			{
                currentTimer++;
                currentElement = array[i];

				if (currentTimer > overallTimer)
				{
					overallTimer = currentTimer;
					overallElement = currentElement;
				}
			}
            else
            {
				currentTimer = 0;
				currentElement = 0;
            }
            i++;
		}

		Console.WriteLine($"The most repeated element is: {overallElement}");
	}

	//public static void FindUniqueElements()
	//{
	//	int counter = 0;
	//	int[] array = { 1, 2, 2, 3, 4, 4, 5 };
	//	int[] array2 = new int[array.Length];

	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		for (int j = i + 1; j < array.Length; j++) {
	//			if (array[i] == array[j])
	//			{
	//				break;
	//			} else
	//			{
 //                   array2[i] = array[i];
 //               }
	//		}
	//	}

	//	Console.WriteLine(string.Join(", "), array2);
	//}
}