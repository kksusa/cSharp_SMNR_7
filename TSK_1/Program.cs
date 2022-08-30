int CheckNumbers(string param)
{
    while (true)
    {
        Console.Write($"{param}: ");
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

void PrintArray(double[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();
    }
}

double[,] CreateArrayWithRandomNumbers(int m, int n)
{
    double[,] result = new double[m,n];
    var random = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = Math.Round(random.NextDouble() * 200 - 100, 2);
        }
    }
    return result;
}

PrintArray(CreateArrayWithRandomNumbers(CheckNumbers("Введите число строк"), CheckNumbers("Введите число столбцов")));