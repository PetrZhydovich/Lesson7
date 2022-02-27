// В двумерном массиве n×k заменить четные элементы на противоположные.


int[,] array = new int[5, 5];
Random rnd = new Random();
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-100, 100);
        }

    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j],4}");
        }
        Console.WriteLine();
    }
}
void ChangeEvenNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0) array[i, j] = -array[i, j];
        }
    }

}
void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j],4}");
        }
        Console.WriteLine();
    }
}
CreateArray(array);
Console.WriteLine("Cлучайнный Массив:");
PrintArray(array);
Console.WriteLine("Массив после замены четных элементов на противоположные");
ChangeEvenNumbers(array);
PrintArray2(array);

