namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            string repeat = "";

            while (true)
            {
                Console.Beep(988, 250);
                Console.Beep(1980, 250);
                Console.Beep(1480, 250);
                Console.Beep(988, 500);
                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                while (true)
                {
                    try
                    {
                        Console.Write("Enter number 1: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                    }

                    try
                    {
                        Console.Write("Enter number 2: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        break;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                    }
                }

                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        break;
                    default:
                        Console.WriteLine("That was not a valid option!!!");
                        break;
                }

                Console.WriteLine("Would you like to calculate again? (Y/N)");
                repeat = Console.ReadLine().Trim().ToUpper();

                if (repeat != "Y")
                {
                    Console.WriteLine("Goodbye!!!");
                    Console.Beep(1980, 250);
                    Console.Beep(1480, 250);
                    Console.Beep(988, 250);
                    Console.Beep(494, 300);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
