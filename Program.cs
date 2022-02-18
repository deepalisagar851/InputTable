using System;
namespace MyApp
{
    class Program
    { 
        static void Table(int num)
        {
            for (int i = 1; i<= 10; i++)

                Console.WriteLine(num + "x" + i + "=" + (i * num));
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the number");
          int  num = Convert.ToInt32(Console.ReadLine());
            
            Table(num);




        }

    }
}
