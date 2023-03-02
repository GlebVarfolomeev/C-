Console.Clear();
Console.WriteLine("n=");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("m=");

int m = Convert.ToInt32(Console.ReadLine());

akf(n,m);


void akf(int n, int m)
{
    Console.Write(ak(n, m)); 
}

int ak(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0 && n > 0)
    {
        return ak(n - 1, 1);
    }
    else
    {
        return (ak(n - 1, ak(n, m - 1)));
    }
}