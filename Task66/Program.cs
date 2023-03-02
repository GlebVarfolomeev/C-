Console.Clear();
Console.WriteLine("n=");

int n = int.Parse(Console.ReadLine());

Console.WriteLine("m=");

int m = int.Parse(Console.ReadLine());

void rec(int n, int m, int s)
{
    if (n > m)
    {
        Console.WriteLine($"{s}");
    return;
    }
    s = s + (n++);
    rec (n, m, s);
}
rec (n, m, 0);

