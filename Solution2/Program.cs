using System;
using System.Text;

public class Program
{
	public static void Main()
	{
		int rezult = 0;
		// Входной файл "MLStart_2023\Solution2\input2.txt"
		var input = File.ReadLines("..\\..\\..\\input2.txt", Encoding.UTF8);

		// Напишите код  решения задачи ниже
		foreach (var line in input)
		{
			int rez_stroki = 0;
			string rez = line.Split(':')[1].Replace("  ", " ").Trim();
            string rez2 = rez.Split("|")[0].Trim();
			string rez3 = rez.Split("|")[1].Trim();
			string[] mas1 = rez2.Split(" ");
			string[] mas2 = rez3.Split(" ");
			foreach (string el in mas1)
			{
				if (mas2.Contains(el))
				{
                    rez_stroki += 1;
                }
			}
			if (rez_stroki == 0)
			{
				continue;
			}
            else if (rez_stroki == 1)
            {
				rezult += 1;
            }
			else 
			{
				rezult += (int)Math.Pow(2, rez_stroki - 1);
			}   
		}	
		Console.WriteLine(rezult);
		
	}
}
