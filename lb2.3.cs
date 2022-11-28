string a=Console.ReadLine();
string[] b = a.Split(' ');
foreach (char n in b[0])
{
	bool id1 = true;
	bool id2 = true;
	foreach( char n1 in b[1]) {
		if (n1 == n)
		{
			id1 = false;
		}
	}	
	int chet = 0;
	foreach(char n2 in b[0]) {
	
		if (n2 == n)
		{
			chet++;
		}
		if (chet > 1) { id2 = false; }
	}
	if (id1 && id2) { Console.Write($"{n} "); ; }
}
