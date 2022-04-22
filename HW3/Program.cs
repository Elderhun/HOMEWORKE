//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
14212 -> нет
12821 -> да
23432 -> да
*//*


void Palindrome(int num)
{
    int numSave = num;
    int lol = 0;
    int kek = 0;
    while (num > 0)
    {
        lol = num % 10;
        kek = kek * 10 + lol;
        num = num / 10;
    }
    if(numSave == kek )
    {
        Console.WriteLine(kek + " = " + numSave + " - " + "Its palindrome");
    }
    else
    {
        Console.WriteLine(kek + " Not a palindrome " + numSave);
    }
}

Console.WriteLine("Write NUmber");
int babble = Convert.ToInt32(Console.ReadLine());
Palindrome(babble);


//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*//*


double TriDe(double xA, double xB, double yA, double yB, double zA, double zB)
{
    return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
}

Console.Write("Write x1 ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Write y1 ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Write z1 ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Write x2 ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Write y2 ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Write z2 ");
double z2 = Convert.ToDouble(Console.ReadLine());

double resultatik = TriDe(x1, x2, y1, y2, z1, z2);

Console.WriteLine(Math.Round(resultatik,2)); //Хотел чтобы такой же ответ был как в задании))


//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*//*


void Cube(int num)
{
    int numZ = 1;
    double del = 0;
    
    while(numZ <= num) 
    {
        del = Math.Pow(numZ,3);
        Console.WriteLine(numZ + " cubed = " + del);
        numZ ++ ;
    }
}

Console.Write("Write Number ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numB < 1)
{
    Console.WriteLine("Wrong Number");
}

Cube(numB);

