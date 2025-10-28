using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char symbol;

            Console.WriteLine("-----BASİT HESAP MAKİNESİ-----");
            Console.WriteLine();
            Console.Write("Birinci sayıyı giriniz: ");
            num1=double.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            num2=double.Parse(Console.ReadLine());
            Console.Write("Yapmak istediğiniz işlemi seçiniz (+ - * /) : ");
            symbol=char.Parse(Console.ReadLine());

            switch(symbol)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Sonuç: " + result);
                    break;

                case '-':
                    result=num1 - num2;
                    Console.WriteLine("Sonuç: " + result);
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Sonuç: " + result);
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Tanımsız");
                        break;
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Sonuç: " + result);
                        break;
                    }
                    default:
                    Console.WriteLine("Hata!");
                    break;
            }
            Console.Read();



            


        }
    }
}
