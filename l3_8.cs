static void GetCode(string n)
{
	List<char> n1= new List<char>();
	foreach(char c in n)
	{
		n1.Add(c);
	}
	n1.Sort();
	n1 = n1.Distinct().ToList();
	foreach(char a in n1)
	{
		Console.Write($"{a} ");
		for (int i = 0; i < n.Length; i++)
		{
			if (a == n[i]) { Console.Write($"{i} "); }
		}
	}
}
GetCode(Console.ReadLine());
