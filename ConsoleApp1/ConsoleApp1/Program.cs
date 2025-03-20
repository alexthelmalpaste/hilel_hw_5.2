using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введіть число: ");
            string input = Console.ReadLine();
            double number = Convert.ToDouble(input);
            Console.WriteLine($"Ви ввели число: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка: введене значення не є числом.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Непередбачена помилка: {ex.Message}");
        }
    }
}
