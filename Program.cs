using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()

        {
            Console.WriteLine(@" Выберите одну из игр:
1. Игра Угадай число
2. Таблица умножения 
3. Вывод числителей
4. Закрыть программу");
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Введите номер программы:");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    ugadai();
                }
                if (a == 2)
                {
                    umnoj();
                }
                if (a == 3)
                {
                    vivod();
                }
                if (a == 4)
                {
                    konec();
                }
               
                static string umnoj()
                { 
                {
                        int b = 1;
                        do
                        {
                            int g = 1;
                            do
                            {
                                Console.Write((b * g).ToString() + "\t");
                                g++;
                            }
                            while (g <= 10);
                                Console.WriteLine();
                            b++;
                        }
                        while (b <= 10);
                    }
                    return " ";
                }
                }
                static string ugadai()
                {
                    {
                        {
                            int x = 0;
                            int y = 100;
                            Random random = new Random();
                            int k = random.Next(x, y);
                            int c = 0;
                            int s;

                            Console.WriteLine("Угадайте число в интервале от 0 до 100 ");
                            do
                            {
                                Console.Write("Ваш вариант: ");
                                s = Convert.ToInt32(Console.ReadLine());

                                if (s < k)
                                    Console.WriteLine("Задуманное число больше");
                                if (s > k)
                                    Console.WriteLine("Задуманное число меньше");
                                c++;
                            }
                            while (s != k);
                            Console.WriteLine("Вы угадали!!!");

                        }
                        return " ";
                    }
                }
               
                }
                static string vivod()
                {
                    {
                        {
                            Console.Write("Введи число ");
                            int i = Convert.ToInt32(Console.ReadLine());
                    int a = 1;
                            while ( a <= i)
                            {
                                if (i % a == 0) Console.Write("{0} ", a);
                        a++;
                            }

                        }
                    }
                    return "";
                }
                static string konec()
                {

            Environment.Exit(0);
            return "";
                }
            }
        }



