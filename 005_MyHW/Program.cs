
//массив random
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

//массив с вводом
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

//массив
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

/*
//1Zadacha
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int QuantityPositive(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ )
    {
    if (array[i] % 2 == 0)
    {
      quantity++;
    }
    }
  return quantity;
}
int quantity = QuantityPositive (array);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
*/

/*
//2Zadacha

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[]array = CreateArray(size);

int sum = 0;

for (int i = 0; i < size; i+=2)
    sum = sum + array[i];

    Console.WriteLine($"Total indexes is {size}, sum of numbers in not positive indexes is = {sum}");

ShowArray(array);
*/

//3Zadacha

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[]array = CreateArray(size);

int sum = 0;
int minVal = 0;
int maxVal = 0;

for (int i = 0; i <= size; i++)
    {
    if(i > maxVal) maxVal = array[i];
    }


ShowArray(array);
Console.WriteLine($"Total indexes is {size}, sum of numbers in not positive indexes is = {maxVal}and {minVal}");

