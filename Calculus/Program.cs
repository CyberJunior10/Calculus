using Calculus;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to SMART CALCULUS.");
        GetNumber();
        Add.GetNumber();
    } 
    /*
    static void Addition(decimal number1, decimal number2)
    {
        decimal additresult = number1 + number2;
        Console.WriteLine($"Number: ({number1} + {number2}) = {additresult}.");
    }
    */
    static void Substraction(decimal number1, decimal number2)
    {
        decimal substrresult = number1 - number2;
        Console.WriteLine($"Number: ({number1} - {number2}) = {substrresult}.");
    }
    static void Multiplication(decimal number1, decimal number2)
    {
        decimal multipresult = number1 * number2;
        Console.WriteLine($"Number: ({number1} * {number2}) = {multipresult}.");
    }
    static void Division(decimal number1, decimal number2)
    {
        decimal divideresult = number1 / number2;
        Console.WriteLine($"Number: ({number1} / {number2}) = {divideresult}.");
    }
    static void Percentage(decimal number1, decimal totalnumber)

    {
        decimal percentage = (number1 / totalnumber) * 100;
        Console.WriteLine($"Number: {number1} is {percentage} %" +
            $" of number {totalnumber}.");
    }
    static void GetNumber()
    {
        Console.WriteLine("Number 1: ");
        decimal number1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Number 2: ");
        decimal number2 = decimal.Parse(Console.ReadLine());
      //  Addition(number1, number2);
        Substraction(number1, number2);
        Division(number1, number2);
        Multiplication(number1, number2);
        Percentage(number1, number2);
        Console.WriteLine("._-=¬ new calculus ¬=-_.");
        NewCalculus();        
    }    
    static void NewCalculus()
    {
        GetNumber();
    }
}