using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 100000000;
            int sum = 0;
            for (int coll = 0; coll < 20; coll++)
            {
                int counter = 0;
                int counter_try_it = 0;
                bool exit = true;
                while (exit == true)
                {

                    Random num = new Random();
                    int q = num.Next(0, 100001);
                    counter++;
                    if (q != 10)
                    {

                    }
                    else
                    {
                        counter_try_it++;
                        Console.Write(q + " ");


                    }
                    if (counter_try_it == 10)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Количество попыток:" + counter);
                        exit = false;
                        if (counter > max) max = counter;
                        if (counter < min) min = counter;
                    }
                }
                sum = sum + counter;
            }
            int sred = sum / 20;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Всего попыток было сделано: " + sum + " Среднее число попыток: " + sred + " Максимальное значение: "+max+" Миномальное значение: "+min );
        }
    }
}
