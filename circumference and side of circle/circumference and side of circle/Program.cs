using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circumference_and_side_of_circle
{
    class Program
    {
        static void side(int a) //Masahat
        {
            double p = 3.141592654;
            Console.WriteLine($"Side of circle is : {((double)(a * 2) * p)}");
        }
        static void circumference(int a) //Mohit
        {
            double p = 3.141592654;
            Console.WriteLine($"circumference of circle is : {((double)(a * a) * p)}");
        }
        static void Main(string[] args)
        {
            int radius = 0;
            Console.Write("Please enter radius of circle : ");
            radius = int.Parse(Console.ReadLine());
            side(radius);
            circumference(radius);
            Console.ReadKey();
        }
    }
}
