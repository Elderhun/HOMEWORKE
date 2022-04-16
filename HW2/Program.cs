//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
456 -> 5
782 -> 8
918 -> 1
*//*


void Pipka(int heh)
{
while(heh > 100) 
heh = heh / 10;
heh = heh % 10;
Console.WriteLine(heh);
}

int bob = new Random().Next(100, 999);
Console.Write(bob + " second number ");
Pipka(bob);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*//*


void Puca(int marevo)
{
    if(marevo < 100)
    {
        Console.WriteLine(" No third number");
    }
    else
    {
        while(marevo > 1000) 
        marevo = marevo / 10;
        marevo = marevo % 10;
        Console.Write(" third number " + marevo);
    }
}

int magic = new Random().Next(10, 9999);
Console.Write(magic);
Puca(magic);

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
6 -> да
7 -> да
1 -> нет
*/

void Week(int day)
{
    if(day < 6)
    {
        Console.WriteLine("Today is a working day");
    }
    else
    {
        Console.WriteLine("Today is a day off");
    }
}

Console.WriteLine("Write number day");
int day = Convert.ToInt32(Console.ReadLine());
Week(day);

