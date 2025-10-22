using System;

namespace СonsoleApp13.Interface;


interface IComputer
{
    string ComputerName { get; set; }
    float Sum(float a, float b);
    float Subtract(float a, float b);
    float Multiply(float a, float b);
    float Divide(float a, float b);
    float SquareRoot(float num1);
}


class Computer : IComputer
{
    public string ComputerName { get; set; } = "Калькулятор";

    public float Sum(float a, float b)
    {
        return a + b;
    }

    public float Subtract(float a, float b)
    {
        return a - b;
    }

    public float Multiply(float a, float b)
    {
        return a * b;
    }

    public float Divide(float a, float b)
    {
        if (b == 0)
            throw new DivideByZeroException("Деление на ноль");
        return a / b;
    }

    public float SquareRoot(float num1)
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void House()
    {
        IComputer calculator = new Computer();
        Console.WriteLine($"Начать решение в {calculator.ComputerName}");

        
        Console.Write("Введите первое число: ");
        if (!float.TryParse(Console.ReadLine(), out float num1))
        {
            Console.WriteLine("Некорректный ввод. Завершение.");
            return;
        }

        
        Console.Write("Введите второе число: ");
        if (!float.TryParse(Console.ReadLine(), out float num2))
        {
            Console.WriteLine("Некорректный ввод. Завершение.");
            return;
        }

       
        Console.WriteLine("Выберите операцию (+, -, *, /, √):");
        string op = Console.ReadLine();

        try
        {
            float result;
            switch (op)
            {
                case "+":
                    result = calculator.Sum(num1, num2);
                    break;
                case "-":
                    result = calculator.Subtract(num1, num2);
                    break;
                case "*":
                    result = calculator.Multiply(num1, num2);
                    break;
                case "/":
                    result = calculator.Divide(num1, num2);
                    break;
                case "√":
                    result = calculator.SquareRoot(num1);
                default:
                    Console.WriteLine("Неизвестно");
                    return;
            }

            Console.WriteLine($"Результат: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}