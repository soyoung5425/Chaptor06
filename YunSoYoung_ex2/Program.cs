using System;

namespace YunSoYoung_ex2
{
    class Program
    {
        public static void Main()
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, ref mean); // ref 키워드 사용

            Console.WriteLine($"평균 : {mean}");

        }

        public static void Mean(double a, double b, double c,
            double d, double e, ref double mean) // ref 키워드 사용
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
