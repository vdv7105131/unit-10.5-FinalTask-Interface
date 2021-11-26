using System;

namespace Task_1_Calculator
{
    class Calculator : ICalculator
    {
        int ICalculator.Sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"Сумма двух чисел равна {c}");
            return c;
        }

        public void NumbersInput(out int num1, out int num2)
        {
            Console.WriteLine("Введите первое число:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            num2 = Convert.ToInt32(Console.ReadLine());

            //try
            //{

            //}
            //catch (Exception ex)
            //{

            //}
        }
    }
}
