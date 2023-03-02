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
Console.WriteLine("Before:");
int [,] mat = new int [5,5];
Filld(mat);
Console.WriteLine("After:");
PrintArray(mat);

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

for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < mat.GetLength(1) - 1; z++)
        {
            if (mat[i, z] > mat[i, z + 1])
            { 
                int temp = 0;
                temp = mat[i, z];
                mat[i, z] = mat[i, z + 1];
                mat[i, z + 1] = temp;
            }
        }
    }
}