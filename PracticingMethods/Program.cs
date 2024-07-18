namespace LearningMethods
{
    public class FirstClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            IsPositiveOrNegative(int.Parse(Console.ReadLine()));

            Console.WriteLine("Insert 3 numbers and find out the largest one");
            FindBiggestNumber(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.Write("Enter a single character to check if it is a vowel or a consonant: ");
            IsVowelOrConsonant(Console.ReadLine());
        }


        public static void IsPositiveOrNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number");
            }
            else if (number == 0)
            {
                Console.WriteLine($"{number} is a null");
            }
        }

        public static void FindBiggestNumber(int number1, int number2, int number3)
        {
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine($"The biggest number is: {number1}");
            } else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine($"The biggest number is: {number2}");
            } else if (number3 > number1 && number3 > number2)
            {
                Console.WriteLine($"The biggest number is: {number3}");
            }
        }

        public static void IsVowelOrConsonant (string character)
        {
            switch (character)
            {
                case "a":
                    Console.WriteLine("This letter is a vowel");
                    break;
                case "b":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "c":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "d":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "e":
                    Console.WriteLine("This letter is a vowel");
                    break;
                case "f":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "g":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "h":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "i":
                    Console.WriteLine("This letter is a vowel");
                    break;
                case "j":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "k":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "l":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "m":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "n":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "o":
                    Console.WriteLine("This letter is a vowel");
                    break;
                case "p":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "q":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "r":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "s":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "t":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "u":
                    Console.WriteLine("This letter is a vowel");
                    break;
                case "v":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "w":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "x":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "y":
                    Console.WriteLine("This letter is a consonant");
                    break;
                case "z":
                    Console.WriteLine("This letter is a consonant");
                    break;
            }
        }
    }
}