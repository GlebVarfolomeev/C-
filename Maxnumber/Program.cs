Console.WriteLine("Введите число");

int a = Convert.ToInt32(Console.ReadLine()); 
int b = Convert.ToInt32(Console.ReadLine());

if (a<b){
    
    Console.WriteLine(b);
}
else if(b<a){
Console.WriteLine(a);
}
return(0);