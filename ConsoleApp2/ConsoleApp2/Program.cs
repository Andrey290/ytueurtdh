using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main()
		{
			double a = 1000, b = 0;
			int count = 0;
			bool f = true;
			while (f && count < 11)
			{
				count++;
				Console.WriteLine((a + b) / 2);
				if (Console.ReadLine() == "=")
				{
					Console.WriteLine("Программа угадала число с {0} пытки", count);
					f = false;
				}
				else if (Console.ReadLine() == "<")
				{
					a = (a + b) / 2;
					Console.WriteLine(a);
					Console.WriteLine("Это была попытка номер {0}", count);
				}
				else if (Console.ReadLine() == ">")
				{
					b = (a + b) / 2;
					Console.WriteLine("Это была попытка номер {0}", count);
				}
			}
		}
	}
}