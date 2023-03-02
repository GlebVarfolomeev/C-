void Fill (int[,] mat)
{
 for (int i = 0; i < mat.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat [i, j] = Convert.ToInt32(new Random().Next(0, 11));
            Console.Write($"{mat[i , j]}  \t");
            sum = (sum + mat[i,j]);
        }
        sum = sum / 5;
         Console.WriteLine(sum);
        Console.WriteLine();
    }
}


Console.Clear();
int [,] mat = new int [5,5];
Fill(mat);