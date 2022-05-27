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


int SumNum(int number)
{

    if(number==0) return 0;
    {
        return number % 10 + SumNum(number/10);
    }

}

Console.Write("Write number ");
int number = Convert.ToInt32(Console.ReadLine());
int summa = SumNum(number);
Console.WriteLine(summa);

