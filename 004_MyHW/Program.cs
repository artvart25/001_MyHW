
/*
  int SumNumber(int numN)
  {  
    int counter = Convert.ToString(numN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
    advance = numN - numN % 10;
    result = result + (numN - advance);
    numN = numN / 10;
    }
   return result;
  }

Console.Write("Input a number: ");
int numN = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(numN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
*/

/*
Console.Write("Input numbers. Use , : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";

string RemovingSpaces (string series)
{
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

void СheckNumber2 (int  series)
{

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

      }
}

int[] ArrayOfNumbers(string seriesNew)
{ 

  int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

string seriesNew = RemovingSpaces(seriesOfNumbers);
int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);
PrintArry(arrayOfNumbers);
*/
