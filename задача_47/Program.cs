Console.Clear();
Console.WriteLine("Задайте число строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте число элементов массива");
int columns = int.Parse(Console.ReadLine());
double[,] array = GetArray (rows, columns);

double[,] GetArray (int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);

