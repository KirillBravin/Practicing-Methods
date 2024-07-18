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
            IsVowelOrConsonant(char.Parse(Console.ReadLine()));

            Console.WriteLine("NOTE: This will check if the year is a leap year or not, it only counts years from 1944 to 2040");
            Console.Write("Please enter a year: ");
            IsLeapYear(int.Parse(Console.ReadLine()));

            Console.Write("Please insert a character or a number: ");
            NumberOrCharacter(char.Parse(Console.ReadLine()));

            Console.WriteLine("Input hours and numbers");
            IsInputValid(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
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
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine($"The biggest number is: {number2}");
            }
            else if (number3 > number1 && number3 > number2)
            {
                Console.WriteLine($"The biggest number is: {number3}");
            }
        }

        public static void IsVowelOrConsonant(char character)
        {
            switch (character)
            {
                case 'a':
                    Console.WriteLine("This letter is a vowel");
                    break;
                case 'b':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'c':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'd':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'e':
                    Console.WriteLine("This letter is a vowel");
                    break;
                case 'f':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'g':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'h':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'i':
                    Console.WriteLine("This letter is a vowel");
                    break;
                case 'j':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'k':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'l':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'm':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'n':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'o':
                    Console.WriteLine("This letter is a vowel");
                    break;
                case 'p':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'q':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'r':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 's':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 't':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'u':
                    Console.WriteLine("This letter is a vowel");
                    break;
                case 'v':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'w':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'x':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'y':
                    Console.WriteLine("This letter is a consonant");
                    break;
                case 'z':
                    Console.WriteLine("This letter is a consonant");
                    break;
            }
        }

        public static void IsLeapYear(int year)
        {
            if (year < 1944 || year > 2040)
            {
                Console.WriteLine("Error, please enter a year from 1944 to 2040");
            }
            else if (year == 1944)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1948)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1952)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1956)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1960)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1964)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1968)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1972)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1976)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1980)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1984)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1988)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1992)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 1996)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 2000)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 2004)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 2008)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 2012)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 2016)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 2020)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 2024)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 2028)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 2032)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 2036)
            {
                Console.WriteLine("This is a leap year!");
            }
            else if (year == 2040)
            {
                Console.WriteLine("This is a leap year!");
            }
            else Console.WriteLine("This is not a leap year!");
        }

        public static void NumberOrCharacter(char characterOrNumber)
        {
            if (characterOrNumber >= '0' && characterOrNumber <= '9')
            {
                Console.WriteLine("Number");
            }
            else Console.WriteLine("Not a number");
        }

        public static void IsInputValid(int hours, int minutes)
        {
            if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
            {
                Console.WriteLine("Valid input");
            }
            else Console.WriteLine("Invalid input");
        }
    }
}