Console.Clear();

int lenght = Convert.ToInt32(Console.ReadLine());
int[] n = new int[lenght];
int count = 0;

for(int i = 0; i < n.Length; i++)
{
      n[i] = new Random().Next(99,999);
      Console.WriteLine(n[i]+"");
}

 for(int a = 0; a < n.Length; a++)
    {
if(n[a] % 2 == 0)
count++;
    }
    Console.WriteLine(count);
