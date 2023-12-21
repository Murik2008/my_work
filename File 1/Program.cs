// The day:
// The temperature, the time.
void Temperature(int t)
{
    if (t>40) Console.WriteLine("It's too hot!");
    if (t<40 && t>15) Console.WriteLine("it's warm!");
    if (t<15 && t>0) Console.WriteLine("It's going to be cold!");
    if (t<0 && t>-10) Console.WriteLine("It's cold!");
    if (t<-10) Console.WriteLine("It's very cold!");

}
Console.WriteLine("What is the temperature?");
int t = Convert.ToInt32(Console.ReadLine());
Temperature(t);
void TodayData(int y, int m, int d)
{
    if (m==1) Console.WriteLine($"The {d} of January, {y}");
    if (m==2) Console.WriteLine($"The {d} of February, {y}");
    if (m==3) Console.WriteLine($"The {d} of March, {y}");
    if (m==4) Console.WriteLine($"The {d} of April, {y}");
    if (m==5) Console.WriteLine($"The {d} of May, {y}");
    if (m==6) Console.WriteLine($"The {d} of June, {y}");
    if (m==7) Console.WriteLine($"The {d} of July, {y}");
    if (m==8) Console.WriteLine($"The {d} of August, {y}");
    if (m==9) Console.WriteLine($"The {d} of September, {y}");
    if (m==10) Console.WriteLine($"The {d} of October, {y}");
    if (m==11) Console.WriteLine($"The {d} of November, {y}");
    if (m==12) Console.WriteLine($"The {d} of December, {y}");
    if (m==2 && d==24) Console.WriteLine($"IT'S MY BIRTHDAY!");
    if (m==12 && d==31) Console.WriteLine("Happy New Year!");
}
Console.WriteLine("What is a year now?");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is a month now?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is a day now?");
int d = Convert.ToInt32(Console.ReadLine());
TodayData(y,m,d);