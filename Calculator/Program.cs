namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        int a = WriteOperand("Введите первое число:");
        int b = WriteOperand("Введите второе число:");

        ILogger logger = new Logger();
        ICalculator calculator = new Calculator(logger);
        calculator.Sum(a, b);

        //calculator.Division(a, b);
    }

    static int WriteOperand(string text)
    {
        int operand = 0;

        while (true)
        {
            try
            {
                Console.WriteLine(text);
                operand =  Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение");
                Console.WriteLine();
            }
        }

        return operand;
    }

    }