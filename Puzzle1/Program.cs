using System;


for (int x=0; x <= 9; x++)
{
    string i = "";
    for (int j=0; j <= 9; j++)
    {
        var bla = x;
        var bla2 = j;
        if (x==j || x+j==9)
        {
            i += "[x]";
        }
        else
        {
            i += "[0]";
        }
    }
    Console.WriteLine(i);
};

string? v = Console.ReadLine();