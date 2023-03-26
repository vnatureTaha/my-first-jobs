using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            /* конвертация валют
             
            string currency;
            double kztusd = 0.0023, kztrub = 0.17, rubkzt = 5.78, rubusd = 0.013, usdkzt = 436.42, usdrub = 75.45, money;
            Console.WriteLine("choose your currency: usd/rub/kzt/aze ");
            currency = Console.ReadLine();
            if (currency == "usd")
            {
                Console.WriteLine("How much money do you have: ");
                money = double.Parse(Console.ReadLine());
                Console.WriteLine("KZT: " + (money * usdkzt));
                Console.WriteLine("RUB: " + (money * usdrub));

            }
            else if (currency == "rub")
            {
                Console.WriteLine("How much money do you have: ");
                money = double.Parse(Console.ReadLine());
                Console.WriteLine("KZT: " + (money * rubkzt));
                Console.WriteLine("USD: " + (money * rubusd));
            }
            else if (currency == "kzt")
            {
                Console.WriteLine("How much money do you have: ");
                money = double.Parse(Console.ReadLine());
                Console.WriteLine("RUB: " + (money * kztrub));
                Console.WriteLine("USD: " + (money * kztusd));
            }
            else if (currency == "aze")
            {
                Console.WriteLine("How much money do you have: ");
                money = double.Parse(Console.ReadLine());
                Console.WriteLine("RUB: " + (money * 44.9));
                Console.WriteLine("USD: " + (money * 0.59));
            }


            else
            {
                Console.WriteLine("Error, try again!");
            }


            
             
             */









            /* Калькулятор 
            
            
            while (true)
            { 
                double firstValue, secondValue, result;
                char math;
                Console.WriteLine("Введите первое число: ");
                firstValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                secondValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Выберете математическое действие: * / + - ");
                math = char.Parse(Console.ReadLine());
            
            
                if (math == '+')
                {
                    result = firstValue + secondValue;
                    Console.WriteLine(result);
                    Console.ReadLine();
                    Console.Clear();
                    
                }
                else if (math == '-')
                {
                    result = firstValue - secondValue;
                    Console.WriteLine(result);
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (math == '*')
                {
                    result = firstValue * secondValue;
                    Console.WriteLine(result);
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (math == '/')
                {
                    result = firstValue * secondValue;
                    Console.WriteLine(result);
                    Console.ReadLine();
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("Что-то пошло не так, давай занаво: ");
                    Console.ReadLine();
                    Console.Clear();

                }
             }
                */











        }

    }
}