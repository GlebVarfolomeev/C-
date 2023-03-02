void Filld (int[,] mat)
{
 for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat [i, j] = Convert.ToInt32(new Random().Next(0, 10));
            Console.Write($"{mat[i , j]}  \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int [,] mat = new int [5,5];
Filld(mat);
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < mat.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        sum = sum + mat[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    }
}
Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));