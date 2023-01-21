Console.Clear();

int lenght = Convert.ToInt32(Console.ReadLine());
int[] n = new int[lenght];
int min = Int32.MinValue;
int max = Int32.MaxValue;

for(int i = 0; i < n.Length; i++)
{
      n[i] = new Random().Next(1,100);
      Console.WriteLine(n[i]+" ");
}

 for(int a = 0; a < n.Length; a++)
    {
if (n[a] > min)
{
    min = n[a];
}
if (n[a] < max)
{
    max = n[a];
}
    }
 Console.Write("diff=");
    Console.WriteLine(min - max);
