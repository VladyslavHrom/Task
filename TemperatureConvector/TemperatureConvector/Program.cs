using System;

namespace TemperatureConvector
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Celsius = new int[201];
            int[] Kelvins = new int[201];
            double[] Fahrenheits = new double[201];
            Celsius[0] = -100;
            Kelvins[0] = 173;
            Fahrenheits[0] = -148;
            
            for (int i = 1; i < Celsius.Length; i++)
            {
                Celsius[i] = Celsius[i - 1] + 1;
            }
            for (int i = 1; i < Kelvins.Length; i++)
            {
                Kelvins[i] = Kelvins[i - 1] + 1;
            }
            for (int i = 1; i < Fahrenheits.Length; i++)
            {
                Fahrenheits[i] = Fahrenheits[i - 1] + 1.8;
            }
            Console.WriteLine("Celsius \t kelvins \t fahrenheits");
            for (int i = 0; i < Celsius.Length; i++)
            {
                Console.WriteLine($"{Celsius[i]} \t\t {Kelvins[i]} \t {Fahrenheits[i]}");
            }
            Console.ReadLine();
        }
    }
}
