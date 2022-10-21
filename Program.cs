using myfirstapp;

namespace dnevnik
{
    internal class Program
    {
        static void Main()
        {
            c();
        }
        static void c(DateTime Date = new DateTime())
        {
            DateTime d = new DateTime();
            if (d == Date)
            {
                Date = new DateTime(2022, 10, 12);
            }
            int position = 0;
            Menu(Date);
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position < 1)
                    {
                        position = 2;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position > 2)
                    {
                        position = 1;
                    }
                }
                else if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                {
                    b(key);
                    Console.Clear();
                }
                Console.Clear();
                Menu(Date);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key = Console.ReadKey();
            }
            Console.Clear();
            if (position == 1 || position == 2)
            {
                Menu(Date, position);
            }
        }
        static void b(ConsoleKeyInfo key, DateTime Date = new DateTime())
        {
            DateTime d = new DateTime();
            if (d == Date)
            {
                Date = new DateTime(2022, 10, 12);
            }
            if (key.Key == ConsoleKey.LeftArrow)
            {
                while (key.Key != ConsoleKey.RightArrow)
                {
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        Console.Clear();
                        Date = Date.AddDays(-1);

                        Menu(Date);
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.DownArrow)
                        {
                            Console.Clear();
                            c(Date);
                        }
                        else if (key.Key == ConsoleKey.UpArrow)
                        {
                            Console.Clear();
                            c(Date);
                        }
                    }
                    Console.Clear();
                }
                Console.Clear();
                b(key, Date);
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                while (key.Key != ConsoleKey.LeftArrow)
                {
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        Console.Clear();
                        Date = Date.AddDays(+1);
                        Menu(Date);
                        key = Console.ReadKey();
                        if (key.Key == ConsoleKey.DownArrow)
                        {
                            Console.Clear();
                            c(Date);
                        }
                        else if (key.Key == ConsoleKey.UpArrow)
                        {
                            Console.Clear();
                            c(Date);
                        }
                    }
                    Console.Clear();
                }
                Console.Clear();
                b(key, Date);
            }
            key = Console.ReadKey();
        }
        static void Menu(DateTime dayDate = new DateTime(), int position = 0)
        {
            DateTime e = new DateTime();
            if (e == dayDate)
            {
                dayDate = new DateTime(2022, 10, 12);
            }
            a one = new a()
            {
                name = "  Cходить домой ",
                osnova = "Нужно переодеться",
                vremi = new DateTime(2022, 10, 12)
            };
            a two = new a()
            {
                name = "  Cходить в мираторг ",
                osnova = "Купить пиццу",
                vremi = new DateTime(2022, 10, 12)
            };
            a three = new a()
            {
                name = "  Сходить в мак ",
                osnova = "Купить бургер",
                vremi = new DateTime(2022, 10, 13)
            };
            a four = new a()
            {
                name = "  Сходить в супермаркет",
                osnova = "Купить булочку",
                vremi = new DateTime(2022, 10, 13)
            };
            a fif = new a()
            {
                name = "  Идти на переменну ",
                osnova = "Учить компьютерные сети ",
                vremi = new DateTime(2022, 10, 14)
            };
            a six = new a()
            {
                name = "  Сходить на заправку на нежинской",
                osnova = "Купить чипсиков второй раз",
                vremi = new DateTime(2022, 10, 14)
            };
            a seven = new a()
            {
                name = "  Сходить в магазин",
                osnova = "Купить чипсиков ",
                vremi = new DateTime(2022, 10, 15)
            };
            a eight = new a()
            {
                name = "  Сходить на поле",
                osnova = "Поиграть в мяч",
                vremi = new DateTime(2022, 10, 15)
            };
            
            a nine = new a()
            {
                name = "  Сходить в боулинг",
                osnova = "Покидать шары",
                vremi = new DateTime(2022, 10, 16)
            };
            a ten = new a()
            {
                name = "  Сходить на каток",
                osnova = "Покататься на коньках ",
                vremi = new DateTime(2022, 10, 16)
            };
           
           
            List<a> List = new List<a>()
            {
                one, two, three, four, fif, six, seven,  eight, nine, ten
            };
            List<a> day2 = List.Where(x => x.vremi == dayDate).ToList();
            if (position == 0)
            {
                Console.WriteLine(dayDate);
                foreach (a  day in day2)
                {
                    Console.WriteLine(day.name);
                }
            }
            else
            {
                a chislo = day2[position - 1];
                Console.WriteLine(chislo.name);
                Console.WriteLine("---------------------------------");
                Console.WriteLine(chislo.osnova);
                Console.WriteLine("Дата окончания: " + chislo.vremi);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    c(dayDate);
                }
                else
                {
                    while (key.Key != ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Menu(dayDate, position);
                    }
                }
            }

        }

    }
}