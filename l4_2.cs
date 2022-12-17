string a=Console.ReadLine();
string[] b = a.Split(" ");
List<int> c=new List<int>();
bool start = true,end=true;
int ids=0, ide=0;
for (int i = 0; i < b.Length; i++)
{
    if (start)
    {
        if (b[i] == "0") { start = false;ids = i; }
    }else if (end)
    {
        if (b[i] == "0") { end = false;ide=i; }
    }
}
for (int i = ids+1; i < ide; i++)
{
    c.Add(int.Parse(b[i]));
}
c.Sort();
c.Reverse();
foreach(int id in c)
{
    Console.WriteLine(id);
}
