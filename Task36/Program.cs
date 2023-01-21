Console.Clear();

int lenght = Convert.ToInt32(Console.ReadLine());
int[] n = new int[lenght];
int sum = 0;

for(int i = 0; i < n.Length; i++)
{
      n[i] = new Random().Next(1,100);
      Console.WriteLine(n[i]+" ");
}

 for(int a = 0; a < n.Length; a+=2)
    {
sum = sum + n[a];
    }
    Console.Write("sum=");
    Console.WriteLine(sum);
