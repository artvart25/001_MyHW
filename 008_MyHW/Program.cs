/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int [rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue,maxValue + 1);
    
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

int [,] SortArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
    return array;
}

int minSum(int [,] myArray)
{
    int minSumR = 0;
    int sumR = SumElementsOfRows(myArray, 0);
    for (int i = 1; i < myArray.GetLength(0); i++)
    {
    int tempSumR = SumElementsOfRows(myArray, i);
    if (sumR > tempSumR)
    {
        sumR = tempSumR;
        minSumR = i;
    }
    }
    return minSumR;
}

int SumElementsOfRows(int[,] array, int i)
{
    int sumR = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumR += array[i,j];
    }
    return sumR;
}
*/
/*
//1
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nOriginal array: ");
int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.WriteLine($"\nSorted array: ");

SortArray(myArray);
Show2dArray(SortArray(myArray));
*/

/*
//2
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nOriginal array: ");
int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

int sumR = SumElementsOfRows(myArray, 0);

int minSumR = minSum(myArray);




Console.WriteLine($"\nRow with minimal total is: {minSumR + 1}");
*/

/*
//3
int n = 4;
int[,] sqArray = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqArray.GetLength(0) * sqArray.GetLength(1))
    {
    sqArray[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqArray.GetLength(1) - 1)
    j++;
    else if (i < j && i + j >= sqArray.GetLength(0) - 1)
    i++;
    else if (i >= j && i + j > sqArray.GetLength(1) - 1)
    j--;
    else
    i--;
    }

Show2dArray(sqArray);
*/