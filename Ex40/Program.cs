int [] array = new int[3];
Console.Write("Введите длину первой стороны треугольника: ");
array[0]= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй стороны треугольника: ");
array[1]= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третьей стороны треугольника: ");
array[2]= Convert.ToInt32(Console.ReadLine());
bool res0=false;
bool res1=false;
bool res2=false;
if(array[0]<array[1]+array[2]) {res0=true;}
if(array[1]<array[0]+array[2]) {res1=true;}
if(array[2]<array[1]+array[0]) {res2=true;}
if(res0==res1==res2==true)
{
    Console.WriteLine("Такой треугольник может существовать!");
}
else
{
    Console.WriteLine("Существование такого треугольника невозможно!");
}