using System;

Console.WriteLine("Max number: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Check multiplyers for");
Console.WriteLine("1:");
int multiplyer1 = int.Parse(Console.ReadLine());
Console.WriteLine("2:");
int multiplyer2 = int.Parse(Console.ReadLine());
for (int x=1; x < max; x++)
{
    if (x%multiplyer1==0 && x%multiplyer2==0)
    {
        Console.WriteLine(x);
    }
}