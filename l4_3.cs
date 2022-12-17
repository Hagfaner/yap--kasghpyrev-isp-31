static List<string> GetList(int n)
{
    List<string> arr = new List<string>();
    Random r = new Random();
    for (int i = 0; i < n; i++)
    {
        switch (r.Next(0,4))
        {
            case 0:
                arr.Add(r.Next().ToString());break;
            case 1: 
                arr.Add(r.NextDouble().ToString()); break;
            case 2:
                arr.Add(((char)r.Next(0,100)).ToString()); break;
            case 3:
                arr.Add(r.NextSingle().ToString()); break;

        }
    }
    return arr;
}
List<string>arr=  GetList(int.Parse(Console.ReadLine()));
foreach(string r in arr)
{
    Console.WriteLine(r);
}
