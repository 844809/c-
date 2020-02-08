using System;
namespace csharp_basics
{
public class sample
{
public static void Main()
{

            int age;
            String ename;
            Console.WriteLine("enter your name");
            ename = Console.ReadLine();
            Console.WriteLine("enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Congratulations mr/ms {0} on your Birthday {1}",ename,age);
            Console.ReadKey();	
}
}
}