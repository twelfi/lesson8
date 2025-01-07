using System.Text.RegularExpressions;

namespace Task3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        var value = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(value))
        {
            Console.WriteLine("Некорректное значение");
            value = Console.ReadLine();
        }
        Console.WriteLine($"Все буквы строчные: {value.ToLower()}");
        Console.WriteLine($"Все буквы заглавные: {value.ToUpper()}");
        string result = Regex.Replace(value.ToLower(), @"\b\w", match => match.Value.ToUpper());
        Console.WriteLine($"Первая буква каждого слова заглавная: {result}");
    }
}
