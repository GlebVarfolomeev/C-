Console.Clear();

int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

foreach(int i in array)
Console.Write(i);