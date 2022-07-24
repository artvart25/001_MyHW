/*
//1
int getDigits(int n1, int nodigits)
    {
    if (n1 == 0)
        return nodigits;
    return getDigits(n1 / 10, ++nodigits);
    }


Console.Write("Input N : ");
int num = Convert.ToInt32(Console.ReadLine());           
Console.WriteLine("\n The number {0} included digits : {1} ",num,getDigits(num, 0));
*/

/*
//2
Console.WriteLine("Введите начальное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

void SumMN(int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Sum in gap from M to N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    SumMN(numberM, numberN, sum);
}

SumMN(numberM, numberN, 0);
*/