using System;

public class LessonWithArrays
{
	public static void ArraysMain()
	{
		BasicArrayOperations();
		IsNumberAnArrayElement();
		ReplacingIndex();
		IsCharacterInTheArray();
		IsStringInTheArray();
		IsSumInTheArray();
		CheckIndex();
    }

	public static void BasicArrayOperations()
	{
		int[] array = new int[10];
        // Reading and outputting the first item
        Console.Write("Enter the 1st element value: ");
		array[0] = int.Parse(Console.ReadLine());
		Console.WriteLine($"First element value is now: {array[0]}");

        // Changing the second element
        array[1] = 3;
		Console.WriteLine($"Second element value is now: {array[1]}");

        // Setting and outputting the length of the array
        Console.Write($"Set the length of an array: ");
		int[] array2 = new int[int.Parse(Console.ReadLine())];
		Console.WriteLine($"Your array has the length of: {array2.Length}");

		// Reading and outputting the third element
		Console.Write($"Enter the 3rd element value: ");
		array[2] = int.Parse(Console.ReadLine());
        Console.WriteLine($"Third element value is now: {array[2]}");

		// Reading and outputting the last element
		Console.Write($"Enter the last element value: ");
		array[array.Length - 1] = int.Parse(Console.ReadLine());
        Console.WriteLine($"Last element value is now: {array[array.Length - 1]}");

        // Reading and outputting the middle element
        Console.Write($"Enter the middle element value: ");
		array[5] = int.Parse(Console.ReadLine());
        Console.WriteLine($"The middle element value is now: {array[5]}");

		Console.WriteLine("Lets add some elements to our array.");
		Console.WriteLine("Let's say numbers 20, 45, 17");
		array[0] = 20;
		array[1] = 45;
		array[2] = 17;
    }

	public static void IsNumberAnArrayElement()
	{
        Console.WriteLine("There are some numbers in an array.");
        Console.WriteLine("Input a number to check if it is an array element:");

		int[] array = new[] { 1, 2, 4};
		int input = int.Parse(Console.ReadLine());

		if (input == array[0])
		{
			Console.WriteLine("Number is an array element.");
		}
		else if (input == array[1])
		{
            Console.WriteLine("Number is an array element.");
        } else if (input == array[2])
		{
            Console.WriteLine("Number is an array element.");
        } else Console.WriteLine("Number is not an array element.");

    }

	public static void ReplacingIndex()
	{
		double[] array = new double[5];
		int index;
		double value;

		Console.WriteLine("Lets replace any index with any value. Array has 5 elements.");
		Console.Write($"Insert index: ");
		index = int.Parse(Console.ReadLine());
        Console.Write($"Insert value: ");
		value = double.Parse(Console.ReadLine());
        array[index] = value;
		Console.WriteLine($"Array with index {index} has value of {array[index]}");
	}

	public static void IsCharacterInTheArray()
	{
		char[] array = new char[] { 'a', 'b', 'w', 'm' };
		char input;

		Console.Write($"Enter any character to see if it's a part of an array: ");
		input = char.Parse(Console.ReadLine());

		if (input == array[0])
		{
			Console.WriteLine("That character exists in array under index 0");
		} else if (input == array[1])
		{
            Console.WriteLine("That character exists in array under index 1");
        } else if(input == array[2])
		{
            Console.WriteLine("That character exists in array under index 2");
        } else if (input == array[3]) {
            Console.WriteLine("That character exists in array under index 3");
        } else Console.WriteLine("That character doesn't exists in array.");
    }

	public static void IsStringInTheArray()
	{
        string[] array = new string[] { "", "hello", "world", "random" };
        string input;

        Console.Write($"Enter any word to see if it's a part of an array: ");
        input = Console.ReadLine();

        if (input == array[0])
        {
            Console.WriteLine("That word exists in array under index 0");
        }
        else if (input == array[1])
        {
            Console.WriteLine("That word exists in array under index 1");
        }
        else if (input == array[2])
        {
            Console.WriteLine("That word exists in array under index 2");
        }
        else if (input == array[3])
        {
            Console.WriteLine("That word exists in array under index 3");
        }
        else Console.WriteLine("That word doesn't exists in array.");
    }

	public static void IsSumInTheArray()
	{
		int[] arr = new int[] { 12, 4, 55 };
		int firstNumber;
		int secondNumber;

		Console.WriteLine("Enter two numbers and check if sum of them is part of an array.");
		Console.Write("Enter first number: ");
		firstNumber = int.Parse(Console.ReadLine());
		Console.Write("Enter second number: ");
		secondNumber = int.Parse(Console.ReadLine());

		int sum = firstNumber + secondNumber;

        if (sum == arr[0])
        {
            Console.WriteLine($"{sum} exists in array under index 0");
        }
        else if (sum == arr[1])
        {
            Console.WriteLine($"{sum} exists in array under index 1");
        }
        else if (sum == arr[2])
        {
            Console.WriteLine($"{sum} exists in array under index 2");
        } 
		else Console.WriteLine($"{sum} doesn't exist in array.");
    }

	public static void CheckIndex()
	{
		int[] array = new int[10];

		Console.Write("Enter any number to check if that index exists in an array: ");
		int input = int.Parse(Console.ReadLine());

		if (array.Length - 1 >= input)
		{
			Console.WriteLine("That index exists in an array.");
		} else Console.WriteLine("That index doesnt exist in an array.");

    }
}
