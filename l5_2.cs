MyString a=new MyString();
a.input();
Console.WriteLine(a.reverce());
Console.WriteLine(a.UcFirst());
Console.WriteLine(a.UcWords());
class MyString
{
    public string str;
    public MyString()
    {
        str = "";
    }
    public void input()
    {
        str = Console.ReadLine();
    }
    public string reverce()
    {
        string str1 = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            str1 += str[i];
        }
        return str1;
    }
    public string UcFirst()
    {

        return (str.Substring(0, 1).ToUpper() + str.Substring(1));
    }
    public string UcWords()
    {
        string[] str1 = str.Split(' ');
        string str2="";
        for (int i = 0; i < str1.Length; i++)
        {
            str2 += str1[i].Substring(0, 1).ToUpper() + str1[i].Substring(1)+" ";
        }
        return str2;
    }
}
