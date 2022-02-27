// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

int[,] mass = new int[5, 5];
Random random = new Random();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = random.Next(2, 10);
        Console.Write("{0,10}", mass[i, j]);
    }
    Console.WriteLine();
}

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {

        if (0 == i % 2 && 0 == j % 2)
            mass[i, j] = mass[i, j] * mass[i, j];
    }
}
Console.WriteLine();

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write("{0,10}", collection[i, j]);
        }
        Console.WriteLine();
    }
}

PrintArray(mass);