namespace Piano
{
    internal class Program
    {
     
        static void Main()
        {
            while (true)
            {
                Console.WriteLine(" Для выбора актавы нажмите на одну из клавиш:'F3' 'F4', 'F5' или 'F6'.");
                ConsoleKeyInfo klavish = Console.ReadKey();
                if (klavish.Key == ConsoleKey.F3)
                {
                    Octave3();
                }

                if (klavish.Key == ConsoleKey.F4)
                {
                    Octave4();
                }
                if (klavish.Key == ConsoleKey.F5)
                {
                    Octave5();
                }
                if (klavish.Key == ConsoleKey.F6)
                {
                    Octave6();
                }
                if (klavish.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        static void Octave3()
        {
            int[] Octave3 = new int[] { 131, 139, 147, 156, 165, 175,
                                           185, 196, 208, 220, 233, 250 };
            zvuk11(Octave3);
        }
        static void zvuk11(int[] Octave3)
        {
            Console.WriteLine("3 октава");
            ConsoleKeyInfo klavis3 = Console.ReadKey();
            while (klavis3.Key != ConsoleKey.Escape)
            {
                switch (klavis3.Key)
                {
                    case ConsoleKey.A:
                        sound(Octave3[0]);
                        Console.Clear();
                        break;
                    case ConsoleKey.Q:
                        sound(Octave3[1]);
                        Console.Clear();
                        break;
                    case ConsoleKey.S:
                        sound(Octave3[2]);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        sound(Octave3[3]);
                        Console.Clear();
                        break;
                    case ConsoleKey.D:
                        sound(Octave3[4]);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        sound(Octave3[5]);
                        Console.Clear();
                        break;
                    case ConsoleKey.R:
                        sound(Octave3[6]);
                        Console.Clear();
                        break;
                    case ConsoleKey.G:
                        sound(Octave3[7]);
                        Console.Clear();
                        break;
                    case ConsoleKey.T:
                        sound(Octave3[8]);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        sound(Octave3[9]);
                        Console.Clear();
                        break;
                    case ConsoleKey.J:
                        sound(Octave3[10]);
                        Console.Clear();
                        break;
                    case ConsoleKey.U:
                        sound(Octave3[11]);
                        Console.Clear();
                        break;
                }
                klavis3 = Console.ReadKey();
            }

            static void sound(int b)
            {
                Console.Beep(b, 250);
                Console.Clear();
            }
        }


        static void Octave4()
        {
            int[] Octave4 = new int [] { 262, 277, 293, 311, 329, 349,
                                           370, 392, 415, 440, 466, 493 };
            zvuk1(Octave4);
        }
        static void zvuk1(int[] Octave4)
        {
            Console.WriteLine("4 октава");
            ConsoleKeyInfo klavis4 = Console.ReadKey();
            while (klavis4.Key != ConsoleKey.Escape)
            {
                switch (klavis4.Key)
                {
                    case ConsoleKey.A:
                        sound(Octave4[0]);
                        Console.Clear();
                        break;
                    case ConsoleKey.Q:
                        sound(Octave4[1]);
                        Console.Clear();
                        break;
                    case ConsoleKey.S:
                        sound(Octave4[2]);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        sound(Octave4[3]);
                        Console.Clear();
                        break;
                    case ConsoleKey.D:
                        sound(Octave4[4]);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        sound(Octave4[5]);
                        Console.Clear();
                        break;
                    case ConsoleKey.R:
                        sound(Octave4[6]);
                        Console.Clear();
                        break;
                    case ConsoleKey.G:
                        sound(Octave4[7]);
                        Console.Clear();
                        break;
                    case ConsoleKey.T:
                        sound(Octave4[8]);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        sound(Octave4[9]);
                        Console.Clear();
                        break;
                    case ConsoleKey.J:
                        sound(Octave4[10]);
                        Console.Clear();
                        break;
                    case ConsoleKey.U:
                        sound(Octave4[11]);
                        Console.Clear();
                        break;
                }
                klavis4 = Console.ReadKey();
            }
            
            static void sound(int b)
            {
                Console.Beep(b, 250);
                Console.Clear();
            }
        }

        static void Octave5()
        {
            int[] Octave5 = new int[] { 523, 554, 587, 622, 659, 699,
                                           740, 784, 831, 880, 932, 988 };
            zvuk2(Octave5);
        }
        static void zvuk2(int[] Ovtave5)
        {
            Console.WriteLine("5 октава");
            ConsoleKeyInfo klavisg5 = Console.ReadKey();
            while (klavisg5.Key != ConsoleKey.Escape)
            {
                switch (klavisg5.Key)
                {
                    case ConsoleKey.A:
                        zvuk(Ovtave5[0]);
                        Console.Clear();
                        break;
                    case ConsoleKey.Q:
                        zvuk(Ovtave5[1]);
                        Console.Clear();
                        break;
                    case ConsoleKey.S:
                        zvuk(Ovtave5[2]);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        zvuk(Ovtave5[3]);
                        Console.Clear();
                        break;
                    case ConsoleKey.D:
                        zvuk(Ovtave5[4]);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        zvuk(Ovtave5[5]);
                        Console.Clear();
                        break;
                    case ConsoleKey.R:
                        zvuk(Ovtave5[6]);
                        Console.Clear();
                        break;
                    case ConsoleKey.G:
                        zvuk(Ovtave5[7]);
                        Console.Clear();
                        break;
                    case ConsoleKey.T:
                        zvuk(Ovtave5[8]);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        zvuk(Ovtave5[9]);
                        Console.Clear();
                        break;
                    case ConsoleKey.J:
                        zvuk(Ovtave5[10]);
                        Console.Clear();
                        break;
                    case ConsoleKey.U:
                        zvuk(Ovtave5[11]);
                        Console.Clear();
                        break;
                }
                klavisg5 = Console.ReadKey();
            }
         
        }
        static void zvuk(int b)
        {
            Console.Beep(b, 250);
            Console.Clear();
        }

        static void Octave6()
        {
            int[] Octave6 = new int[] { 1047, 1109, 1175, 1245, 1319, 1397,
                                           1480, 1568, 1661, 1760, 1865, 1976 };
            zvuk3(Octave6);
        }
        static void zvuk3(int[] Octave6)
        {
            Console.WriteLine("6 октава");
            ConsoleKeyInfo klavisg6= Console.ReadKey();
            while (klavisg6.Key != ConsoleKey.Escape)
            {
                switch (klavisg6.Key)
                {
                    case ConsoleKey.A:
                        zvuk(Octave6[0]);
                        Console.Clear();
                        break;
                    case ConsoleKey.Q:
                        zvuk(Octave6[1]);
                        Console.Clear();
                        break;
                    case ConsoleKey.S:
                        zvuk(Octave6[2]);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        zvuk(Octave6[3]);
                        Console.Clear();
                        break;
                    case ConsoleKey.D:
                        zvuk(Octave6[4]);
                        Console.Clear();
                        break;
                    case ConsoleKey.F:
                        zvuk(Octave6[5]);
                        Console.Clear();
                        break;
                    case ConsoleKey.R:
                        zvuk(Octave6[6]);
                        Console.Clear();
                        break;
                    case ConsoleKey.G:
                        zvuk(Octave6[7]);
                        Console.Clear();
                        break;
                    case ConsoleKey.T:
                        zvuk(Octave6[8]);
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        zvuk(Octave6[9]);
                        Console.Clear();
                        break;
                    case ConsoleKey.J:
                        zvuk(Octave6[10]);
                        Console.Clear();
                        break;
                    case ConsoleKey.U:
                        zvuk(Octave6[11]);
                        Console.Clear();
                        break;
                }
                
            }
            
            static void zvuk(int b)
            {
                Console.Beep(b, 250);
                Console.Clear();
            }
        }
    }
}