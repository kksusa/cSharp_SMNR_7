int CheckNumbers(string param)
{
    while (true)
    {
        Console.Write($"{param}: ");
        if (int.TryParse(Console.ReadLine()!, out int number) && number >= 1 && number <= 10)
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
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWithRandomNumbers()
{
    var random = new Random();
    int m = random.Next(1 ,11);
    int n = random.Next(1 ,11);
    int[,] result = new int[m,n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = random.Next(10, 100);
        }
    }
    return result;
}

int [,] array = CreateArrayWithRandomNumbers();
int stringNumber = CheckNumbers("Введите строку элемента от 1 до 10");
int columnNumber = CheckNumbers("Введите столбец элемента от 1 до 10");
PrintArray(array);
if (stringNumber <= array.GetLength(0) && columnNumber <= array.GetLength(1))
{
    Console.WriteLine();
    Console.WriteLine($"Ваш элемент равен " + array[stringNumber - 1, columnNumber - 1] + ".");
}
else Console.WriteLine("Такого элемента нет.");