
using System;

class Program
{
	static void Main()
	{
		Console.Write("Podaj liczbę całkowitą: ");
		int liczba = Convert.ToInt32(Console.ReadLine());

		if (liczba % 2 == 0)
		{
			Console.WriteLine($"{liczba} jest liczbą parzystą.");
		}
		else
		{
			Console.WriteLine($"{liczba} jest liczbą nieparzystą.");
		}

		Console.ReadLine();
	}
}