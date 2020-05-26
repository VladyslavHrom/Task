using System;
using System.Diagnostics;   
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.IO;
using System.Globalization;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double UAH,RSD;
            Console.WriteLine("Enter the amount in UAH");
            UAH = double.Parse(Console.ReadLine());
            string result;
          
            string  search = "Текущий курс обмена UAH/RSD - ";// змінна для пошуку строки 
            using (var client = new WebClient())
            {
                result=client.DownloadString("https://freecurrencyrates.com/ru/convert-UAH-RSD"); //Скачуєм сторінку в змінну
                
            }
            var _index = result.Contains(search);// визначення індексу символу початку строки
            if (_index) 
            {
                int _lenghtSearch = search.Length;
                int index = result.IndexOf(search);
                if (index >= 0)
                     //Console.WriteLine( index + 1);
                     Console.WriteLine(" ");

                string valueRSD = result.Substring(index+ _lenghtSearch, 4);// Отримуємо значення RSD, 4 символи з початкового індексу 20877

                double coefficient = Convert.ToDouble(valueRSD, CultureInfo.InvariantCulture);// Визначаємо вартість RSD в UAH
                RSD = UAH * coefficient;
                Console.WriteLine(RSD);
            }
            
            Console.ReadKey();
        }

        }
    }

