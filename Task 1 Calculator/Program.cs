using System;

namespace Task_1_Calculator
{
    /// Создайте консольный мини-калькулятор,
    /// который будет подсчитывать сумму двух чисел.
    /// Определите интерфейс для функции сложения числа и
    /// реализуйте его.

    /// Дополнительно: добавьте конструкцию Try/Catch/Finally
    /// для проверки корректности введённого значения.

    class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();
            calculator.NumbersInput(out int num1, out int num2);
            ((ICalculator)calculator).Sum(num1,num2);
        }
    }

    public interface ICalculator
    {
        public int Sum(int a, int b)
        {
            return 0;
        }
    }

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
        }
    }
}
