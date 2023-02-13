/*Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.
 2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Clear();
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = int.Parse(Console.ReadLine());
while(a==b&&a==c)
{Console.WriteLine("Все введенные числа равны!");
return;}
while(a==b)
{if (a>c)
{Console.WriteLine($"{a}, {b}, {c} -> max = {a}, при этом первое и второе числа равны между собой");}
else
{Console.WriteLine($"{a}, {b}, {c} -> max = {c}");}
return;}
while(a==c)
{if (a>b)
{Console.WriteLine($"{a}, {b}, {c} -> max = {a}, при этом первое и третье числа равны между собой");}
else
{Console.WriteLine($"{a}, {b}, {c} -> max = {b}");}
return;}
while(b==c)
{if (a>b)
{Console.WriteLine($"{a}, {b}, {c} -> max = {a}");}
else
{Console.WriteLine($"{a}, {b}, {c} -> max = {b}, при этом второе и третье числа равны между собой");}
return;}
if (a>b&&a>c)
{Console.WriteLine($"{a}, {b}, {c} -> max = {a}");}
else if (b>a&&b>c)
{Console.WriteLine($"{a}, {b}, {c} -> max = {b}");}
else if (c>a&&c>b)
{Console.WriteLine($"{a}, {b}, {c} -> max = {c}");}
