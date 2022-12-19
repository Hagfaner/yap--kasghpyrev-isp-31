
dots s=new dots(), f=new dots();
int x, y, z;
bool fly=true;
x=int.Parse(Console.ReadLine());
y=int.Parse(Console.ReadLine());
z=int.Parse(Console.ReadLine());
if (y == 0)
{
    fly=false;

}
if (fly)
{
    Console.WriteLine("Муха не на полу");
}
else
{
    f.input(x, y, z);
    x = int.Parse(Console.ReadLine());
    y = int.Parse(Console.ReadLine());
    z = int.Parse(Console.ReadLine());
    s.input(x, y, z);
    Console.WriteLine(f.line(s.x, s.y, s.z));
    Console.WriteLine(f.upline(s.x, s.y, s.z));
}
class dots
{
    public int x,y,z;
    public dots() { x = 0;y = 0;z = 0; }
    public void input(int x1, int y1, int z1)
    {
        x = x1;
        y = y1;
        z = z1;
    }
    public double line(int xs,int ys,int zs)
    {
  
        return (Math.Round(Math.Sqrt( Math.Pow(xs-x,2)+Math.Pow(ys-y,2)+Math.Pow(zs-z,2) ), 5));
    }
    public double upline(int xs, int ys, int zs)
    {
        double up = Math.Abs(ys - y);
        double ground = Math.Sqrt(Math.Pow(xs - x, 2) + Math.Pow(zs - z, 2));
        return Math.Round(up + ground,5);
    }
}
