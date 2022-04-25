//
int[] RndMass()                            //Туто рандомно делаецо массиve с random size и случайными numbers )))
{
	int size = new Random().Next(3, 9);
	int[] mass = new int[size];
	Random rand = new Random();

	for (int i = 0; i < size; i ++)
	{
		mass[i] = rand.Next(100, 999);
	}
	return mass;
}
//
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
[345, 897, 568, 234] -> 2
*//*


int EvenNum(int[] massiv)
{
	int result = 0;
	for(int i = 0; i < massiv.Length; i++)
	{
	if(massiv[i] % 2 == 0)
		{
		result ++;
		}
	}
	return result;
}

int[] chobit = RndMass();
var str = string.Join(" ", chobit);
Console.Write(str + " четных элементов ");
Console.WriteLine(EvenNum(chobit));


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*//*


int EvenNum(int[] massiv)
{
	int result = 0;
	for(int i = 0; i < massiv.Length; i++)
	{
	if(massiv[i] % 2 == 1)
		{
		result = massiv[i] + result;
		}
	}
	return result;
}

int[] dobi = RndMass();
var summ = string.Join(" ", dobi);
Console.Write(summ + " сумма нечетных элементов ");
Console.WriteLine(EvenNum(dobi));



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
[3 7 22 2 78] -> 76
*/


void MaxMin(int[] massiv)
{
	int maxNumMass = massiv[0];
	int minNumMass = massiv[0];
	for(int i = 1; i < massiv.Length; i++)
	{	
		if(massiv[i] > maxNumMass)
		{
			maxNumMass = massiv[i];
		}
		else if(massiv[i] < minNumMass)
		{
			minNumMass = massiv[i];
		}
	}
	Console.WriteLine("Максимальное число " + maxNumMass + " минимальное число " + minNumMass);
	Console.WriteLine(maxNumMass - minNumMass + " Разница между максимальным и минимальным числом");
}


int[] masik = RndMass();
var mass = string.Join(" ", masik);
Console.WriteLine(mass + " массивчек");
MaxMin(masik);




