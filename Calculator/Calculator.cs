namespace Calculator;
internal class Calculator : ICalculator
{
    ILogger Logger { get; } 

    public Calculator(ILogger logger)
    {
        Logger = logger;
    }

    public void Sum(int a, int b)
    {
        int result = a + b;
        Logger.Event($"Результат: {a} + {b} = {result}");
    }

    //Добавил метод для демонстрации Logger.Error - не придумал как в Sum симитировать ошибку, которая бы органично смотрелась
    public void Division(int a, int b)
    {
        try
        {
            int result = a / b;
            Logger.Event($"Результат: {a} / {b} = {result}");
        }
        catch(DivideByZeroException)
        {
            Logger.Error("Попытка разделить на ноль");
        }
    }
}
