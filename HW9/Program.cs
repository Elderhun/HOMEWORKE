// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.



int SumFnumToSnum(int num1, int num2)
{
    int sum = 0;
    
    if (num1 <= num2)
    {
        sum += num1;
        return num1 + SumFnumToSnum(num1 + 1, num2);
    }
    return sum;
}



Console.Write("Input first number ");
int fNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number ");
int sNum = Convert.ToInt32(Console.ReadLine());


int sumNums = SumFnumToSnum(fNum, sNum);

Console.WriteLine("Sum first to second nums = {0}", sumNums);




//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// Максимально тупой вариант))



Console.Write("Input number ");
string numKa = Convert.ToString(Console.ReadLine());

int sum = 0;


for(int i = 0; i < numKa.Length; i++)
{
    sum += Convert.ToInt32(numKa[i].ToString());
}    

Console.WriteLine("Number summ = {0}", sum);


//продублированный вариант из 5 дз.


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
