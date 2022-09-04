using System;
using System.Numerics;
using NUnit.Framework.Constraints;

namespace Task5
{
    public class Task5
    {
/*
 * Задание 5.1. Запустите функцию `main`, нажав зелёный треугольник слева от её имени. Это действие создаст
 * конфигурацию, которую позже можно отредактировать. В этом задании для ввода данных используются
 * либо параметры командной строки, либо консольный ввод. При запуске через Rider параметры командной строки
 * задаются в окне "Run/Edit configurations..." ("Program arguments:").
 */
        public static void Main(string[] args)
        {
            DemoInput(args);
            ComputeFib(args);
        }

/*
 * Задание 5.2. Разберите код функции `demoInput`.
 */
        internal static void DemoInput(string[] args)
        {
            string name;
            if (args.Length > 0)
            {
                name = string.Join(" ", args);
            }
            else
            {
                Console.WriteLine("Введите имя:");
                name = Console.ReadLine();
            }

            Console.WriteLine($"Привет, {name}");
        }

/*
 * Задание 5.3. Напишите программу, которая принимает на вход целое неотрицательное число
 * (либо параметром командной строки, либо с клавиатуры) и печатает число Фибоначчи:
 * https://ru.wikipedia.org/wiki/%D0%A7%D0%B8%D1%81%D0%BB%D0%B0_%D0%A4%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8
 * с соответствующим номером. Мы считаем, что нулевым числом Фибоначчи является число 0, а первым — число 1.
 *
 * Для представления чисел Фибоначчи следует использовать длинные целые:
 * - https://docs.microsoft.com/ru-ru/dotnet/api/system.numerics.biginteger?view=net-6.0
 */

        internal static BigInteger Fib(int n)
        {
            if (n < 2) return n;
            else if (n<3) return 1;
            BigInteger a, c = 1, l = 1, ll = 0;
            n -= 2;
            while (n > 0)
            {
                a = c + l;
                ll = l;
                l = c;
                c = a;
                --n;
            }

            return c;
        }

        internal static void ComputeFib(string[] args)
        {
            int n;
            if (args.Length == 1)
            {
                n = Int32.Parse(args[0]);
            }
            else
            {
                n = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine(Fib(n));
        }
    }
}