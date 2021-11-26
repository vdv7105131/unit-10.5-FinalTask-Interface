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
}
