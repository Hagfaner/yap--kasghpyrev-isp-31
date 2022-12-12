using System.Collections.Specialized;

static void DeltaDecoding(int[] n)
{
	int[]n1= new int[n.Length];
	n1[0] = n[0];
	for (int i =1; i < n.Length; i++)
	{
		n1[i]=n[i]+ n1[i-1];
	}
	foreach (int i in n1)
	{
		Console.Write(i);Console.Write(" ");
	}
}
int[] n=new int[6] {8,25,-48,15,19,-36 };
DeltaDecoding(n);
