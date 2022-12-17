static void GetMissed(List<int> n)
{
	int id = 0;
	for (int i = n[0]; i < n[n.Count-1]; i++)
	{
		if (i != n[id]) { Console.WriteLine(i); }
		else id++;

    }
}
string a=Console.ReadLine();
string[] b = a.Split(' ');
List<int> c = new List<int>();
foreach (string s in b)
{
    c.Add(int.Parse(s));
}
GetMissed(c);
