using System.Diagnostics;
using System.Text;

namespace Task1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string value = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(value))
        {
            Console.WriteLine("Некорректное значение");
            value = Console.ReadLine();
        }

        StringBuilder sb = new StringBuilder();
        foreach (char a in value)
        {
            if (!char.IsWhiteSpace(a))
            {
                sb.Append(a);
            }
        }

        string result = sb.ToString().ToLower();
        string reversed = new string(result.Reverse().ToArray());

        if (result == reversed)
        {
            Console.WriteLine("Это палиндром");
        }
        else
        {
            Console.WriteLine("Это не палиндром");
        }
    }
}
