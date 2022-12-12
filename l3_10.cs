using System.Collections.Specialized;

static void check(string a)
{
	foreach (char b in a)
	{
		if ((b=='e') || (b=='E'))
		{
			Console.WriteLine("Есть лат буквы");
			break;
		}
	}
}
check(Console.ReadLine());

