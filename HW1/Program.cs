﻿// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*//*

Console.Write("Write first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number ");
int b = Convert.ToInt32(Console.ReadLine());


if(a == b)
{
Console.Write(a + " = " + b);
}
else if(a > b)
{
Console.Write("max " + a + " > " + "Min " + b);
}
else
Console.Write("max " + b + " > " + "Min " + a);


//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*//*

Console.Write("Write first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Write third number ");
int c = Convert.ToInt32(Console.ReadLine());
int numMax = a;

if(a > numMax) numMax = a;
if(b > numMax) numMax = b;
if(c > numMax) numMax = c;

Console.Write("Max number " + numMax);


//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
4 -> да
-3 -> нет
7 -> нет
*//*

Console.WriteLine("Write number");
int num = Convert.ToInt32(Console.ReadLine());
int gg = 0;

if(num % 2 == 0)
{
    gg = num % 2;
    Console.Write(gg + " remainder, even number");
}
else
{
    gg = num % 2;
    Console.Write(gg + " remainder, odd number");
}


//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
5 -> 2, 4
8 -> 2, 4, 6, 8
*//*

Console.WriteLine("Write number");
int num = Convert.ToInt32(Console.ReadLine());
int even = 1;

while(even <= num)
{
   if(even % 2 == 0)
    Console.Write(even + " ");
    even ++;
}

*/