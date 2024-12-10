using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sayıyı giriniz:");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayıyı giriniz:");
            int sayi2=Convert.ToInt32(Console.ReadLine());

            karsılastırma(sayi1, sayi2);
            Console.ReadLine();
        }
        static void karsılastırma(int a,int b)
        {
            if(a>b)
            {
                Console.WriteLine("Birinci sayı ikinci sayıdan büyüktür.");
            }
            else if(a==b)
            {
                Console.WriteLine("Sayılar birbirine eşittir.");
            }
            else
            {
                Console.WriteLine("İkinci sayı birinci sayıdan büyüktür.");
            }
        }
    }
}
