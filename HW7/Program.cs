// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


int[,] RndTwoDimensionalArray()                         
{
	int sizeI = new Random().Next(3, 5);
    int sizeJ = new Random().Next(3, 5);

	int[,] tdarray = new int[sizeI, sizeJ];
	Random rand = new Random();

    
	for (int i = 0; i < sizeI; i ++)
	{
        
        for (int j = 0; j < sizeJ; j ++)
        {
            tdarray[i,j] = rand.Next(5, 50);
            Console.Write($"{tdarray[i,j]} ");
        }
    Console.WriteLine();
	}
return tdarray;
}

int[,] doubleArr = RndTwoDimensionalArray();


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/


Console.Write("Input vertical position: ");
int iPos = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input horizontal position: "); 
int jPos = Convert.ToInt32(Console.ReadLine());


if(iPos > doubleArr.GetLength(0) || jPos > doubleArr.GetLength(1))
{
    Console.WriteLine("There is no number with such coordinates");
}
else
{
    int numberPos = doubleArr[iPos - 1, jPos - 1];
    Console.WriteLine(numberPos);
}


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/



for (int j = 0; j < doubleArr.GetLength(1); j++) 
{    
    
    double summa = 0;
    for (int i = 0; i < doubleArr.GetLength(0); i++)
    {

        summa += (doubleArr[i,j]);

    }
   Console.Write("среднее арефметическое столбца " + (j + 1) + " - " + Math.Round(summa / doubleArr.GetLength(0),2) + "; ");
    
    

}           

