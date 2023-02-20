Console.Clear();
Console.WriteLine("Задайте число строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте число элементов массива");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray (rows, columns);

int[,] GetArray (int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
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

int [,] CheckElement (int[,] array)
{
    Console.WriteLine("Введите строку массива:");
    int row = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите номер элемента в строке");
    int column = int.Parse(Console.ReadLine());
    if (row > array.GetLength(0) || column > array.GetLength(1) || row <= 0 || column <= 0)
    {Console.WriteLine("Такого элемента нет");}
    else {Console.WriteLine($"{array[row-1,column-1]}");}
    return array;
}

Console.WriteLine();
CheckElement(array);