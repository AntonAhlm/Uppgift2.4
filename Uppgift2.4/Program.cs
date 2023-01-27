using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad tjänar dem anställda? ");

            Console.Write("Anställd 1 tjänar : ");
            int work1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Anställd 2 tjänar : ");
            int work2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Anställd 3 tjänar : "); 
            int work3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Medellönen är " + ((work1+work2+work3)/3));

        }
    }
}
