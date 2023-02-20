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
Console.WriteLine();

void SumOfColumns (int[,] array)
{
    int[] sumColumn = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {     
                sumColumn[i] += array[j, i];      
                } 
            }
            Console.WriteLine();
            foreach (double elem in sumColumn)
            {
                
                Console.WriteLine(elem/array.GetLength(0));
            }
 
        }

SumOfColumns(array);


