using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_Proje_7
{
    internal class Program
    {
        static void Main(string[] args)


        {   baslangic:
            //Declaration Variables
            byte day;

            //Tale user value for day
            Console.WriteLine("Lütfen Gün için bir sayı giriniz : ");

            //İnventory string to byte
            day = byte.Parse(Console.ReadLine());

            //Begining Switch block

            switch (day)
            {
                case 1: Console.WriteLine("Bugün Günlerden Pazartesidir");
                    break;

                case 2: Console.WriteLine("Bugün Günlerden Salıdır.");
                    break;
                case 3:
                    Console.WriteLine("Bugün Günlerden Çarşambadır.");
                    break;
                case 4:
                    Console.WriteLine("Bugün Günlerden Perşembedir.");
                    break;
                case 5:
                    Console.WriteLine("Bugün Günlerden Cumadır.");
                    break;
                case 6:
                    Console.WriteLine("Bugün Günlerden Cumartesidir.");
                    break;
                case 7:
                    Console.WriteLine("Bugün Günlerden Pazardır.");
                    break;

                default:
                    Console.WriteLine("Hatalı bir giriş yaptınız.");
                    goto baslangic;
                    break;

            }

            Console.ReadKey();

        }
    }
}
