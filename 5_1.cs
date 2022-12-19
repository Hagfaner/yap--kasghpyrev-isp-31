var myWatch = new Watch("Casio", "electronic", 15.99M);
myWatch.Print();
class Watch
{
    public string name1, name2;
    public decimal  number;
    public Watch(string name3,string name4,decimal num)
    {
        name1=name3;
        name2=name4;
        number=num;
    }
    public void Print()
    {
        Console.WriteLine($"{name1} {name2} {number}");
    }
}
