using System;
using Microsoft.Win32;

namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */
        internal static void PrintFrame(int width, int height, char frameChar = '*')
        {
            for (int i=0;i<width;++i) Console.Write(frameChar);
            Console.WriteLine();
            for (int i = 0; i < height - 2; ++i)
            {
                Console.Write(frameChar);
                for (int j=0;j<width - 2;++j) Console.Write(' ');
                Console.Write(frameChar);
                Console.WriteLine();
            }
            for (int i=0;i<width;++i) Console.Write(frameChar);
        }

/*
 * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
 */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            int i = 0;
            while (i < width) {
                Console.Write(frameChar);
                ++i;
            }
            Console.WriteLine();
            i = 0;
            while (i < height - 2)
            {
                Console.Write(frameChar);
                int j=0;
                while (j < width - 2)
                {
                    Console.Write(' ');
                    ++j;
                }
                Console.Write(frameChar);
                Console.WriteLine();
                ++i;
            }
            i = 0;
            while (i < width) {
                Console.Write(frameChar);
                ++i;
            }
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            if (b == 0) return a;
            return Gcd(b, a % b);
        }

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            double res = 1;
            for (int i = 1; i <= n; ++i)
            {
                double a = Math.Pow(x, i);
                for (int j = 2; j <= i; ++j) a /= j;
                res += a;
            }

            return res;
        }

        public static void Main(string[] args)
        {
            PrintFrame(5, 3, '+');
            PrintFrame2(5, 3, '+');
            Gcd(345345, 9723);
            ExpTaylor(4, 8);
        }
    }
}