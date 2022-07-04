/*
int TwoNumber()
{
    int num;
    Console.Write("Input a number: ");
    num = Convert.ToInt32(Console.ReadLine());

    int one = num / 10;
    int two = one % 10;

    int result = two;
    return result;
}

int num = TwoNumber();
Console.WriteLine("Result is " + num);

*/

/*
string ThirdNumber()
{
    Console.Write("Input a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string numText = Convert.ToString(num);
    if (numText.Length > 2)
    {
        Console.WriteLine("Third number is " + numText[2]);
    }
    else 
    {
        Console.WriteLine("No third number");
    }
    return numText;
}
string number = ThirdNumber();

*/

/*
void CheckingTheDayOfTheWeek () 
{
    Console.Write("Input a number of the day of the week ");
    int dayNum = Convert.ToInt32(Console.ReadLine());

    if (dayNum == 6 || dayNum == 7) 
    {
    Console.WriteLine("This day is holiday >> yes");
    }
    else 
    if (dayNum < 1 || dayNum > 7) 
    {
    Console.WriteLine("This day is not a day of the week");
    }
    else 
    {
        Console.WriteLine("This day is holiday >> no");
    }
}
CheckingTheDayOfTheWeek();
*/