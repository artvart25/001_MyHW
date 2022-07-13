
int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

/*
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[]array = CreateArray(size);

int Comparison(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}
Console.WriteLine($"Quantity of elements > 0 is: {Comparison(array)} ");

ShowArray(array);
*/

/*
double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Input factor {i+1} to (y = k * x + b):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Input factor k: ");
      else Console.Write($"Input factor b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.WriteLine($"\nStraight lines match");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.WriteLine($"\nStraight lines are parallel");
  }
  else 
  {
    Decision(coeff);
    Console.WriteLine($"\nPoint of intersection of straight lines: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(coeff);
*/