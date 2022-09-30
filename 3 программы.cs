Console.Write(@"Выберите одну из игр:
1.Игра угадай число
2.Таблица умножения
3.Вывод делителей числа");
Console.WriteLine(' ');
while (true)
{
    string c = Console.ReadLine();
    {
        if (c == "1")
        {
            {
                Console.WriteLine("Угадайте число от 0 до 100:");
                string str;
                Random random = new Random();
                int k = random.Next(0, 100);

                do
                {
                    Console.Write("Ваш вариант: ");
                    str = Console.ReadLine();

                    if (int.Parse(str) < k)
                        Console.WriteLine("Задуманное число больше");
                    if (int.Parse(str) > k)
                        Console.WriteLine("Задуманное число меньше");

                }
                while (int.Parse(str) != k);

                Console.WriteLine("Вы угадали!!!");
            }
            Console.WriteLine(' ');
            Console.WriteLine("Введите операцию еще раз");
        }
        if (c == "3")
        {
            {
                {
                    Console.Write("Введи число ");
                    int i = int.Parse(Console.ReadLine());
                    for (int a = 1; a <= i; a++)
                    {
                        if (i % a == 0) Console.Write("{0} ", a);

                    }
                    Console.WriteLine(' ');
                    Console.Write("Введите одну из игр еще раз:");
                }


            }

            if (c == "4")
            {
                Environment.Exit(0);

            }

        }
    }
}
Console.ReadKey();

