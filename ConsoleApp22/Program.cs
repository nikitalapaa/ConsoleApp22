using System;
using System.Collections;
using System.IO;

namespace ConsoleApp22
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите количество обуви: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            ArrayList arrayList = new ArrayList(N);

            for (int i = 0; i < N;)
            {
                try
                {
                    Console.Write("производитель: ");
                    string proiz = Console.ReadLine();

                    Console.Write("цена: ");
                    float cen = Convert.ToInt32(Console.ReadLine());

                    Console.Write("размер: ");
                    double raz = Convert.ToDouble(Console.ReadLine());

                    Obuv furniture = new Obuv(proiz, cen, raz);
                    arrayList.Add(furniture);

                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Введенные данные были неверными");
                }
                Console.WriteLine();
            }
        }
    }
}
