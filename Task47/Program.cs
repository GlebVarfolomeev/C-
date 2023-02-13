void Fill (double[,] mat)
{
 for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat [i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
            Console.Write($"{mat[i , j]}  \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("mn=");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double [,] mat = new double [size[0], size[1]];
Fill(mat);
