
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
    int newArray = new int[size];

    Console.WriteLine("Creaying array here: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write();
    return newArray;
}