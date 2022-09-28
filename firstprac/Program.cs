Console.WriteLine(" Калькулятор ");
//sdfsdf
int gg = 0;
while (gg == 0)
{
    Console.WriteLine("Введите первое число:");
    int q = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите тип операции указанный ниже:");
    Console.WriteLine("1. Сложить 2 числа ");
    Console.WriteLine("2. Вычесть первое из второго ");
    Console.WriteLine("3. Перемножить два числа ");
    Console.WriteLine("4. Разделить первое на второе ");
    Console.WriteLine("5. Возвести в степень N первое число ");
    Console.WriteLine("6. Найти квадратный корень из числа ");
    Console.WriteLine("7. Найти 1 процент от числа ");
    Console.WriteLine("8. Найти факториал из числа ");
    Console.WriteLine("9. Выйти из программы");
    string s = Console.ReadLine();

    Console.WriteLine("Введите второе число:"); ;
    int w = Convert.ToInt32(Console.ReadLine());

    int o;
    double ot;
    int l = 1;
    int k = 1;


    if (s == "1")
    {
        o = q + w;
        Console.WriteLine(o);
    }
    else if (s == "2")
    {
        o = q - w;
        Console.WriteLine(o);
    }
    else if (s == "3" )
    {
        o = q * w;
        Console.WriteLine(o);
    }
    else if (s == "4" )
    {
        Console.WriteLine((double)q / w);
    }
    else if (s == "5" )
    {
        o = 1;
            for (int i = 0; i < w; i++)
        {
            o *= q;
        }
        Console.WriteLine(o);
    }
    else if (s == "6" )
    {
        ot = Math.Sqrt(q);
        Console.WriteLine(ot);
    }
    else if (s == "7" )
    {
        o = q / 100;
        Console.WriteLine(o);
    }
    else if (s == "8")
    {
        o = 1;
        if (q > 0)
        {
            while (q > l)
            {
                l = l + 1;
                k = k + 1;
            }
        }
        Console.WriteLine(k);
    }
    else if (q < 0)
    {
        Console.WriteLine(0);
    }
    else if (s == "9")
    {
        Console.WriteLine("Конец программы.");
        gg = 1;
    }
}