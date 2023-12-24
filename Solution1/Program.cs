using System.Text;

public class Program
{
    public static void Main()
    {
        // Входной файл "MLStart_2023\Solution1\input1.txt"
        var input = File.ReadLines("..\\..\\..\\input1.txt", Encoding.UTF8);

        // Напишите код  решения задачи ниже
        int summa = 0;
        Dictionary<string, int> map = new Dictionary<string, int>()
        {
            { "A X", 4 },
            { "A Y", 8 },
            { "A Z", 3 },
            { "B X", 1 },
            { "B Y", 5 },
            { "B Z", 9 },
            { "C X", 7 },
            { "C Y", 2 },
            { "C Z", 6 }
        };
        foreach (string line in input)
        {
            summa += map[line];
        }
        Console.WriteLine(summa);

}   }

