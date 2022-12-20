money a = new money("10","р.","90","коп.");
money b = new money("50", "р.", "15", "коп.");
money c = new money();
money d = new money();
c = Sum(a, b);
d = Difference(a, b);
c.Print(); d.Print();
b.PrintTransferCost(0.05);
static money Sum(money a, money b)
{
    money c = new money();
    c.cops = a.cops + b.cops;
    c.rub = a.rub + b.rub;
    if (c.cops >= 100) { c.rub++; c.cops -= 100; }
    return c;
}
static money Difference(money a, money b)
{
    money c = new money();
    c.cops = a.cops - b.cops;
    c.rub = a.rub - b.rub;
    if (c.cops < 0) { c.rub--; c.cops += 100; }
    return c;
}
class money
{
    public double rub, cops;
    public bool check;
    public money()
    {
        rub = 0;cops = 0;check = true;
    }
    public money(string s,string s1)
    {
        rub = 0;cops = 0;check = true;
        if (double.Parse(s) < 0) { Console.WriteLine("Не может быть отрицательным!");check = false; }
        if (s1 == "р.") { rub = double.Parse(s); }
        if (s1 == "коп.") { cops = double.Parse(s); }
        while(cops>=100){
          rub += 1;
          cops -= 100;
        }
    }
    public money(string s1, string s2, string n1, string n2)
    {
        rub = 0;cops=0;
        if (s2 == "коп.") { Console.WriteLine("Рубли и копейки перепутаны местами!"); check = false; }
        else if (double.Parse(s1) < 0 || double.Parse(n1) < 0) { Console.WriteLine("Не может быть отрицательным!"); check = false; }
        else
        {
            if (s2 == "р.") { rub = double.Parse(s1); }
            if (n2 == "коп.") { cops = double.Parse(n1); }
        }
    }
    public void PrintTransferCost(double com)
    {
        cops += rub * com * 100 + cops*com;
        cops=Math.Round(cops);
        while (cops >= 100)
        {
            rub += 1;
            cops -= 100;
        }
        if (rub == 0) { Console.WriteLine($"{cops} коп."); }
        else Console.WriteLine($"{rub} р. {cops} коп.");

    }
    public void Print()
    {
        if (check)
        {
            if (rub == 0) { Console.WriteLine($"{cops} коп."); }
            else Console.WriteLine($"{rub} р. {cops} коп.");
        }
    }
}
