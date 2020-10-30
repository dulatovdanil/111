using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int m = 0;
            int x2 = 0;
            int x5 = 0;
            int x10 = 0;
            int i;
            int N = 1000;
            int r;
            for (i = 1; i <= N; i++)
            {
                try
                {
                    Console.WriteLine("Введите x: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("блок try выполнился успешно");
                
                    if (x % 10 == 0) ;
                else if (x > m)
                {
                    m = x;
                }

                if (x % 10 == 0) ;
                else if (x > x10)
                {
                    x10 = x;
                }
                if (x % 5 == 0) ;
                else if (x > x5)
                {
                    x5 = x;
                }
                if (x % 2 == 0) ;
                else if (x > x2)
                {
                    x2 = x;
                }
                    r = Math.Max(m * x10, x2 * x5);
                Console.WriteLine("Вычисленное контрольное значение: "+ r);
                if (r == 0)
                {
                    Console.WriteLine("Контроль не пройден");
                }
                else Console.WriteLine("Контроль  пройден");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено нечисловое значение!");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"Исключение: {ex.Message}");
                }


            }


        
        }
    }
}
