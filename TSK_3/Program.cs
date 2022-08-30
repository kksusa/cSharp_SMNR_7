int CheckNumbers(string param)
{
    while (true)
    {
        Console.Write(param);
        if (int.TryParse(Console.ReadLine()!, out int number) && number > 0)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Число введено неправильно.");
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void PrintColumnAverage(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double columnAverage = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            columnAverage += array[j, i];
        }
        columnAverage /= (double) array.GetLength(0);
        Console.Write(Math.Round(columnAverage, 2) + "   ");
    }
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }
    return result;
}

int[,] array = CreateArrayWithRandomNumbers(CheckNumbers("Введите число строк: "), CheckNumbers("Введите число столбцов: "));
PrintArray(array);
PrintColumnAverage(array);