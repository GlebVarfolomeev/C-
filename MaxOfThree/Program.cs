Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());


if ((a > b) && (a > c))
{
Console.WriteLine(a);
}

else if ((b > a) && (b > c))

{
Console.WriteLine(b);
}


else if ((c > a) && (c > b))

{
Console.WriteLine(c);
}

return(0);