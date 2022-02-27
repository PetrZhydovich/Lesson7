//Показать двумерный массив размером m×n заполненный целыми числами.
int[,] arr = FillArray();
PrintArray(arr);


int[,] FillArray()
{
    int[,] array = new int[5,5];
    Random r = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
          {
              Console.WriteLine($"{array[i, j]} ");
          }
          Console.WriteLine();        
    }

}   




