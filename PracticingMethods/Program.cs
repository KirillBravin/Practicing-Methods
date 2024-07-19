namespace LearningMethods
{
    public class FirstClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Is the number positive or negative?");
            Console.Write("Input a number: ");
            IsPositiveOrNegative(int.Parse(Console.ReadLine()));

            Console.WriteLine("Insert 3 numbers and find out the largest one");
            FindBiggestNumber(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.Write("Enter a single character to check if it is a vowel or a consonant: ");
            IsVowelOrConsonant(char.Parse(Console.ReadLine()));

            Console.WriteLine("Leap year checker. Is it or is it not, let's find out!");
            Console.Write("Please enter a year: ");
            IsLeapYear(int.Parse(Console.ReadLine()));

            Console.WriteLine("Lets check if you input a character or a number.");
            Console.Write("Please insert a character or a number: ");
            NumberOrCharacter(char.Parse(Console.ReadLine()));

            Console.WriteLine("Input hours and minutes");
            IsInputValid(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            Console.WriteLine("Lets check if you enter a three-digit number or not.");
            Console.Write("Enter a three-digit number (or not): ");
            IsNumberAThreeDigit(int.Parse(Console.ReadLine()));

            Console.WriteLine("Lets check if character you enter is an uppercase character or not");
            Console.Write("Enter a character (can be uppercase): ");
            IsUpperCase(char.Parse(Console.ReadLine()));

            Console.WriteLine("Lets find out the perimetere of a square.");
            Console.Write("Insert side length: ");
            SquarePerimeter(int.Parse(Console.ReadLine()));

            Console.WriteLine("Lets find out an area of a triangle.");
            Console.WriteLine("Please enter length and height to calculate the area of a triangle.");
            TriangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            Console.WriteLine("Lets find out an area of a circle.");
            Console.Write("Please insert circle's radius: ");
            CircleArea(double.Parse(Console.ReadLine()));

            Console.WriteLine("Lets find out the volume of a cube.");
            Console.Write("Please enter the length of a cube side: ");
            CubeVolume(int.Parse(Console.ReadLine()));

            Console.WriteLine("Translating Celsius to Fahrenheit.");
            Console.Write("Enter the Celsius temperature: ");
            CelciusToFahrenheit(int.Parse(Console.ReadLine()));
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
            if ((year % 4) == 0)
            {
                Console.WriteLine($"{year} is a leap year!");
            }
            else Console.WriteLine($"{year} is not a leap year!");
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

        public static void IsNumberAThreeDigit(int number)
        {
            if (number >= 100 && number <= 999)
            {
                Console.WriteLine("A three-digit number");
            }
            else Console.WriteLine("Not a three-digit number");
        }

        public static void IsUpperCase(char character)
        {
            if (character == Char.ToUpper(character))
            {
                Console.WriteLine("Capital");
            }
            else Console.WriteLine("Non-uppercase");
        }

        public static void SquarePerimeter(int side)
        {
            Console.WriteLine($"Perimeter square is: {side *= 4}");
        }

        public static void TriangleArea(double length, double height)
        {
            Console.WriteLine($"Area of a triangle is: {0.5 * height * length}");
        }

        // I hope I interpreted this one correctly :)
        public static void CircleArea(double r)
        {
            Console.WriteLine($"Circle area is: {Math.Round(3.14 * r * r, 2)}");
            CirclePerimeter(r);
        }

        public static void CirclePerimeter(double r)
        {
            Console.WriteLine($"Circle perimeter is: {Math.Round(2 * 3.14 * r, 2)}");
        }

        public static void CubeVolume(int side)
        {
            Console.WriteLine($"Cube volume is: {Math.Pow(side, 3)}");
        }

        public static void CelciusToFahrenheit(int celsiusTemp)
        {
            Console.WriteLine($"Fahrenheit: {celsiusTemp * 9 / 5 + 32}°F");
        }
    }
}