/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int [rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue,maxValue + 1);
    
    return newArray;
}

double [,] CreateRandomD(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArrayD = new double [rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArrayD[i,j] = new Random().NextDouble() * 20 - 10;
    
    return newArrayD;
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

void ShowArrayD(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            double alignNumber = Math.Round(array[i,j], 1);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
        
    }
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

Double[,] myArrayD = CreateRandomD(m, n, min, max);
ShowArrayD(myArrayD);
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

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.Write("Input number of row:");
int p1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input number of column:");
int p2 = Convert.ToInt32(Console.ReadLine()) - 1;

if (p1 < 0 | p1 > myArray.GetLength(0) - 1 | p2 < 0 | p2 > myArray.GetLength(1) - 1)
{
    Console.WriteLine("Element not found");
}
    else
    {
        Console.WriteLine("Number of array is = {0}", myArray[p1, p2]);
    }

*/

/*
//3
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

for (int i = 0; i < n; i++)
{
  double avg = 0;
  for (int j = 0; j < m; j++)
  {
    avg += myArray[j, i];
  }
  avg = Math.Round(avg / m, 2);
  Console.WriteLine($"Average of column № {i+1} is: {avg}");
}
*/