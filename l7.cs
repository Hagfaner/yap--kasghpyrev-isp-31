using System.IO;
using static System.Net.WebRequestMethods;

Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();
string path = "d:\\recipes.txt";
StreamReader file = new StreamReader(path);
List<string> dish = new List<string>() { "Фахитос", "Омлет" };

while (!file.EndOfStream)
{
    string bufname = file.ReadLine();
    int count = Convert.ToInt32(file.ReadLine());
    List<string> values = new List<string>();
    for (int i = 0; i < count; i++)
    {
        string str = file.ReadLine();
        string[] str1 = str.Split(" | ");
        for (int it = 0; it < 3; it++)
        {
            if (it == 0)
            {
                values.Add("ingredient_name");

            }
            else if (it == 1)
            {
                values.Add("quantity");
            }
            else
            {
                values.Add("measure");
            }
            values.Add(str1[it]);
        }

    }
    book.Add(bufname, values);
    file.ReadLine();
}
/*foreach (var item in book)
{
    int c = 0;
    Console.WriteLine(item.Key);
    foreach (var item1 in item.Value)
    {

        Console.Write($"{item1} ");
        c++;
        if (c == 6) { Console.WriteLine(); c = 0; }
    }
    Console.WriteLine();
}*/
get_shop_list_by_dishes(dish, 2, book);
//----------------------------------------------------------------


System.IO.File.WriteAllText("d:\\fin.txt", "");
int i1 =1;
string path1 = $"d:\\{i1}.txt";
FileInfo file1 = new FileInfo(path1);
Dictionary<string, int> c = new Dictionary<string, int>();
do
{   string[] a= System.IO.File.ReadAllLines(path1);
    c.Add($"{i1}.txt", a.Length);
    i1++;
    path1= $"d:\\{i1}.txt";
    
    file1 = new FileInfo(path1);
    
} while (file1.Exists);

path1 = "d:\\fin.txt";
file1 = new FileInfo(path1);
int min_l = c["1.txt"];
string min_k = "";
int j = c.Count;
for (int i = 0; i < j; i++)
{
    min_l= 65536;
    //
    foreach (var item1 in c)
    {
        if (item1.Value < min_l)
        {
            min_l = item1.Value;
            min_k = item1.Key;
        }
    }
    //
    System.IO.File.AppendAllText("d:\\fin.txt",$"{min_k}\n");
    string path2 = $"d:\\{min_k}";
    string[] a = System.IO.File.ReadAllLines(path2);
    foreach (var str in a)
    {
        System.IO.File.AppendAllText("d:\\fin.txt", $"{str}\n");
    }
    c.Remove(min_k);
}


static Dictionary<string, List<string>> get_shop_list_by_dishes(List<string> dih, int pers, Dictionary<string, List<string>> book)
{
    List<string> ing = new List<string>();
    foreach (var item in book)
    {
        foreach (var item1 in dih)
        {
            if (item.Key == item1)
            {
                foreach (var item3 in item.Value)
                {
                    ing.Add(item3);
                }
                
            }
        }
    }
    List<string> s1 = new List<string>();
    Dictionary<string, List<string>> f_dish = new Dictionary<string, List<string>>();
      for (int i = 1; i < ing.Count; i+=6)
        {
            s1.Add(ing[i]);
        }
    s1=s1.Distinct().ToList();
      
    
    foreach (var item in s1)
    {
        List<string> strings = new List<string>();
        double sum = 0;
        string m="";
        for (int i = 1; i < ing.Count; i+=6)
        {
        
    
           if (ing[i] == item)
           {
                sum += Convert.ToDouble(ing[i + 2]);
                m = ing[i + 4];
           }
        }
        strings = new List<string>() { "measure", m, "quantity", Convert.ToString(sum * pers) };
        f_dish.Add(item, strings);
    }
    foreach (var item in f_dish)
    {
        Console.Write($"{item.Key}: ");
        foreach (var item2 in item.Value)
        {
            Console.Write($"{item2} ");
        }
        Console.WriteLine();
    }
    return f_dish;
}
