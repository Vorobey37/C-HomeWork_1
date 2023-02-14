/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8*/

Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int a = int.Parse(Console.ReadLine());
while (a<-999||a>-100&&a<100||a>999)
{Console.WriteLine($"Число {a} - это не ТРЕХЗНАЧНОЕ число!!!");
Console.WriteLine("Введите трёхзначное число:");
a = int.Parse(Console.ReadLine());}
if (a>0)
{Console.WriteLine($"{a} -> {a%10}");}
else {Console.WriteLine($"{a} -> {-a%10}");}
