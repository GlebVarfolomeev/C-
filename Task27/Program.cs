Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int lenght = Nl(n);
Sn(n, lenght);

int Nl (int a)
{
int index = 0;
while (a > 0) 
{
    a /= 10;
    index++;
}
return index;
}

void Sn(int n, int lenght)
{
int sum = 0;
for(int i = 1; i<= lenght; i++)
{
    sum += n % 10;
    n /= 10;
}
Console.WriteLine($"Сумма {sum}");
}