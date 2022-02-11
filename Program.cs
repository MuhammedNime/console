using System;

namespace console_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            Console.WriteLine("Hello World!");
            Console.Write("adinizi giriniz: ");
            ad = Console.ReadLine();
            Console.Write("soyadinizi giriniz: ");
            soyad = Console.ReadLine();
            Console.WriteLine("ad soyad: " + ad + " " + soyad);
  
        }
    }
}
