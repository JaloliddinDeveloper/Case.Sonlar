//20__yigirma h.k
bool s,h;
int m,y,o,b,n =int.Parse(Console.ReadLine());
m = n / 1000;
s = n / 1000 > 0;
y = (n % 1000) / 100;
h = (n % 1000) / 100 > 0;
o = (n % 100) / 10;
b = n % 10;
switch (m)
{
    case 1:
        Console.Write("bir "); break;
    case 2:
        Console.Write("ikki "); break;
    case 3:
        Console.Write("uch "); break;
    case 4:
        Console.Write("to'rt "); break;
    case 5:
        Console.Write("besh "); break;
    case 6:
        Console.Write("olti "); break;
    case 7:
        Console.Write("yetti "); break;
    case 8:
        Console.Write("sakkiz "); break;
    case 9:
        Console.Write("to'qiz "); break;
}
switch (s)
{
    case true:
        Console.Write("ming "); break;
}

switch (y)
{
    case 1:
        Console.Write("bir "); break;
    case 2:
        Console.Write("ikki "); break;
    case 3:
        Console.Write("uch "); break;
    case 4:
        Console.Write("to'rt "); break;
    case 5:
        Console.Write("besh "); break;
    case 6:
        Console.Write("olti "); break;
    case 7:
        Console.Write("yetti "); break;
    case 8:
        Console.Write("sakkiz "); break;
    case 9:
        Console.Write("to'qiz "); break;
}
switch (h)
{
    case true:
        Console.Write("yuz "); break;
}
switch (o)
{
    case 1:
        Console.Write("o'n "); break;
    case 2:
        Console.Write("yigirma "); break;
    case 3:
        Console.Write("o'ttiz "); break;
    case 4:
        Console.Write("qirq "); break;
    case 5:
        Console.Write("ellik "); break;
    case 6:
        Console.Write("oltmush "); break;
    case 7:
        Console.Write("yetmush "); break;
    case 8:
        Console.Write("sakson "); break;
    case 9:
        Console.Write("to'qson "); break;
}
switch (b)
{
    case 1:
        Console.Write("bir"); break;
    case 2:
        Console.Write("ikki"); break;
    case 3:
        Console.Write("uch"); break;
    case 4:
        Console.Write("to'rt"); break;
    case 5:
        Console.Write("besh"); break;
    case 6:
        Console.Write("olti"); break;
    case 7:
        Console.Write("yetti"); break;
    case 8:
        Console.Write("sakkiz"); break;
    case 9:
        Console.Write("to'qiz"); break;
}