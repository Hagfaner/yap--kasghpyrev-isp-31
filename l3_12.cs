using System.Collections.Specialized;

static void Delta(int[] n)
{
	int[]n1= new int[n.Length];
	n1[0] = n[0];
	for (int i =1; i < n.Length; i++)
	{
		n1[i]=n[i]-n[i-1];
	}
	foreach (int i in n1)
	{
		Console.Write(i);Console.Write(" ");
	}
}
int[] n=new int[7] {-5,14,2,74,10,0,61 };
Delta(n);
