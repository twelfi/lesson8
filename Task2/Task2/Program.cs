using System.Text;

namespace Task2;

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

        Console.WriteLine(sb.ToString());   
    }
}
