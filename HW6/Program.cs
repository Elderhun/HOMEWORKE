//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*//*


int[] Numica()
{
    int size = new Random().Next(5, 10);
    int[] mass = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Write numbers ");
        mass[i] = Convert.ToInt32(Console.ReadLine());
    }

    return mass;
}

int NumNu(int[] mass)
{
    int det = 0;

    for(int i = 0; i < mass.Length; i++)
    {
        if(mass[i] > 0)
        {
            det ++;
        }
        
    }
    return det;
}   


int[] matik = Numica();
var str = "[" + string.Join(", ", matik) + "]";
Console.WriteLine(str);
Console.WriteLine(NumNu(matik)+ " Числа больше 0");


//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
45 -> 101101
3 -> 11
2 -> 10
*//*

string DecNum()
{
    Console.WriteLine("Write decimal num");
    int numka = Convert.ToInt32(Console.ReadLine());     
    string numDV = "";

    while (numka > 0)
    {

        numDV = ((numka % 2).ToString() + numDV);
        numka = numka / 2;

    }
    return numDV;
}

var numich = DecNum();
Console.WriteLine(numich);

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*//*


void Cord()
{
    
    Console.WriteLine("Write b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Write k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Write b2");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Write k2");
    double k2 = Convert.ToInt32(Console.ReadLine());

    double x;
    double y;

    if(k1 == k2 & b1 == b2)
    {   
    Console.WriteLine("Прямые совпадают");
    }   
    
    else if(k1 == k2 & b1 != b2)
    {
    Console.WriteLine("Прямые параллельные");
    }
    

    else
    {
        x = (b1 - b2) / (k2 - k1);
        y = (k1 * x + b1);
        Console.Write($"({Math.Round(x, 2)}; {Math.Round(y, 2)})");
    }
    
    
}

Cord();

*/