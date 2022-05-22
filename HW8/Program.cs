// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

int[,] RndTwoDimensionalArray()                         
{
	int sizeI = new Random().Next(6, 6);
    int sizeJ = new Random().Next(4, 4);

	int[,] tdarray = new int[sizeI, sizeJ];
	Random rand = new Random();

    
	for (int i = 0; i < sizeI; i ++)
	{
        
        for (int j = 0; j < sizeJ; j ++)
        {
            tdarray[i,j] = rand.Next(10, 50);
            Console.Write($"{tdarray[i,j]} ");
        
        }
    Console.WriteLine();
	}
Console.WriteLine();
return tdarray;
}

int [,] OrderTDA(int[,] tdaMass)
{
    Console.WriteLine("Sort Mass");
    for (int i = 0; i < tdaMass.GetLength(0); i++)
    {           
        for (int j = 0; j < tdaMass.GetLength(1); j++)
        {
            for (int k = 0; k < tdaMass.GetLength(1); k++)
            {
                if (tdaMass[i, j] < tdaMass[i, k])
                {
                    int dd = tdaMass[i, j];
                    tdaMass[i, j] = tdaMass[i, k];
                    tdaMass[i, k] = dd;
                }
            }
        }
    }  
    Console.WriteLine();
return tdaMass;   
}

void Print(int [,] tdaMass)
{
    for (int i = 0; i < tdaMass.GetLength(0); i++, Console.WriteLine())
    {
        for (int j = 0; j < tdaMass.GetLength(1); j++)
        {
        Console.Write($"{tdaMass[i,j]} ");
        }
    }
}



//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void SummMatrixString(int [,] summMass)
{
    
    // int [] sumString = new int [summMass.GetLength(0)];    
    // int str = 0;
    // int minElem = 0;


    int minSumString = 0;
    int sum = 0;
    int index = 0;

    for(int i = 0; i < summMass.GetLength(0); i++)
    {
        sum = 0;

        for(int j = 0; j < summMass.GetLength(1); j++)
        { 

            sum += summMass[i,j];
            
        }

        if(minSumString > sum)
        {
            minSumString = sum;
            index = i;
        }

        if(i == 0)
        {
            minSumString = sum;
            index = i;
        }

    }
    Console.WriteLine("Sum num string = {0} String minimal sum elemets = {1}", minSumString, index+1);

}

// Это через массив. Создал массив в котором по строчно выводится сумма а затем сравнивается. Это я придумал пока думал как сделать по проще))))

/*  
    
    sumString[i] = sum;      
    Console.WriteLine((i+1)+ " string "+ "sum elements " + $"{sumString[i]} ");
    }
    
    minElem = sumString[0];
    
    for(int i = 0; i < sumString.Length; i++)
    {
        if(sumString[i] < minElem)
        {
            minElem = sumString[i];
            str = i;
        }

    }
    
    Console.WriteLine("String minimal summ elements = {0}  summa elements = {1} ", (str + 1), minElem );

}
*/

int[,] chobit = RndTwoDimensionalArray();
Print(OrderTDA(chobit));
SummMatrixString(chobit);




//Задача 62. Заполните спирально массив 4 на 4.

int [,] TdaArr()
{
	int sizeI = 4;
    int sizeJ = 4;
    int n = 1;

	int[,] tdarray = new int[sizeI, sizeJ];

    
	for (int i = 0; i < sizeI; i ++)
	{
        
        for (int j = 0; j < sizeJ; j ++)
        {
            tdarray[i,j] = n;
            Console.Write($"{tdarray[i,j]} ");
            n += 1;
        }
    Console.WriteLine();
	}
Console.WriteLine();
return tdarray;
}



int [,] Spiralka(int [,] spiro)
{

    int ib = 0;
    int jb = 1;
    int ryad = 2;
    int colonna = 1;
    int pupa = 0;
    int proh = 2;
 
    for (int i = 0; i < spiro.Length; i++) 
    {
        spiro[ryad, colonna] = i + 1;
        
        if (--proh == 0)
        {
            proh = 1 + (pupa + 1) / 2;
            int num = ib;
            ib = -jb;
            jb = num;
            pupa++;
        }
 
        colonna -= ib;
        ryad -= jb;   
    }
return spiro;
}


int [,] spir = TdaArr();
Print(Spiralka(spir));
*/


