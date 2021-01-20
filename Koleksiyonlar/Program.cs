using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Orhan", "Mesut", "Emre", "Fatih" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string> { "Orhan", "Mesut", "Emre", "Fatih" };

            foreach (var isim in isimler2)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("-------------");

            isimler2.Add("Behzat");

            foreach (var isim in isimler2)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
