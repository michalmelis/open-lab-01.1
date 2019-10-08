using System;

namespace open_lab_01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            if (a < 10)
            {
                Console.WriteLine("This number is less then 10");
            }
            else
            {
                Console.WriteLine("This number is greater or equal to 10");
            }
        }       
    }
}



