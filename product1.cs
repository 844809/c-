using System;
namespace project
{
public class product
{
public static void Main()
{
float a,b;
double c;
Console.WriteLine("enter a value");
a=float.Parse(Console.ReadLine());
Console.WriteLine("enter b value");
b=float.Parse(Console.ReadLine());
c=a*b;
Console.WriteLine("Product of {0} and {1} is {2}",a,b,c);
Console.ReadKey();
}
}
}
