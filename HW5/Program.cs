//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
3, 5 -> 243 (3⁵)
2, 4 -> 16
*//*


int Pu()
{
	int dd = 1;
	Console.Write("Write number A ");
	int numA = Convert.ToInt32(Console.ReadLine());
	Console.Write("Write number B ");
	int numB = Convert.ToInt32(Console.ReadLine());

	for(int i = 0; i < numB; i++)
	{
		dd = dd * numA;
	}
	return dd;
}

int bat = Pu();
Console.WriteLine(bat);


//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
452 -> 11
82 -> 10
9012 -> 12
*//*


int SumNum(int num)
{
	int kek = 0;
	while (num > 0)
	{
	    kek = kek + num % 10;
	    num = num / 10;	
	}
	return kek;
}	

int gag = new Random().Next(10, 9999);
Console.WriteLine(gag + " Your Number ");
Console.Write(SumNum(gag)+" Number summ");


//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*//*


int[] RndMass()                         
{
	int size = 8;
	int[] mass = new int[size];
	Random rand = new Random();

	for (int i = 0; i < size; i ++)
	{
		mass[i] = rand.Next(10, 99);
	}
	return mass;
}

int[] massive = RndMass();
var str = "[" + string.Join(", ", massive) + "]";
Console.WriteLine(str);

*/
