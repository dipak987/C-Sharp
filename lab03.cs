using System;

namespace Citizenship
{
    class vote
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Person can get citizenship and vote");
            }
            else if (age >= 16)
            {
                Console.WriteLine("Person can get citizenship but cannot vote");
            }
            else
            {
                Console.WriteLine("Person cannot get citizenship");
            }

            Console.ReadLine();
        }
    }
}