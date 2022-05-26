//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

string[] StringArr()
{
    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string dd = string.Empty;
    Random rnd = new Random();
    int position = 0;
    string[] str = new string[6];

    for (int i = 0; i < 6; i++)
    {
        dd = string.Empty;
        
        for(int j = 0; j < 3; j++)
        {

            position = rnd.Next(0, alphabet.Length);
            dd += Convert.ToString(alphabet[position]);
            
        
        }
    
        str[i] = Convert.ToString(dd);
        
    }

return str;
}
/*
void Vowels(string[] strArrVowels)
{
    string vowels = "AEIOUY";

    string word = string.Empty;

    int vowelsWord = 0;

    for (int i = 0; i < 6; i++)
    {
        word = Convert.ToString(strArrVowels[i]);
        
        for(int j = 0; j < vowels.Length; j++)
        {

            if(word[0] == vowels[j])
            {
                vowelsWord += 1;
        
            }
        }
    }

    Console.WriteLine(vowelsWord);
}

string[] strArr = StringArr();
string str = "[" + string.Join(", ", strArr) + "]";
Console.WriteLine(str);
Vowels(strArr);
*/


//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.




string[] PairedElements(string[] strArrTwo)
{
    
    string gluing = string.Empty;

    string[] strArrPaired = new string[strArrTwo.Length/2];

    for(int i = 0; i < strArrTwo.Length/2; i++)
    {
        
        gluing = string.Empty;

        for(int j = i; j < i+1; j++)
        {
        
            gluing += Convert.ToString(strArrTwo[i*2]+strArrTwo[i*2+1]);
        
        }
        
        strArrPaired[i] = Convert.ToString(gluing);
    
    }
    
    return strArrPaired;

}

string[] strArrP = StringArr();
string[] paired = PairedElements(strArrP);
string str = "[" + string.Join(", ", paired) + "]";
Console.WriteLine(str);