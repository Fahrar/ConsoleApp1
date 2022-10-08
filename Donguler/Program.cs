using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] 
            { 
            "1. Kurs",
            "2. Kurs",
            "3. Kurs",
            "4. Kurs",
            "5. Kurs",
            "6. Kurs"
            };


            //for (int i = 0; i < kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i]);
            //}

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs [0]);
            }



            Console.ReadLine();
            
        }
    }
}
