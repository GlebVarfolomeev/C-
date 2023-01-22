Console.Clear();

Console.WriteLine("b1=");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("k1=");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b2=");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("k2=");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"intersection= {x}; {y}");



