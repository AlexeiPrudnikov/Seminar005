const int maxValue = 20;
const int maxLenght = 8;
void GenArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, maxValue + 1);
    }
}

void PrintJaggedArray (int[][] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        PrintArray(array[i]);
    }    
    
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }   
    Console.WriteLine(); 
}
int GetSumArray (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}
Console.Clear();
Random rand = new Random();
int[][] jaggedArray = new int[5][];
int len = 0;
for (int i = 0; i < jaggedArray.Length; i++)
{
    len = rand.Next(1, maxLenght);
    jaggedArray[i] = new int[len];
    GenArray(jaggedArray[i]);
}
PrintJaggedArray(jaggedArray);
int maxSumm = GetSumArray(jaggedArray[0]);
int maxIndex = 0;
int tempSumm = 0;
Console.WriteLine();
for (int i = 1; i < jaggedArray.Length; i++)
{
    tempSumm = GetSumArray(jaggedArray[i]);
    if ( tempSumm > maxSumm)
    {
        maxIndex = i;
        maxSumm = tempSumm;
    }
}
Console.WriteLine($"Максимальная сумма {maxSumm}, минимальный индекс с данной суммой {maxIndex}");
PrintArray(jaggedArray[maxIndex]);
