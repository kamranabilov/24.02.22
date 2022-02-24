using System;

namespace Task_24._02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student1 = new Student("fullname", "P123", 30);
            Console.WriteLine("correct groupno enter");
            string fullname = Console.ReadLine();
            Console.WriteLine("correct name and surname enter");
            string groupno = Console.ReadLine();
            
        }
    }
}
