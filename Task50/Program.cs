void Fill (int[,] mat)
{
 for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat [i, j] = Convert.ToInt32(new Random().Next(-10, 10));
            Console.Write($"{mat[i , j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] mat = new int [5,5];
Fill(mat);

if (n > mat.GetLength(0) || m > mat.GetLongLength(1))
{
    Console.WriteLine("null element");
} 
else
{
Console.WriteLine($"element equal {mat[n - 1, m - 1]}");
}

