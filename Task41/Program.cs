Console.Clear();

int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int count = 0;

for (int i = 0; i < size.Length; i++ )
{

if (size[i] > 0)
{
    count++;
}

}

Console.WriteLine($"Count= : {count}");


