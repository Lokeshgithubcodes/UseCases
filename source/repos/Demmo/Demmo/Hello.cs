using System;
namespace Demmo
{
    class Hello
    {
        static void Main(string[] args)
        {
            int num1, num2, res;
            Console.WriteLine("Enter the number1");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number2");
            num2=int.Parse(Console.ReadLine());
            res=num1 + num2;
            Console.WriteLine(res);

        }
    }
}
