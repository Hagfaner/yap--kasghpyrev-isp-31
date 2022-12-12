using System.Collections.Specialized;

static int[] ArraySum(int[] n, int[]m)
{
	int size = 0;
	if (n.Length > m.Length) { size = n.Length; }
	else { size = m.Length; }
	int[] k= new int[size];
	int id = 0;
	foreach (int i in n)
	{
		k[id] += i;
		id++;
	}
	id = 0;
	foreach (int j in m)
	{
		k[id] += j;
		id++;
	}
	return k;
}
static void Print(int[] n)
{
	foreach (int i in n)
	{
		Console.Write(i);
		Console.Write(" ");
	}
}
int n, m;
n = int.Parse(Console.ReadLine());
m =	int.Parse(Console.ReadLine());
int[] n1= new int[n];
int[] m1= new int[m];
for (int i = 0; i < n; i++)
{
	n1[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < m; i++)
{
    m1[i] = int.Parse(Console.ReadLine());
}
Print(ArraySum(n1, m1));
