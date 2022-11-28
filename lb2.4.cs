string a=Console.ReadLine();
string[] b = a.Split(",");
bool two = false, three = false, four = false;
int five = 0;
foreach (string n in b)
{
	if(n=="2") two= true;
	if(n=="3") three= true;
	if(n=="4") four= true;
	if(n=="5") five++;
}
if (two) Console.WriteLine("Ну что, студент, пора долг Родине отдать");
else if (three) Console.WriteLine("Прощай стипендия!");
else if (four) Console.WriteLine("Живи пока, через полгода увидимся");
else if (five == 4) Console.WriteLine("О, отличник появился! На олимпиаду пойдешь");
