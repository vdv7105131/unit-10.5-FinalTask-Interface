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
            
            var isNumber1 = int.TryParse(Console.ReadLine(), out num1);
            while (isNumber1 == false)
            {
                Console.WriteLine("Введите первое число повторно:");
                isNumber1 = int.TryParse(Console.ReadLine(), out num1);
            }
            
            Console.WriteLine("Введите второе число:");
            var isNumber2 = int.TryParse(Console.ReadLine(), out num2);
            while (isNumber2 == false)
            {
                Console.WriteLine("Введите второе число повторно:");
                isNumber2 = int.TryParse(Console.ReadLine(), out num2);
            }
        }
    }
}
