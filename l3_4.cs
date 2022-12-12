using System.Collections.Specialized;

static List<int> GetMultiple(int start,int end)
{
	List<int> l = new List<int>();
	for (int i = start; i <= end; i++)
	{
		if (i % 7 == 0 && i!=0) l.Add(i);
	}
	return l;
}
static void PrintEven(List<int> l)
{
	int j = 0;
	foreach (int i in l)
	{
		if(j%2==0) Console.WriteLine(i);
		j++;
	}
}
int startValue = int.Parse(Console.ReadLine());
int endValue = int.Parse(Console.ReadLine());
PrintEven(GetMultiple(startValue, endValue));   

